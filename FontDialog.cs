using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraEditor
{
    public partial class FontDialog : Form
    {
        public Font SelectedFont { get; set; }

        public FontDialog()
        {
            InitializeComponent();
            LoadSystemFonts();
        }

        private void LoadSystemFonts()
        {
            // Vytvoření objektu pro načtení systémových fontů
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Získání všech nainstalovaných fontů
            FontFamily[] fontFamilies = installedFontCollection.Families;

            // Načtení názvů fontů do ComboBox
            foreach (FontFamily font in fontFamilies)
            {
                cboxFont.Items.Add(font.Name);
            }
        }

        private void btnVybrat_Click(object sender, EventArgs e)
        {
            if (cboxFont.SelectedItem != null)
            {
                string fontName = cboxFont.SelectedItem.ToString();
                float fontSize = 12.0f; // nebo jakákoliv jiná výchozí hodnota

                SelectedFont = new Font(fontName, fontSize);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxFont.SelectedItem != null)
            {
                string fontName = cboxFont.SelectedItem.ToString();
                float fontSize = txtNahled.Font.Size;

                Font previewFont = new Font(fontName, fontSize);
                txtNahled.Font = previewFont;
            }
        }
    }
}
