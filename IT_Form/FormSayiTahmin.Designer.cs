namespace IT_Form
{
    partial class FormSayiTahmin
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
            label1 = new Label();
            label2 = new Label();
            txtGuess = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistem 1 ile 10 Arasında Bir Sayı Tutsun.\r\nKullanıcıya Tahmin Etmesi i.in 3 Hak Tanınsın.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Tahmininiz:";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(130, 119);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 2;
            txtGuess.TextChanged += txtGuess_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(250, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Tahmin Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSayiTahmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 276);
            Controls.Add(button1);
            Controls.Add(txtGuess);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSayiTahmin";
            Text = "FormSayiTahmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGuess;
        private Button button1;
    }
}