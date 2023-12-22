using System;

namespace va1.Models
{
    public class Musteri
    {
        // Müşteri özellikleri
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Diğer müşteriye ait bilgileri eklemek için isteğe bağlı olarak yeni özellikler ekleyebilirsiniz.
    }
}
