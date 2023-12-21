namespace wayss.Models
{
    public class Hastane
    {
        public int HastaneId { get; set; }
        public string HastaneAdi { get; set; }
        public List<Klinik> Klinikler { get; set; }

        public Hastane()
        {
            Klinikler = new List<Klinik>();
        }
    }
}
