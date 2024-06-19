using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraEditor
{
    public partial class FindDialog : Form
    {
        public string SearchText { get; set; }
        public bool MatchCase { get; set; }
        public bool SearchFromEnd { get; set; }

        public FindDialog()
        {
            InitializeComponent();
        }

        private void btnNajit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxHledani.Text))
            {
                MessageBox.Show("Zadejte hledaný text.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchText = tboxHledani.Text;
            MatchCase = chboxVelikost.Checked;
            SearchFromEnd = chboxHledatKonec.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
