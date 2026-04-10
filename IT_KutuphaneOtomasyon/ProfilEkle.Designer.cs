namespace IT_KutuphaneOtomasyon
{
    partial class ProfilEkle
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
            txtAd = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(12, 50);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(12, 92);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(88, 89);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(88, 200);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(100, 23);
            btnGonder.TabIndex = 6;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // ProfilEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 388);
            Controls.Add(btnGonder);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSoyad);
            Controls.Add(txtSoyad);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Name = "ProfilEkle";
            Text = "Profil Ekle";
            this.Load += new System.EventHandler(this.ProfilEkle_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label lblAd;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnGonder;
    }
}