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
            openFile.Title = "Uložit soubor";
            saveFile.DefaultExt = "uet";
            saveFile.FileName = vychoziNazev;
            saveFile.InitialDirectory = slozka;
            saveFile.Filter = "Ultra Editor Text (*.uet)|*.uet";
            saveFile.AddExtension = true;
            saveFile.RestoreDirectory = true;

            if(!jeUlozeny)
            {
                if(string.IsNullOrEmpty(uzivateluvSoubor))
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        // Získání vybraného umístění pro uložení souboru
                        string cilovySoubor = saveFile.FileName;

                        uzivateluvSoubor = saveFile.FileName;

                        try
                        {
                            // Uložení obsahu TextBoxu do souboru
                            File.WriteAllText(cilovySoubor, tboxText.Text);

                            // nastavení nového titulku okna editoru s názvem právě uloženého souboru
                            Text = $"{Path.GetFileNameWithoutExtension(cilovySoubor)} | Ultra Editor";

                            jeUlozeny = true;

                            uzivateluvSoubor = cilovySoubor;

                            // Zpráva pro potvrzení, že soubor byl úspěšně uložen
                            MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Zpráva o chybě, pokud uložení selže
                            MessageBox.Show($"Nastala chyba při uložení souboru:\r\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    try
                    {
                        // Získání vybraného umístění pro uložení souboru
                        string cilovySoubor = uzivateluvSoubor;

                        File.WriteAllText(uzivateluvSoubor, tboxText.Text); // Použijeme cestu k uloženému souboru

                        // nastavení nového titulku okna editoru s názvem právě uloženého souboru
                        Text = $"{Path.GetFileNameWithoutExtension(cilovySoubor)} | Ultra Editor";

                        jeUlozeny = true;

                        uzivateluvSoubor = cilovySoubor;

                        MessageBox.Show("Změny byly úspěšně uloženy.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Nastala chyba při ukládání změn:\r\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    string cilovySoubor = uzivateluvSoubor;

                    File.WriteAllText(uzivateluvSoubor, tboxText.Text); // Použijeme cestu k uloženému souboru

                    // nastavení nového titulku okna editoru s názvem právě uloženého souboru
                    Text = $"{Path.GetFileNameWithoutExtension(cilovySoubor)} | Ultra Editor";

                    jeUlozeny = true;

                    uzivateluvSoubor = cilovySoubor;

                    MessageBox.Show("Změny byly úspěšně uloženy.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nastala chyba při ukládání změn:\r\n{ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                // nastavení nového titulku okna editoru s názvem právě otevřeného souboru
                Text = $"{Path.GetFileNameWithoutExtension(cilovySoubor)} | Ultra Editor";

                try
                {
                    StreamReader reader = new StreamReader(cilovySoubor);

                    tboxText.Text = ""; // vyprázdnění textboxu po otevření nového souboru

                    while(!reader.EndOfStream)
                    {
                        tboxText.Text += reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    // Zpráva o chybě, pokud uložení selže
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
    }
}
