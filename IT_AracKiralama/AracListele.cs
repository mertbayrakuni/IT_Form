using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_AracKiralama
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            foreach (Arac arac in VeriKaynagi.Araclar)
            {
                lbListele.Items.Add(arac);
            }
        }

        private void tsmiGuncelle_Click(object sender, EventArgs e)
        {
            if (lbListele.SelectedItems != null)
            {
                Arac secilenArac = (Arac)lbListele.SelectedItem;
                AracEkle aracGuncelle = new AracEkle(secilenArac);
                aracGuncelle.ShowDialog();
                AracListeleme();
            }
        }

        private void tsmiSil_Click(object sender, EventArgs e)
        {
            Arac secilenArac = (Arac)lbListele.SelectedItem;
            if (secilenArac != null)
            {
                DialogResult dr = MessageBox.Show($"{secilenArac.Marka} {secilenArac.Model} isimli aracı silmek istediğinize emin misiniz?", "Araç Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    VeriKaynagi.Araclar.Remove(secilenArac);
                    AracListeleme();
                }
            }
        }

        private void AracListeleme()
        {
            lbListele.Items.Clear();
            foreach (Arac arac in VeriKaynagi.Araclar)
            {
                lbListele.Items.Add(arac);
            }
        }
    }
}
