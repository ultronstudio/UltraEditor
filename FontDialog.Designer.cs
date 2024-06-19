namespace UltraEditor
{
    partial class FontDialog
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
            this.cboxFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.txtNahled = new System.Windows.Forms.Label();
            this.btnVybrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxFont
            // 
            this.cboxFont.FormattingEnabled = true;
            this.cboxFont.Location = new System.Drawing.Point(12, 25);
            this.cboxFont.Name = "cboxFont";
            this.cboxFont.Size = new System.Drawing.Size(302, 21);
            this.cboxFont.TabIndex = 0;
            this.cboxFont.SelectedIndexChanged += new System.EventHandler(this.cboxFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 9);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(58, 13);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Vybrat font";
            // 
            // txtNahled
            // 
            this.txtNahled.AutoSize = true;
            this.txtNahled.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNahled.Location = new System.Drawing.Point(12, 67);
            this.txtNahled.Name = "txtNahled";
            this.txtNahled.Size = new System.Drawing.Size(255, 42);
            this.txtNahled.TabIndex = 2;
            this.txtNahled.Text = "Toto je náhled";
            // 
            // btnVybrat
            // 
            this.btnVybrat.Location = new System.Drawing.Point(320, 25);
            this.btnVybrat.Name = "btnVybrat";
            this.btnVybrat.Size = new System.Drawing.Size(75, 23);
            this.btnVybrat.TabIndex = 3;
            this.btnVybrat.Text = "Vybrat font";
            this.btnVybrat.UseVisualStyleBackColor = true;
            this.btnVybrat.Click += new System.EventHandler(this.btnVybrat_Click);
            // 
            // FontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 128);
            this.Controls.Add(this.btnVybrat);
            this.Controls.Add(this.txtNahled);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cboxFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FontDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label txtNahled;
        private System.Windows.Forms.Button btnVybrat;
    }
}