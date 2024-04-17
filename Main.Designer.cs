namespace UltraEditor
{
    partial class Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.hlavniMenu = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.časADatumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.písmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalamováníŘádkůToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxText = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblPocetZnaku = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKodovani = new System.Windows.Forms.ToolStripStatusLabel();
            this.hlavniMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hlavniMenu
            // 
            this.hlavniMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hlavniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.zobrazitToolStripMenuItem});
            this.hlavniMenu.Location = new System.Drawing.Point(0, 0);
            this.hlavniMenu.Name = "hlavniMenu";
            this.hlavniMenu.Size = new System.Drawing.Size(975, 28);
            this.hlavniMenu.TabIndex = 1;
            this.hlavniMenu.Text = "menuStrip2";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.ukončitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uložitToolStripMenuItem.Text = "Uložit";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ukončitToolStripMenuItem.Text = "Ukončit";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.najítToolStripMenuItem,
            this.časADatumToolStripMenuItem,
            this.písmoToolStripMenuItem});
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.upravitToolStripMenuItem.Text = "Upravit";
            // 
            // najítToolStripMenuItem
            // 
            this.najítToolStripMenuItem.Name = "najítToolStripMenuItem";
            this.najítToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.najítToolStripMenuItem.Text = "Najít";
            // 
            // časADatumToolStripMenuItem
            // 
            this.časADatumToolStripMenuItem.Name = "časADatumToolStripMenuItem";
            this.časADatumToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.časADatumToolStripMenuItem.Text = "Čas a datum";
            // 
            // písmoToolStripMenuItem
            // 
            this.písmoToolStripMenuItem.Name = "písmoToolStripMenuItem";
            this.písmoToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.písmoToolStripMenuItem.Text = "Písmo";
            // 
            // zobrazitToolStripMenuItem
            // 
            this.zobrazitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zalamováníŘádkůToolStripMenuItem});
            this.zobrazitToolStripMenuItem.Name = "zobrazitToolStripMenuItem";
            this.zobrazitToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.zobrazitToolStripMenuItem.Text = "Zobrazit";
            // 
            // zalamováníŘádkůToolStripMenuItem
            // 
            this.zalamováníŘádkůToolStripMenuItem.Name = "zalamováníŘádkůToolStripMenuItem";
            this.zalamováníŘádkůToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.zalamováníŘádkůToolStripMenuItem.Text = "Zalamování řádků";
            this.zalamováníŘádkůToolStripMenuItem.Click += new System.EventHandler(this.zalamováníŘádkůToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 446);
            this.panel1.TabIndex = 2;
            // 
            // tboxText
            // 
            this.tboxText.BackColor = System.Drawing.Color.White;
            this.tboxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxText.Location = new System.Drawing.Point(0, 0);
            this.tboxText.Name = "tboxText";
            this.tboxText.Size = new System.Drawing.Size(975, 446);
            this.tboxText.TabIndex = 1;
            this.tboxText.Text = "";
            this.tboxText.TextChanged += new System.EventHandler(this.tboxText_TextChanged);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPocetZnaku,
            this.lblKodovani});
            this.statusStrip.Location = new System.Drawing.Point(0, 475);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(975, 26);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblPocetZnaku
            // 
            this.lblPocetZnaku.Name = "lblPocetZnaku";
            this.lblPocetZnaku.Size = new System.Drawing.Size(87, 20);
            this.lblPocetZnaku.Text = "Počet znaků";
            // 
            // lblKodovani
            // 
            this.lblKodovani.Name = "lblKodovani";
            this.lblKodovani.Size = new System.Drawing.Size(72, 20);
            this.lblKodovani.Text = "Kódování";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 501);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hlavniMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultra Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.hlavniMenu.ResumeLayout(false);
            this.hlavniMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip hlavniMenu;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem časADatumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem písmoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem zobrazitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalamováníŘádkůToolStripMenuItem;
        private System.Windows.Forms.RichTextBox tboxText;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblPocetZnaku;
        private System.Windows.Forms.ToolStripStatusLabel lblKodovani;
    }
}

