namespace wayss.Models
{
    public class Klinik
    {
        public int KlinikId { get; set; }
        public string KlinikAdi { get; set; }
        public List<Bolum> BulunanBolumler { get; set; }

        public Klinik()
        {
            BulunanBolumler = new List<Bolum>();
        }
    }
}
