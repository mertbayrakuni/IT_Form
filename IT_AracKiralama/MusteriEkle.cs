using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_AracKiralama
{
    public partial class MusteriEkle : Form
    {
        private DateTime today = DateTime.Now;
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private Musteri _gelenMusteri;

        public MusteriEkle(Musteri musteri)
        {
            InitializeComponent();
            _gelenMusteri = musteri;
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            if (_gelenMusteri != null) 
            {
                this.Text = "Müşteri Güncelle";
                btnEkle.Text = "Güncelle";
                txtAd.Text = _gelenMusteri.Ad;
                txtSoyad.Text = _gelenMusteri.Soyad;
                dtpDogumTarihi.Value = _gelenMusteri.DogumTarihi;
            }

            dtpDogumTarihi.MaxDate = today;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri
            (
                txtAd.Text.Trim().ToUpper(),
                txtSoyad.Text.Trim().ToUpper(),
                dtpDogumTarihi.Value
            );

            if (btnEkle.Text == "Güncelle")
            {
                VeriKaynagi.Musteriler.Remove(_gelenMusteri);
                this.Close();
            }

            VeriKaynagi.Musteriler.Add(musteri);

            txtAd.Text = txtSoyad.Text = string.Empty;
            dtpDogumTarihi.Value = today;
            txtAd.Focus();
        }
    }
}
