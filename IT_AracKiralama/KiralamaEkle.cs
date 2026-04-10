using System;
using System.Windows.Forms;

namespace IT_AracKiralama
{
    public partial class KiralamaEkle : Form
    {
        private Kiralama _gelenKiralama;

        public KiralamaEkle()
        {
            InitializeComponent();
        }

        public KiralamaEkle(Kiralama kiralama)
        {
            InitializeComponent();
            _gelenKiralama = kiralama;
        }

        private void KiralamaEkle_Load(object sender, EventArgs e)
        {
            cbMusteri.DataSource = VeriKaynagi.Musteriler;
            cbArac.DataSource = VeriKaynagi.Araclar;

            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now.AddDays(1);

            if (_gelenKiralama != null)
            {
                this.Text = "Kiralama Güncelle";
                btnEkle.Text = "Güncelle";
                cbMusteri.SelectedItem = _gelenKiralama.Musteri;
                cbArac.SelectedItem = _gelenKiralama.Arac;
                dtpBaslangic.Value = _gelenKiralama.BaslangicTarihi;
                dtpBitis.Value = _gelenKiralama.BitisTarihi;
            }

            ToplamTutarHesapla();
        }

        private void ToplamTutarHesapla()
        {
            if (cbArac.SelectedItem is Arac arac)
            {
                int gun = (dtpBitis.Value.Date - dtpBaslangic.Value.Date).Days;
                if (gun < 1) gun = 1;
                lblToplamTutar.Text = (gun * arac.GunlukTutar).ToString("C2", new System.Globalization.CultureInfo("tr-TR"));
            }
        }

        private void cbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbMusteri.SelectedItem is not Musteri musteri)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbArac.SelectedItem is not Arac arac)
            {
                MessageBox.Show("Lütfen bir araç seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int gun = (dtpBitis.Value.Date - dtpBaslangic.Value.Date).Days;
            if (gun < 1)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kiralama kiralama = new Kiralama(musteri, arac, dtpBaslangic.Value.Date, dtpBitis.Value.Date, gun * arac.GunlukTutar);

            if (btnEkle.Text == "Güncelle")
            {
                VeriKaynagi.Kiralamalar.Remove(_gelenKiralama);
                this.Close();
            }

            VeriKaynagi.Kiralamalar.Add(kiralama);
            cbMusteri.SelectedIndex = 0;
            cbArac.SelectedIndex = 0;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now.AddDays(1);
        }
    }
}
