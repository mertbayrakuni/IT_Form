using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_Form
{
    public partial class FormSayiTahmin : Form
    {
        public FormSayiTahmin()
        {
            InitializeComponent();
        }

        private int hmnGuess = 2;

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hmnGuess > 0) 
            {
                Random random = new Random();
                int cmpGuess = random.Next(1, 10);
                if (txtGuess.Text == cmpGuess.ToString())
                    MessageBox.Show("Success");
                else
                {
                    MessageBox.Show($"Wrong guess try again! {hmnGuess} tries remaining.");
                    txtGuess.Text = string.Empty;
                }
                hmnGuess--;
            }
            else
            {
                MessageBox.Show("Out Of Guesses! YOU SUCK!");
                this.Close();
            }

        }
    }
}
