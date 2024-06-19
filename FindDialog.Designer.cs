namespace UltraEditor
{
    partial class FindDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxHledani = new System.Windows.Forms.TextBox();
            this.lblHleadni = new System.Windows.Forms.Label();
            this.chboxVelikost = new System.Windows.Forms.CheckBox();
            this.btnNajit = new System.Windows.Forms.Button();
            this.chboxHledatKonec = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tboxHledani
            // 
            this.tboxHledani.Location = new System.Drawing.Point(12, 29);
            this.tboxHledani.Name = "tboxHledani";
            this.tboxHledani.Size = new System.Drawing.Size(383, 20);
            this.tboxHledani.TabIndex = 0;
            // 
            // lblHleadni
            // 
            this.lblHleadni.AutoSize = true;
            this.lblHleadni.Location = new System.Drawing.Point(13, 13);
            this.lblHleadni.Name = "lblHleadni";
            this.lblHleadni.Size = new System.Drawing.Size(66, 13);
            this.lblHleadni.TabIndex = 1;
            this.lblHleadni.Text = "Hledaný text";
            // 
            // chboxVelikost
            // 
            this.chboxVelikost.AutoSize = true;
            this.chboxVelikost.Location = new System.Drawing.Point(16, 55);
            this.chboxVelikost.Name = "chboxVelikost";
            this.chboxVelikost.Size = new System.Drawing.Size(130, 17);
            this.chboxVelikost.TabIndex = 2;
            this.chboxVelikost.Text = "Shoda velikosti písma";
            this.chboxVelikost.UseVisualStyleBackColor = true;
            // 
            // btnNajit
            // 
            this.btnNajit.Location = new System.Drawing.Point(16, 93);
            this.btnNajit.Name = "btnNajit";
            this.btnNajit.Size = new System.Drawing.Size(75, 23);
            this.btnNajit.TabIndex = 3;
            this.btnNajit.Text = "Najít";
            this.btnNajit.UseVisualStyleBackColor = true;
            this.btnNajit.Click += new System.EventHandler(this.btnNajit_Click);
            // 
            // chboxHledatKonec
            // 
            this.chboxHledatKonec.AutoSize = true;
            this.chboxHledatKonec.Location = new System.Drawing.Point(152, 55);
            this.chboxHledatKonec.Name = "chboxHledatKonec";
            this.chboxHledatKonec.Size = new System.Drawing.Size(105, 17);
            this.chboxHledatKonec.TabIndex = 4;
            this.chboxHledatKonec.Text = "Hledat od konce";
            this.chboxHledatKonec.UseVisualStyleBackColor = true;
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 128);
            this.Controls.Add(this.chboxHledatKonec);
            this.Controls.Add(this.btnNajit);
            this.Controls.Add(this.chboxVelikost);
            this.Controls.Add(this.lblHleadni);
            this.Controls.Add(this.tboxHledani);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindDialog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxHledani;
        private System.Windows.Forms.Label lblHleadni;
        private System.Windows.Forms.CheckBox chboxVelikost;
        private System.Windows.Forms.Button btnNajit;
        private System.Windows.Forms.CheckBox chboxHledatKonec;
    }
}