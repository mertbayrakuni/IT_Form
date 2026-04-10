namespace IT_AracKiralama
{
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            foreach (Musteri musteri in VeriKaynagi.Musteriler)
            {
                lbMusteriler.Items.Add(musteri);
            }
        }

        private void tsmiGuncelle_Click(object sender, EventArgs e)
        {
            if (lbMusteriler.SelectedItems != null)
            {
                Musteri secilenMusteri = (Musteri)lbMusteriler.SelectedItem;
                MusteriEkle musteriGuncelle = new MusteriEkle(secilenMusteri);
                musteriGuncelle.ShowDialog();
                MusteriListeleme();
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {
            Musteri secilenMusteri = (Musteri)lbMusteriler.SelectedItem;
            if (secilenMusteri != null)
            {
                DialogResult dr = MessageBox.Show($"{secilenMusteri.Ad} {secilenMusteri.Soyad} isimli müşteriyi silmek istediğinize emin misiniz?", "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    VeriKaynagi.Musteriler.Remove(secilenMusteri);
                    MusteriListeleme();
                }
            }
        }

        private void MusteriListeleme()
        {
            lbMusteriler.Items.Clear();
            foreach (Musteri musteri in VeriKaynagi.Musteriler)
            {
                lbMusteriler.Items.Add(musteri);
            }
        }
    }
}
