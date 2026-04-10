namespace IT_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtAd = new TextBox();
            btnKaydet = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            lbOgrenciler = new ListBox();
            lblDgmTarihi = new Label();
            dtpDTarih = new DateTimePicker();
            lblTCKN = new Label();
            mtbTCKN = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 10;
            label2.Text = "AD:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(108, 45);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(118, 23);
            txtAd.TabIndex = 11;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Magenta;
            btnKaydet.Location = new Point(12, 152);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(214, 36);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(108, 79);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(118, 23);
            txtSoyad.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "SOYAD:";
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.Dock = DockStyle.Bottom;
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.Location = new Point(0, 212);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(240, 199);
            lbOgrenciler.TabIndex = 17;
            // 
            // lblDgmTarihi
            // 
            lblDgmTarihi.AutoSize = true;
            lblDgmTarihi.Location = new Point(12, 111);
            lblDgmTarihi.Name = "lblDgmTarihi";
            lblDgmTarihi.Size = new Size(93, 15);
            lblDgmTarihi.TabIndex = 14;
            lblDgmTarihi.Text = "DOĞUM TARİHİ:";
            // 
            // dtpDTarih
            // 
            dtpDTarih.Format = DateTimePickerFormat.Short;
            dtpDTarih.Location = new Point(108, 108);
            dtpDTarih.MaxDate = new DateTime(2026, 4, 3, 0, 0, 0, 0);
            dtpDTarih.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpDTarih.Name = "dtpDTarih";
            dtpDTarih.Size = new Size(118, 23);
            dtpDTarih.TabIndex = 15;
            dtpDTarih.Value = new DateTime(2026, 4, 3, 0, 0, 0, 0);
            // 
            // lblTCKN
            // 
            lblTCKN.AutoSize = true;
            lblTCKN.Location = new Point(12, 19);
            lblTCKN.Name = "lblTCKN";
            lblTCKN.Size = new Size(40, 15);
            lblTCKN.TabIndex = 18;
            lblTCKN.Text = "TCKN:";
            // 
            // mtbTCKN
            // 
            mtbTCKN.Location = new Point(108, 16);
            mtbTCKN.Mask = "00000000000";
            mtbTCKN.Name = "mtbTCKN";
            mtbTCKN.Size = new Size(118, 23);
            mtbTCKN.TabIndex = 19;
            mtbTCKN.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(240, 411);
            Controls.Add(mtbTCKN);
            Controls.Add(lblTCKN);
            Controls.Add(dtpDTarih);
            Controls.Add(lblDgmTarihi);
            Controls.Add(lbOgrenciler);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(btnKaydet);
            Controls.Add(txtAd);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtAd;
        private Button btnKaydet;
        private TextBox txtSoyad;
        private Label label3;
        private ListBox lbOgrenciler;
        private Label lblDgmTarihi;
        private DateTimePicker dtpDTarih;
        private Label lblTCKN;
        private MaskedTextBox mtbTCKN;
    }
}
