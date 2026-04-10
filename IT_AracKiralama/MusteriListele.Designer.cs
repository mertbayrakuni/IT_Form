namespace IT_AracKiralama
{
    partial class MusteriListele
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
            components = new System.ComponentModel.Container();
            lbMusteriler = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiGuncelle = new ToolStripMenuItem();
            tsmiSil = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMusteriler
            // 
            lbMusteriler.ContextMenuStrip = contextMenuStrip1;
            lbMusteriler.Dock = DockStyle.Fill;
            lbMusteriler.FormattingEnabled = true;
            lbMusteriler.Location = new Point(0, 0);
            lbMusteriler.Name = "lbMusteriler";
            lbMusteriler.Size = new Size(306, 318);
            lbMusteriler.TabIndex = 0;
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
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 318);
            Controls.Add(lbMusteriler);
            Name = "MusteriListele";
            Text = "MusteriListele";
            Load += MusteriListele_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMusteriler;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiGuncelle;
        private ToolStripMenuItem tsmiSil;
    }
}