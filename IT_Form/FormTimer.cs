using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace IT_Form
{
    public partial class FormTimer : Form
    {
        private Random random = new Random();
        public FormTimer()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            List<int> sansliSayilar = SansliSayilar();
            lblSayi1.Text = sansliSayilar[0].ToString();
            lblSayi2.Text = sansliSayilar[1].ToString();
            lblSayi3.Text = sansliSayilar[2].ToString();
            lblSayi4.Text = sansliSayilar[3].ToString();
            lblSayi5.Text = sansliSayilar[4].ToString();
            lblSayi6.Text = sansliSayilar[5].ToString();
        }

        private List<int> SansliSayilar()
        {
            List<int> sayilar = new List<int>();
            while (sayilar.Count < 6)
            {
                int sayi = random.Next(1, 90);
                if (!sayilar.Contains(sayi))
                {
                    sayilar.Add(sayi);
                }
            }
            sayilar.Sort();
            return sayilar;
        }
    }
}
