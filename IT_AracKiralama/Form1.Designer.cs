namespace IT_ArackKiralama
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
            menuStrip1 = new MenuStrip();
            tsmiMusteri = new ToolStripMenuItem();
            tsmiMusteriEkle = new ToolStripMenuItem();
            tsmiMusteriListele = new ToolStripMenuItem();
            tsmiArac = new ToolStripMenuItem();
            tsmiAracEkle = new ToolStripMenuItem();
            tsmiAracListele = new ToolStripMenuItem();
            tsmiKiralama = new ToolStripMenuItem();
            tsmiKiralamaEkle = new ToolStripMenuItem();
            tsmiKiralamaListele = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiMusteri, tsmiArac, tsmiKiralama });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiMusteri
            // 
            tsmiMusteri.DropDownItems.AddRange(new ToolStripItem[] { tsmiMusteriEkle, tsmiMusteriListele });
            tsmiMusteri.Name = "tsmiMusteri";
            tsmiMusteri.Size = new Size(59, 20);
            tsmiMusteri.Text = "Müşteri";
            // 
            // tsmiMusteriEkle
            // 
            tsmiMusteriEkle.Name = "tsmiMusteriEkle";
            tsmiMusteriEkle.Size = new Size(180, 22);
            tsmiMusteriEkle.Text = "Ekle";
            tsmiMusteriEkle.Click += tsmiMusteriEkle_Click;
            // 
            // tsmiMusteriListele
            // 
            tsmiMusteriListele.Name = "tsmiMusteriListele";
            tsmiMusteriListele.Size = new Size(180, 22);
            tsmiMusteriListele.Text = "Listele";
            tsmiMusteriListele.Click += tsmiMusteriListele_Click;
            // 
            // tsmiArac
            // 
            tsmiArac.DropDownItems.AddRange(new ToolStripItem[] { tsmiAracEkle, tsmiAracListele });
            tsmiArac.Name = "tsmiArac";
            tsmiArac.Size = new Size(43, 20);
            tsmiArac.Text = "Araç";
            // 
            // tsmiAracEkle
            // 
            tsmiAracEkle.Name = "tsmiAracEkle";
            tsmiAracEkle.Size = new Size(180, 22);
            tsmiAracEkle.Text = "Ekle";
            tsmiAracEkle.Click += tsmiAracEkle_Click;
            // 
            // tsmiAracListele
            // 
            tsmiAracListele.Name = "tsmiAracListele";
            tsmiAracListele.Size = new Size(180, 22);
            tsmiAracListele.Text = "Listele";
            tsmiAracListele.Click += tsmiAracListele_Click;
            // 
            // tsmiKiralama
            // 
            tsmiKiralama.DropDownItems.AddRange(new ToolStripItem[] { tsmiKiralamaEkle, tsmiKiralamaListele });
            tsmiKiralama.Name = "tsmiKiralama";
            tsmiKiralama.Size = new Size(65, 20);
            tsmiKiralama.Text = "Kiralama";
            // 
            // tsmiKiralamaEkle
            // 
            tsmiKiralamaEkle.Name = "tsmiKiralamaEkle";
            tsmiKiralamaEkle.Size = new Size(107, 22);
            tsmiKiralamaEkle.Text = "Ekle";
            tsmiKiralamaEkle.Click += tsmiKiralamaEkle_Click;
            // 
            // tsmiKiralamaListele
            // 
            tsmiKiralamaListele.Name = "tsmiKiralamaListele";
            tsmiKiralamaListele.Size = new Size(107, 22);
            tsmiKiralamaListele.Text = "Listele";
            tsmiKiralamaListele.Click += tsmiKiralamaListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiMusteri;
        private ToolStripMenuItem tsmiMusteriEkle;
        private ToolStripMenuItem tsmiMusteriListele;
        private ToolStripMenuItem tsmiArac;
        private ToolStripMenuItem tsmiAracEkle;
        private ToolStripMenuItem tsmiAracListele;
        private ToolStripMenuItem tsmiKiralama;
        private ToolStripMenuItem tsmiKiralamaEkle;
        private ToolStripMenuItem tsmiKiralamaListele;
    }
}
