namespace IT_Formlar_Arasi_Gecis
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
            components = new System.ComponentModel.Container();
            lblMesaj = new Label();
            txtMesaj = new TextBox();
            btnGonder = new Button();
            lblMesaj2 = new Label();
            label1 = new Label();
            cmsSagTik = new ContextMenuStrip(components);
            tsmiForm2 = new ToolStripMenuItem();
            lbVeri = new ListBox();
            cmsSagTikSil = new ContextMenuStrip(components);
            tsmiSil = new ToolStripMenuItem();
            btnEkle = new Button();
            cmsSagTik.SuspendLayout();
            cmsSagTikSil.SuspendLayout();
            SuspendLayout();
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(12, 22);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(38, 15);
            lblMesaj.TabIndex = 0;
            lblMesaj.Text = "Mesaj";
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(12, 40);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(100, 23);
            txtMesaj.TabIndex = 1;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(12, 69);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(75, 23);
            btnGonder.TabIndex = 2;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // lblMesaj2
            // 
            lblMesaj2.AutoSize = true;
            lblMesaj2.Location = new Point(12, 136);
            lblMesaj2.Name = "lblMesaj2";
            lblMesaj2.Size = new Size(38, 15);
            lblMesaj2.TabIndex = 3;
            lblMesaj2.Text = "Mesaj";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // cmsSagTik
            // 
            cmsSagTik.Items.AddRange(new ToolStripItem[] { tsmiForm2 });
            cmsSagTik.Name = "cmsSagTik";
            cmsSagTik.Size = new Size(129, 26);
            // 
            // tsmiForm2
            // 
            tsmiForm2.Name = "tsmiForm2";
            tsmiForm2.Size = new Size(128, 22);
            tsmiForm2.Text = "Form 2 Aç";
            tsmiForm2.Click += tsmiForm2_Click;
            // 
            // lbVeri
            // 
            lbVeri.ContextMenuStrip = cmsSagTikSil;
            lbVeri.FormattingEnabled = true;
            lbVeri.Location = new Point(150, 40);
            lbVeri.Name = "lbVeri";
            lbVeri.Size = new Size(120, 94);
            lbVeri.TabIndex = 5;
            // 
            // cmsSagTikSil
            // 
            cmsSagTikSil.Items.AddRange(new ToolStripItem[] { tsmiSil });
            cmsSagTikSil.Name = "cmsSagTikSil";
            cmsSagTikSil.Size = new Size(181, 48);
            // 
            // tsmiSil
            // 
            tsmiSil.Name = "tsmiSil";
            tsmiSil.Size = new Size(180, 22);
            tsmiSil.Text = "Sil";
            tsmiSil.Click += silToolStripMenuItem_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 98);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 205);
            ContextMenuStrip = cmsSagTik;
            Controls.Add(btnEkle);
            Controls.Add(lbVeri);
            Controls.Add(label1);
            Controls.Add(lblMesaj2);
            Controls.Add(btnGonder);
            Controls.Add(txtMesaj);
            Controls.Add(lblMesaj);
            Name = "Form1";
            Text = "Form1";
            cmsSagTik.ResumeLayout(false);
            cmsSagTikSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMesaj;
        private TextBox txtMesaj;
        private Button btnGonder;
        private Label lblMesaj2;
        private Label label1;
        private ContextMenuStrip cmsSagTik;
        private ToolStripMenuItem tsmiForm2;
        private ListBox lbVeri;
        private Button btnEkle;
        private ContextMenuStrip cmsSagTikSil;
        private ToolStripMenuItem tsmiSil;
    }
}
