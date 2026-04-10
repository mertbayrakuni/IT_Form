namespace IT_Form
{
    partial class FormTimer
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
            timer1 = new System.Windows.Forms.Timer(components);
            btnBaslat = new Button();
            btnDur = new Button();
            lblSaat = new Label();
            label1 = new Label();
            lblSayi1 = new Label();
            lblSayi2 = new Label();
            lblSayi3 = new Label();
            lblSayi4 = new Label();
            lblSayi5 = new Label();
            lblSayi6 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.Chartreuse;
            btnBaslat.Location = new Point(211, 105);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(88, 38);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnDur
            // 
            btnDur.BackColor = Color.Yellow;
            btnDur.Location = new Point(309, 105);
            btnDur.Name = "btnDur";
            btnDur.Size = new Size(88, 38);
            btnDur.TabIndex = 1;
            btnDur.Text = "Durdur";
            btnDur.UseVisualStyleBackColor = false;
            btnDur.Click += btnDur_Click;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(294, 87);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(29, 15);
            lblSaat.TabIndex = 2;
            lblSaat.Text = "Saat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(600, 15);
            label1.TabIndex = 3;
            label1.Text = "Ekranda 6 label başlata basınca bu labellar sayılar donucek durdura basınca sanslı sayılar labellar uzerine yazılacak";
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Location = new Point(80, 51);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(37, 15);
            lblSayi1.TabIndex = 4;
            lblSayi1.Text = "Sayı 1";
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Location = new Point(167, 51);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(37, 15);
            lblSayi2.TabIndex = 5;
            lblSayi2.Text = "Sayı 2";
            // 
            // lblSayi3
            // 
            lblSayi3.AutoSize = true;
            lblSayi3.Location = new Point(251, 51);
            lblSayi3.Name = "lblSayi3";
            lblSayi3.Size = new Size(37, 15);
            lblSayi3.TabIndex = 6;
            lblSayi3.Text = "Sayı 3";
            // 
            // lblSayi4
            // 
            lblSayi4.AutoSize = true;
            lblSayi4.Location = new Point(330, 51);
            lblSayi4.Name = "lblSayi4";
            lblSayi4.Size = new Size(37, 15);
            lblSayi4.TabIndex = 7;
            lblSayi4.Text = "Sayı 4";
            // 
            // lblSayi5
            // 
            lblSayi5.AutoSize = true;
            lblSayi5.Location = new Point(416, 51);
            lblSayi5.Name = "lblSayi5";
            lblSayi5.Size = new Size(37, 15);
            lblSayi5.TabIndex = 8;
            lblSayi5.Text = "Sayı 5";
            // 
            // lblSayi6
            // 
            lblSayi6.AutoSize = true;
            lblSayi6.Location = new Point(492, 51);
            lblSayi6.Name = "lblSayi6";
            lblSayi6.Size = new Size(37, 15);
            lblSayi6.TabIndex = 9;
            lblSayi6.Text = "Sayı 6";
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(642, 200);
            Controls.Add(lblSayi6);
            Controls.Add(lblSayi5);
            Controls.Add(lblSayi4);
            Controls.Add(lblSayi3);
            Controls.Add(lblSayi2);
            Controls.Add(lblSayi1);
            Controls.Add(label1);
            Controls.Add(lblSaat);
            Controls.Add(btnDur);
            Controls.Add(btnBaslat);
            Name = "FormTimer";
            Text = "FormTimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnBaslat;
        private Button btnDur;
        private Label lblSaat;
        private Label label1;
        private Label lblSayi1;
        private Label lblSayi2;
        private Label lblSayi3;
        private Label lblSayi4;
        private Label lblSayi5;
        private Label lblSayi6;
    }
}