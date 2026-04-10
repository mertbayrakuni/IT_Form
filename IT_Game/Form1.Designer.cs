namespace IT_Game
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
            btnBaslat = new Button();
            pbAt1 = new PictureBox();
            pbAt2 = new PictureBox();
            pbAt3 = new PictureBox();
            tmrRace = new System.Windows.Forms.Timer(components);
            btnBitis = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAt3).BeginInit();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(12, 36);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(105, 23);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Yarışı Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // pbAt1
            // 
            pbAt1.Image = Properties.Resources._1767852761629263472_128;
            pbAt1.Location = new Point(12, 68);
            pbAt1.Name = "pbAt1";
            pbAt1.Size = new Size(154, 130);
            pbAt1.TabIndex = 1;
            pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            pbAt2.Image = Properties.Resources._1767852761629263472_128;
            pbAt2.Location = new Point(12, 204);
            pbAt2.Name = "pbAt2";
            pbAt2.Size = new Size(154, 126);
            pbAt2.TabIndex = 2;
            pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            pbAt3.Image = Properties.Resources._1767852761629263472_128;
            pbAt3.Location = new Point(9, 336);
            pbAt3.Name = "pbAt3";
            pbAt3.Size = new Size(157, 124);
            pbAt3.TabIndex = 3;
            pbAt3.TabStop = false;
            // 
            // tmrRace
            // 
            tmrRace.Tick += tmrRace_Tick;
            // 
            // btnBitis
            // 
            btnBitis.Location = new Point(902, 36);
            btnBitis.Name = "btnBitis";
            btnBitis.Size = new Size(21, 424);
            btnBitis.TabIndex = 4;
            btnBitis.Text = "B İ Tİ İ Ş";
            btnBitis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 471);
            Controls.Add(btnBitis);
            Controls.Add(pbAt3);
            Controls.Add(pbAt2);
            Controls.Add(pbAt1);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "At Yarışı";
            ((System.ComponentModel.ISupportInitialize)pbAt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAt3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBaslat;
        private PictureBox pbAt1;
        private PictureBox pbAt2;
        private PictureBox pbAt3;
        private System.Windows.Forms.Timer tmrRace;
        private Button btnBitis;
    }
}
