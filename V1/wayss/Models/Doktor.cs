namespace wayss.Models
{
    public class Doktor : Insan
    {
        public List<Randevular> MevcutRandevular { get; set; }
        public List<Randevular> GecmisRandevular { get; set; }

        public Bolum IlgiBolumu { get; set; }
        public Klinik IlgiliKlinik { get; set; }
        public Hastane CalistigiHastane { get; set; }
    }
}
