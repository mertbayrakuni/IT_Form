namespace IT_AracKiralama
{
    partial class AracEkle
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
            lblMarka = new Label();
            lblModel = new Label();
            lblPlaka = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtPlaka = new TextBox();
            lblGunlukTutar = new Label();
            txtGunlukTutar = new TextBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(12, 74);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(43, 15);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 122);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(44, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model:";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Location = new Point(12, 169);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(38, 15);
            lblPlaka.TabIndex = 2;
            lblPlaka.Text = "Plaka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(120, 71);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(120, 119);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 4;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(120, 166);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(100, 23);
            txtPlaka.TabIndex = 5;
            // 
            // lblGunlukTutar
            // 
            lblGunlukTutar.AutoSize = true;
            lblGunlukTutar.Location = new Point(12, 210);
            lblGunlukTutar.Name = "lblGunlukTutar";
            lblGunlukTutar.Size = new Size(79, 15);
            lblGunlukTutar.TabIndex = 6;
            lblGunlukTutar.Text = "Günlük Tutar:";
            // 
            // txtGunlukTutar
            // 
            txtGunlukTutar.Location = new Point(120, 207);
            txtGunlukTutar.Name = "txtGunlukTutar";
            txtGunlukTutar.Size = new Size(100, 23);
            txtGunlukTutar.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(120, 260);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 23);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 385);
            Controls.Add(btnEkle);
            Controls.Add(txtGunlukTutar);
            Controls.Add(lblGunlukTutar);
            Controls.Add(txtPlaka);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblPlaka);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "AracEkle";
            Text = "AracEkle";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblPlaka;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtPlaka;
        private Label lblGunlukTutar;
        private TextBox txtGunlukTutar;
        private Button btnEkle;
    }
}