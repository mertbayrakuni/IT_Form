namespace IT_Formlar_Arasi_Gecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string mesaj = txtMesaj.Text;
            Form2 form2 = new(mesaj, this);
            form2.ShowDialog();
        }

        public void MesajAl(string mesaj)
        {
            lblMesaj2.Text = mesaj;
        }

        private void tsmiForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new("Mesaj", this);
            frm.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbVeri.Items.Add(txtMesaj.Text);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lbVeri.SelectedIndex >= 0)
            {
                DialogResult yanit = MessageBox.Show("Veriyi Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    lbVeri.Items.RemoveAt(lbVeri.SelectedIndex);
                }
                else
                {
                    lbVeri.SelectedIndex = 0;
                }
            }
        }
    }
}
