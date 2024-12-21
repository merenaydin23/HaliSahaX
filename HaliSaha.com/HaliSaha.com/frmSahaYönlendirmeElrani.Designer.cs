namespace HaliSaha.com
{
    partial class frmSahaYönlendirmeElrani
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
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.SahaListePaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.PnlUstMenu.TabIndex = 3;
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
            // SahaListePaneli
            // 
            this.SahaListePaneli.AutoScroll = true;
            this.SahaListePaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SahaListePaneli.Location = new System.Drawing.Point(0, 45);
            this.SahaListePaneli.Name = "SahaListePaneli";
            this.SahaListePaneli.Size = new System.Drawing.Size(615, 264);
            this.SahaListePaneli.TabIndex = 4;
            this.SahaListePaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.SahaListePaneli_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönlendirme Ekrani";
            // 
            // frmSahaYönlendirmeElrani
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 309);
            this.Controls.Add(this.SahaListePaneli);
            this.Controls.Add(this.PnlUstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSahaYönlendirmeElrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSahaYönlendirmeElrani";
            this.Activated += new System.EventHandler(this.frmSahaYönlendirmeElrani_Activated);
            this.Load += new System.EventHandler(this.frmSahaYönlendirmeElrani_Load);
            this.PnlUstMenu.ResumeLayout(false);
            this.PnlUstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUstMenu;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.FlowLayoutPanel SahaListePaneli;
        private System.Windows.Forms.Label label1;
    }
}