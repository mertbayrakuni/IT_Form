using System;
using System.Windows.Forms;

namespace IT_AracKiralama
{
    public partial class KiralamaListele : Form
    {
        public KiralamaListele()
        {
            InitializeComponent();
        }

        private void KiralamaListele_Load(object sender, EventArgs e)
        {
            foreach (Kiralama kiralama in VeriKaynagi.Kiralamalar)
            {
                lbListele.Items.Add(kiralama);
            }
        }

        private void tsmiGuncelle_Click(object sender, EventArgs e)
        {
            if (lbListele.SelectedItem is Kiralama secilenKiralama)
            {
                KiralamaEkle kiralamaGuncelle = new KiralamaEkle(secilenKiralama);
                kiralamaGuncelle.ShowDialog();
                KiralamaListeleme();
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {
            if (lbListele.SelectedItem is Kiralama secilenKiralama)
            {
                DialogResult dr = MessageBox.Show($"{secilenKiralama.Musteri.Ad} {secilenKiralama.Musteri.Soyad} - {secilenKiralama.Arac.Marka} {secilenKiralama.Arac.Model} kiralamayı silmek istediğinize emin misiniz?", "Kiralama Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    VeriKaynagi.Kiralamalar.Remove(secilenKiralama);
                    KiralamaListeleme();
                }
            }
        }

        private void KiralamaListeleme()
        {
            lbListele.Items.Clear();
            foreach (Kiralama kiralama in VeriKaynagi.Kiralamalar)
            {
                lbListele.Items.Add(kiralama);
            }
        }
    }
}
