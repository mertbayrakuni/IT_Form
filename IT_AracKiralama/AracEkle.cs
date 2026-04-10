using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_AracKiralama
{
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private Arac _gelenArac;

        public AracEkle(Arac arac)
        {
            InitializeComponent();
            _gelenArac = arac;
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            if (_gelenArac != null)
            {
                this.Text = "Araç Güncelle";
                btnEkle.Text = "Güncelle";
                txtMarka.Text = _gelenArac.Marka;
                txtModel.Text = _gelenArac.Model;
                txtGunlukTutar.Text = _gelenArac.GunlukTutar.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac
            (
                txtMarka.Text.Trim().ToUpper(),
                txtModel.Text.Trim().ToUpper(),
                txtPlaka.Text.Trim().ToUpper(),
                decimal.Parse(txtGunlukTutar.Text)
            );

            if (btnEkle.Text == "Güncelle")
            {
                VeriKaynagi.Araclar.Remove(_gelenArac);
                this.Close();
            }

            VeriKaynagi.Araclar.Add(arac);
            txtMarka.Text = txtModel.Text = txtPlaka.Text = txtGunlukTutar.Text = string.Empty;
            txtMarka.Focus();
        }
    }
}
