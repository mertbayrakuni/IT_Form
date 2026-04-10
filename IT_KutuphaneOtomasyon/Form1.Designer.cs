namespace IT_KutuphaneOtomasyon
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            profilToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            profilListeleToolStripMenuItem = new ToolStripMenuItem();
            kitapToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            kitapListeleToolStripMenuItem = new ToolStripMenuItem();
            lbListe = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiGuncelle = new ToolStripMenuItem();
            tsmiSil = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { profilToolStripMenuItem, kitapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ekleToolStripMenuItem, profilListeleToolStripMenuItem });
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(47, 20);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(180, 22);
            ekleToolStripMenuItem.Text = "Ekle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // profilListeleToolStripMenuItem
            // 
            profilListeleToolStripMenuItem.Name = "profilListeleToolStripMenuItem";
            profilListeleToolStripMenuItem.Size = new Size(180, 22);
            profilListeleToolStripMenuItem.Text = "Listele";
            profilListeleToolStripMenuItem.Click += profilListeleToolStripMenuItem_Click;
            // 
            // kitapToolStripMenuItem
            // 
            kitapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem, kitapListeleToolStripMenuItem });
            kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            kitapToolStripMenuItem.Size = new Size(46, 20);
            kitapToolStripMenuItem.Text = "Kitap";
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(180, 22);
            kitapEkleToolStripMenuItem.Text = "Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // kitapListeleToolStripMenuItem
            // 
            kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            kitapListeleToolStripMenuItem.Size = new Size(180, 22);
            kitapListeleToolStripMenuItem.Text = "Listele";
            kitapListeleToolStripMenuItem.Click += kitapListeleToolStripMenuItem_Click;
            // 
            // lbListe
            // 
            lbListe.ContextMenuStrip = contextMenuStrip1;
            lbListe.FormattingEnabled = true;
            lbListe.Location = new Point(12, 60);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(776, 346);
            lbListe.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiGuncelle, tsmiSil });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // tsmiGuncelle
            // 
            tsmiGuncelle.Name = "tsmiGuncelle";
            tsmiGuncelle.Size = new Size(180, 22);
            tsmiGuncelle.Text = "Güncelle";
            tsmiGuncelle.Click += tsmiGuncelle_Click;
            // 
            // tsmiSil
            // 
            tsmiSil.Name = "tsmiSil";
            tsmiSil.Size = new Size(180, 22);
            tsmiSil.Text = "Sil";
            tsmiSil.Click += tsmiSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbListe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "📚 Kütüphane Otomasyonu";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem profilListeleToolStripMenuItem;
        private ToolStripMenuItem kitapToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem kitapListeleToolStripMenuItem;
        private ListBox lbListe;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiGuncelle;
        private ToolStripMenuItem tsmiSil;
    }
}

