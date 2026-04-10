namespace IT_AracKiralama
{
    public class Arac(string marka, string model, string property, decimal gunlukTutar)
    {
        public string Marka { get; set; } = marka;
        public string Model { get; set; } = model;
        public string Property { get; set; } = property;
        public decimal GunlukTutar { get; set; } = gunlukTutar;
        public override string ToString()
        {
            return $"{Marka} {Model} - {Property} - {GunlukTutar:C2}";
        }
    }
}
