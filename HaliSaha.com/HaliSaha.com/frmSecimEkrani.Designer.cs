namespace HaliSaha.com
{
    partial class frmSecimEkrani
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
            this.PnlUstMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlUstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUstMenu
            // 
            this.PnlUstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlUstMenu.Controls.Add(this.label1);
            this.PnlUstMenu.Controls.Add(this.Btn_Kapat);
            this.PnlUstMenu.Controls.Add(this.PnLogo);
            this.PnlUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUstMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlUstMenu.Name = "PnlUstMenu";
            this.PnlUstMenu.Size = new System.Drawing.Size(615, 45);
            this.PnlUstMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "İşlem Tercih Ekranı";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Kapat.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kapat.ForeColor = System.Drawing.Color.White;
            this.Btn_Kapat.Location = new System.Drawing.Point(549, 0);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(66, 45);
            this.Btn_Kapat.TabIndex = 1;
            this.Btn_Kapat.Text = "X";
            this.Btn_Kapat.UseCompatibleTextRendering = true;
            this.Btn_Kapat.UseVisualStyleBackColor = false;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.Size = new System.Drawing.Size(22, 45);
            this.PnLogo.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(295, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "KAYIT DÜZENLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(39, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "YENİ KAYIT ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSecimEkrani
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 137);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PnlUstMenu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSecimEkrani";
            this.PnlUstMenu.ResumeLayout(false);
            this.PnlUstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUstMenu;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}