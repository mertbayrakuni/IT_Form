namespace IT_AracKiralama
{
    partial class KiralamaEkle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblMusteri = new Label();
            cbMusteri = new ComboBox();
            lblArac = new Label();
            cbArac = new ComboBox();
            lblBaslangic = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBitis = new Label();
            dtpBitis = new DateTimePicker();
            lblToplamTutarTitle = new Label();
            lblToplamTutar = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // lblMusteri
            // 
            lblMusteri.AutoSize = true;
            lblMusteri.Location = new Point(12, 30);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.TabIndex = 0;
            lblMusteri.Text = "Müşteri:";
            // 
            // cbMusteri
            // 
            cbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMusteri.FormattingEnabled = true;
            cbMusteri.Location = new Point(150, 27);
            cbMusteri.Name = "cbMusteri";
            cbMusteri.Size = new Size(220, 23);
            cbMusteri.TabIndex = 1;
            // 
            // lblArac
            // 
            lblArac.AutoSize = true;
            lblArac.Location = new Point(12, 75);
            lblArac.Name = "lblArac";
            lblArac.TabIndex = 2;
            lblArac.Text = "Araç:";
            // 
            // cbArac
            // 
            cbArac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArac.FormattingEnabled = true;
            cbArac.Location = new Point(150, 72);
            cbArac.Name = "cbArac";
            cbArac.Size = new Size(220, 23);
            cbArac.TabIndex = 3;
            cbArac.SelectedIndexChanged += new System.EventHandler(this.cbArac_SelectedIndexChanged);
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(12, 120);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.TabIndex = 4;
            lblBaslangic.Text = "Başlangıç:";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(150, 117);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(150, 23);
            dtpBaslangic.TabIndex = 5;
            dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(12, 165);
            lblBitis.Name = "lblBitis";
            lblBitis.TabIndex = 6;
            lblBitis.Text = "Bitiş:";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(150, 162);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(150, 23);
            dtpBitis.TabIndex = 7;
            dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // lblToplamTutarTitle
            // 
            lblToplamTutarTitle.AutoSize = true;
            lblToplamTutarTitle.Location = new Point(12, 210);
            lblToplamTutarTitle.Name = "lblToplamTutarTitle";
            lblToplamTutarTitle.TabIndex = 8;
            lblToplamTutarTitle.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(150, 210);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.TabIndex = 9;
            lblToplamTutar.Text = "0,00 ₺";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(150, 255);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 30);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KiralamaEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 320);
            Controls.Add(btnEkle);
            Controls.Add(lblToplamTutar);
            Controls.Add(lblToplamTutarTitle);
            Controls.Add(dtpBitis);
            Controls.Add(lblBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lblBaslangic);
            Controls.Add(cbArac);
            Controls.Add(lblArac);
            Controls.Add(cbMusteri);
            Controls.Add(lblMusteri);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "KiralamaEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiralama Ekle";
            this.Load += new System.EventHandler(this.KiralamaEkle_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusteri;
        private ComboBox cbMusteri;
        private Label lblArac;
        private ComboBox cbArac;
        private Label lblBaslangic;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private DateTimePicker dtpBitis;
        private Label lblToplamTutarTitle;
        private Label lblToplamTutar;
        private Button btnEkle;
    }
}
