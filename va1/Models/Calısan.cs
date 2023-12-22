using System;

namespace va1.Models
{
    public class Calisan
    {
        // Çalışan özellikleri
        public int CalisanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string CalisanMail { get; set; }
        public int SirketID { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Diğer çalışana ait bilgileri eklemek için isteğe bağlı olarak yeni özellikler ekleyebilirsiniz.
    }
}
