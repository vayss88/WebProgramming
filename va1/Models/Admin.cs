using System;

namespace va1.Models
{
    public class Admin
    {
        // Admin özellikleri
        public int AdminID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Diğer admin özelliklerini eklemek için isteğe bağlı olarak yeni özellikler ekleyebilirsiniz.
    }
}
