namespace IT_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime _today = DateTime.Now;

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDTarih.MaxDate = _today;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dunya");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new();
            ogrenci.Ad = txtAd.Text.Trim();
            ogrenci.Soyad = txtSoyad.Text.Trim();
            ogrenci.DogumTarihi = dtpDTarih.Value;
            string tckn = string.Empty;
            if (Helper.tcknKontrol(mtbTCKN.Text))
            {
                ogrenci.TCKN = mtbTCKN.Text;
            }
            else 
            {
                MessageBox.Show("Hatalı TCKN Girdiniz", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;   
            }
            lbOgrenciler.Items.Add(ogrenci);
            txtAd.Text = txtSoyad.Text = mtbTCKN.Text = string.Empty;
            dtpDTarih.Value = _today;
            mtbTCKN.Focus();
        }

        
    }
}