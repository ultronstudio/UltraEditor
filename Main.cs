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
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.DefaultExt = "uet";
            saveFile.FileName = vychoziNazev;
            saveFile.InitialDirectory = slozka;
            saveFile.Filter = "Ultra Editor Text (*.uet)|*.uet";
            saveFile.AddExtension = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Získání vybraného umístění pro uložení souboru
                string cilovySoubor = saveFile.FileName;

                try
                {
                    // Uložení obsahu TextBoxu do souboru
                    File.WriteAllText(cilovySoubor, tboxText.Text);

                    // nastavení nového titulku okna editoru s názvem právě uloženého souboru
                    Text = $"{Path.GetFileNameWithoutExtension(cilovySoubor)} | Ultra Editor";

                    // Zpráva pro potvrzení, že soubor byl úspěšně uložen
                    MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Zpráva o chybě, pokud uložení selže
                    MessageBox.Show($"Nastala chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
