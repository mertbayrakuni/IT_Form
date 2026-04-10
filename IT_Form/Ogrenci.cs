namespace IT_Form
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Yas 
        {
            get 
            {
                return YasHesapla(DogumTarihi);
            }
        }
        public string TCKN { get; set; }

        private string YasHesapla(DateTime bDate)
        {
            DateTime today = DateTime.Now;
            int yil = today.Year - bDate.Year;
            int ay = today.Month - bDate.Month;
            int gun = today.Day - bDate.Day;
            if (ay < 0)
            {
                yil--;
                ay += 12;
            }

            if (gun < 0)
            {
                ay--;
                gun += DateTime.DaysInMonth(bDate.AddMonths(-1).Year, bDate.AddMonths(-1).Month);
            }
            return yil + " Yıl " + ay + " Ay " + gun + " Gün hayatta kaldınız!";
        }

        public override string ToString()
        {
            return $"Ad: {Ad},Soyad: {Soyad},Dogum Tarihi: {DogumTarihi},Yas: {Yas},TCKN: {TCKN}";
        }
    }
}
