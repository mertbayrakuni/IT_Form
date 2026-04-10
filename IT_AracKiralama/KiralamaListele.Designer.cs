namespace IT_AracKiralama
{
    partial class KiralamaListele
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
            components = new System.ComponentModel.Container();
            lbListele = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiGuncelle = new ToolStripMenuItem();
            tsmiSil = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbListele
            // 
            lbListele.ContextMenuStrip = contextMenuStrip1;
            lbListele.Dock = DockStyle.Fill;
            lbListele.FormattingEnabled = true;
            lbListele.Location = new Point(0, 0);
            lbListele.Name = "lbListele";
            lbListele.Size = new Size(650, 354);
            lbListele.TabIndex = 0;
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
            tsmiGuncelle.Click += new System.EventHandler(this.tsmiGuncelle_Click);
            // 
            // tsmiSil
            // 
            tsmiSil.Name = "tsmiSil";
            tsmiSil.Size = new Size(180, 22);
            tsmiSil.Text = "Sil";
            tsmiSil.Click += new System.EventHandler(this.tsmiSil_Click);
            // 
            // KiralamaListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 354);
            Controls.Add(lbListele);
            Name = "KiralamaListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiralama Listele";
            this.Load += new System.EventHandler(this.KiralamaListele_Load);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbListele;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiGuncelle;
        private ToolStripMenuItem tsmiSil;
    }
}
