using IT_AracKiralama;

namespace IT_ArackKiralama
{
    public partial class Form1 : Form
    {
        private DateTime today = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.ShowDialog();
        }

        private void tsmiMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.ShowDialog();
        }

        private void tsmiAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.ShowDialog();
        }

        private void tsmiAracListele_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.ShowDialog();
        }

        private void tsmiKiralamaEkle_Click(object sender, EventArgs e)
        {
            KiralamaEkle kiralamaEkle = new KiralamaEkle();
            kiralamaEkle.ShowDialog();
        }

        private void tsmiKiralamaListele_Click(object sender, EventArgs e)
        {
            KiralamaListele kiralamaListele = new KiralamaListele();
            kiralamaListele.ShowDialog();
        }
    }
}
