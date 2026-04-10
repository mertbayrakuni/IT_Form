namespace IT_AracKiralama
{
    public class Musteri(string ad, string soyad, DateTime dogumTarihi)
    {
        public string Ad { get; set; } = ad;
        public string Soyad { get; set; } = soyad;
        public DateTime DogumTarihi { get; set; } = dogumTarihi;
        //public Musteri(string ad, string soyad, DateTime dogumTarih) 
        //{
        //    Ad = ad;
        //    Soyad = soyad;
        //    DogumTarih = dogumTarih;
        //}
        public override string ToString()
        {
            return $"{Ad} {Soyad} - {DogumTarihi.ToShortDateString()}";
        }
    }
}
