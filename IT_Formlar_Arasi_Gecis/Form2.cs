using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_Formlar_Arasi_Gecis
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string mesaj, Form1 form1)
        {
            InitializeComponent();
            lblMesaj.Text = mesaj;
            this.form1 = form1;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            form1.MesajAl(txtMesaj.Text);
        }
    }
}
