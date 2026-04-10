namespace IT_AracKiralama
{
    public class Kiralama(Musteri musteri, Arac arac, DateTime baslangicTarihi, DateTime bitisTarihi, decimal toplamTutar)
    {
        public Musteri Musteri { get; set; } = musteri;
        public Arac Arac { get; set; } = arac;
        public DateTime BaslangicTarihi { get; set; } = baslangicTarihi;
        public DateTime BitisTarihi { get; set; } = bitisTarihi;    
        public decimal ToplamTutar { get; set; } = toplamTutar;
        override public string ToString()
        {
            return $"{Musteri} - {Arac} - {BaslangicTarihi.ToShortDateString()} - {BitisTarihi.ToShortDateString()} - {ToplamTutar.ToString("C2", new System.Globalization.CultureInfo("tr-TR"))}";
        }
    }
}
