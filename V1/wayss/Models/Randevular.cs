using System.ComponentModel.DataAnnotations;

namespace wayss.Models
{
    public class Randevular
    {
        [Key]
        public int RandevuId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public bool Onaylandi { get; set; }
        // Diğer randevu özellikleri...

        public int InsanId { get; set; }
        public Insan Insan { get; set; }
    }
}
