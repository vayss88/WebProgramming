using System.ComponentModel.DataAnnotations;

namespace wayss.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "TC no zorunludur")]
        [RegularExpression("^[0-9]{11}$",ErrorMessage = "TC no 11 haneli ve sadece sayılardan oluşmalıdır")]
        public string InsanNo { get; set; }

    }
}
