using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraEditor
{
    public partial class Main : Form
    {
        private bool zalamovaniRadku = true; // stav zalamování řádku
        private string vychoziNazev = "Bez názvu"; // výchozí název nového souboru
        private int vychoziPocetZnaku = 0; // výchozí počet znaků prázdného souboru
        private Encoding kodovani = Encoding.UTF8; // standardní kódování pro soubory
        private string slozka = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        private bool jeUlozeny = false;
        private string uzivateluvSoubor;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Počet znaků v textboxu
        /// </summary>
        /// <param name="pocet">Číslo počtu znaků</param>
        /// <returns>Celkový počet znaků se správně vyskloňovanou koncovkou</returns>
        private string VratPocetZnaku(int pocet)
        {
            switch (pocet)
            {
                case 1:
                    return $"{pocet} znak";
                case 2:
                case 3:
                case 4:
                    return $"{pocet} znaky";
                default:
                    return $"{pocet} znaků";
            }
        }

        // výchozí nastavení při načtení nového okna editoru
        private void Main_Load(object sender, EventArgs e)
        {
            zalamováníŘádkůToolStripMenuItem.Checked = zalamovaniRadku;
            tboxText.WordWrap = zalamovaniRadku;
            Text = $"{vychoziNazev} | Ultra Editor"; // výchozí titulek okna editoru
            lblPocetZnaku.Text = VratPocetZnaku(vychoziPocetZnaku); // nastavení textu počtu znaků
            lblKodovani.Text = kodovani.EncodingName; // nastavení textu kódování
        }

        // stav zalamování řádků v editoru
        private void zalamováníŘádkůToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zalamovaniRadku = !zalamovaniRadku;
            zalamováníŘádkůToolStripMenuItem.Checked = zalamovaniRadku;
            tboxText.WordWrap = zalamovaniRadku;
        }

        // změny v textboxu
        private void tboxText_TextChanged(object sender, EventArgs e)
        {
            lblPocetZnaku.Text = VratPocetZnaku(tboxText.Text.Length); // aktualizace počtu znaků

            // přidání indikátoru neuloženého souboru
            if (!Text.StartsWith("*"))
            {
                Text = $"* {Text}";
            }

            jeUlozeny = false;
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.Title = "Uložit soubor";
            saveFile.DefaultExt = "uet";
            saveFile.FileName = vychoziNazev;
            saveFile.InitialDirectory = slozka;
            saveFile.Filter = "Ultra Editor Text (*.uet)|*.uet";
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;

            if (!jeUlozeny)
            {
                if (string.IsNullOrEmpty(uzivateluvSoubor))
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        uzivateluvSoubor = saveFile.FileName;
                        UlozSoubor(uzivateluvSoubor);
                    }
                }
                else
                {
                    UlozSoubor(uzivateluvSoubor);
                }
            }
            else
            {
                UlozSoubor(uzivateluvSoubor);
            }
        }

        private void UlozSoubor(string cesta)
        {
            try
            {
                string nazevDokumentu = Path.GetFileNameWithoutExtension(cesta);
                string datumPrvnihoUlozeni;
                string datumPosledniUpravy = DateTime.Now.ToString("dd. MM. yyyy HH:mm:ss");
                string pouzityFont = tboxText.Font.Name;
                string uzivatel = Environment.UserName;

                if (File.Exists(cesta))
                {
                    // Soubor již existuje, načteme metadata
                    string[] radky = File.ReadAllLines(cesta);
                    datumPrvnihoUlozeni = radky[1].Split(new[] { ": " }, StringSplitOptions.None)[1];
                }
                else
                {
                    // Soubor neexistuje, nastavíme datum prvního uložení na aktuální čas
                    datumPrvnihoUlozeni = DateTime.Now.ToString("dd. MM. yyyy HH:mm:ss");
                }

                // Metadata jako první řádky souboru
                StringBuilder metadata = new StringBuilder();
                metadata.AppendLine($"Název dokumentu: {nazevDokumentu}");
                metadata.AppendLine($"Datum prvního uložení: {datumPrvnihoUlozeni}");
                metadata.AppendLine($"Datum poslední úpravy: {datumPosledniUpravy}");
                metadata.AppendLine($"Použitý font: {pouzityFont}");
                metadata.AppendLine($"Uživatel: {uzivatel}");
                metadata.AppendLine("==== OBSAH DOKUMENTU ====");

                // Obsah dokumentu
                string obsah = tboxText.Text;

                // Uložení metadat a obsahu do souboru
                File.WriteAllText(cesta, metadata.ToString() + Environment.NewLine + obsah);

                // Nastavení nového titulku okna editoru s názvem právě uloženého souboru
                Text = $"{nazevDokumentu} | Ultra Editor";

                jeUlozeny = true;

                MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba při uložení souboru:\r\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!jeUlozeny)
            {
                DialogResult result = MessageBox.Show($"Chcete uložit změny do: {vychoziNazev}?", "Ultra Editor", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    uložitToolStripMenuItem_Click(sender, e);
                    Environment.Exit(0);
                }
                else if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }
                else
                {
                    return;
                }
            }
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Title = "Otevřít soubor";
            openFile.FileName = "";
            openFile.DefaultExt = "uet";
            openFile.InitialDirectory = slozka;
            openFile.Filter = "Ultra Editor Text (*.uet)|*.uet";
            openFile.AddExtension = true;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string cilovySoubor = openFile.FileName;

                try
                {
                    // Přečtení celého souboru
                    string obsahSouboru = File.ReadAllText(cilovySoubor);

                    // Rozdělení obsahu souboru na řádky
                    string[] radky = obsahSouboru.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    // Načtení metadat
                    string nazevDokumentu = radky[0].Split(new[] { ": " }, StringSplitOptions.None)[1];
                    string datumPrvnihoUlozeni = radky[1].Split(new[] { ": " }, StringSplitOptions.None)[1];
                    string datumPosledniUpravy = radky[2].Split(new[] { ": " }, StringSplitOptions.None)[1];
                    string pouzityFont = radky[3].Split(new[] { ": " }, StringSplitOptions.None)[1];
                    string uzivatel = radky[4].Split(new[] { ": " }, StringSplitOptions.None)[1];

                    // Načtení obsahu dokumentu (přeskočení řádků s metadaty a prázdných řádků)
                    StringBuilder obsahDokumentu = new StringBuilder();
                    for (int i = 6; i < radky.Length; i++)
                    {
                        obsahDokumentu.AppendLine(radky[i]);
                    }

                    // Nastavení fontu na TextBox
                    tboxText.Font = new Font(pouzityFont, tboxText.Font.Size);

                    // Nastavení obsahu dokumentu do TextBox
                    tboxText.Text = obsahDokumentu.ToString();

                    // Nastavení nového titulku okna editoru s názvem právě otevřeného souboru
                    Text = $"{nazevDokumentu} | Ultra Editor";

                    // Uložení cesty k souboru
                    uzivateluvSoubor = cilovySoubor;

                    jeUlozeny = true;
                }
                catch (Exception ex)
                {
                    // Zpráva o chybě, pokud otevření selže
                    MessageBox.Show($"Nastala chyba při otevření souboru:\r\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // Zachycení kombinace kláves Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                uložitToolStripMenuItem_Click(sender, e);
                // Zabránění dalšímu zpracování události
                e.SuppressKeyPress = true;
            }
        }

        // vložení aktuálního data a času na aktuální místo kurzoru
        private void časADatumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Získání aktuálního data a času
            string currentDateTime = DateTime.Now.ToString("dd. MM. yyyy HH:mm:ss");

            // Vložení data a času na aktuální místo kurzoru v RichTextBox
            int selectionStart = tboxText.SelectionStart;
            tboxText.Text = tboxText.Text.Insert(selectionStart, currentDateTime);
            tboxText.SelectionStart = selectionStart + currentDateTime.Length;
        }

        private void písmoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                // Nastavení aktuálního písma v dialogu
                fontDialog.SelectedFont = tboxText.Font;

                // Pokud uživatel klikne na OK
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Nastavení vybraného písma na RichTextBox
                    tboxText.Font = fontDialog.SelectedFont;
                }
            }
        }

        private void najítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var findDialog = new FindDialog())
            {
                // Zobrazení dialogu pro vyhledávání
                if (findDialog.ShowDialog() == DialogResult.OK)
                {
                    string searchText = findDialog.SearchText; // Získání hledaného textu z dialogu
                    bool matchCase = findDialog.MatchCase; // Získání volby "Match Case" z dialogu
                    bool searchFromEnd = findDialog.SearchFromEnd; // Získání volby "Search from end" z dialogu

                    // Nastavení parametrů pro hledání
                    RichTextBoxFinds options = matchCase ? RichTextBoxFinds.MatchCase : RichTextBoxFinds.None;
                    if (searchFromEnd)
                    {
                        options |= RichTextBoxFinds.Reverse;
                    }

                    // Hledání textu v RichTextBoxu
                    int index = tboxText.Find(searchText, tboxText.SelectionStart + tboxText.SelectionLength, options);

                    // Pokud je nalezeno, označí se nalezené slovo
                    if (index != -1)
                    {
                        tboxText.SelectionStart = index;
                        tboxText.SelectionLength = searchText.Length;
                        tboxText.Focus();
                    }
                    else
                    {
                        // Pokud není nalezeno, zobrazí se upozornění
                        MessageBox.Show($"Slovo \"{searchText}\" nebylo nalezeno.", "Nenalezeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
