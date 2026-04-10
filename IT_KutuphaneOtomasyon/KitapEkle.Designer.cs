namespace IT_KutuphaneOtomasyon
{
    partial class KitapEkle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBaslik = new Label();
            txtBaslik = new TextBox();
            lblYazar = new Label();
            txtYazar = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(12, 50);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Başlık";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(88, 47);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(180, 23);
            txtBaslik.TabIndex = 1;
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.Location = new Point(12, 92);
            lblYazar.Name = "lblYazar";
            lblYazar.TabIndex = 2;
            lblYazar.Text = "Yazar";
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(88, 89);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(180, 23);
            txtYazar.TabIndex = 3;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(12, 137);
            lblISBN.Name = "lblISBN";
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(88, 134);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 23);
            txtISBN.TabIndex = 5;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(88, 200);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(100, 30);
            btnGonder.TabIndex = 6;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 280);
            Controls.Add(btnGonder);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(lblYazar);
            Controls.Add(txtYazar);
            Controls.Add(lblBaslik);
            Controls.Add(txtBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private TextBox txtBaslik;
        private Label lblYazar;
        private TextBox txtYazar;
        private Label lblISBN;
        private TextBox txtISBN;
        private Button btnGonder;
    }
}
