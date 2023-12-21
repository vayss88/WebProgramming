using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using wayss.Models;

namespace wayss.Controllers
{
    public class LoginController : Controller
    {

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public IActionResult Index(Login model)
        {
            /*if (ModelState.IsValid)
            {
                // Kullanıcı adı ve şifreyi kontrol et
                // Bu örnekte sadece basit bir kontrol yapılıyor, gerçek uygulamada ASP.NET Identity veya benzeri bir kimlik doğrulama sistemi kullanılabilir.
                bool girisBasarili = true;//GirisKontrolEt(model.InsanNo, model.Password);

                /*if (girisBasarili)
                {
                    // Kullanıcı girişi başarılıysa, rol kontrolü yapabilir ve ilgili sayfaya yönlendirebilirsiniz.
                    var insan = GetInsanByInsanNo(model.InsanNo);

                    if (insan is Hasta)
                    {
                        // Hasta ise HastaController'a yönlendir.
                        return RedirectToAction("RandevuAlma", "Hasta");
                    }
                    else if (insan is Doktor)
                    {
                        // Doktor ise DoktorController'a yönlendir.
                        return RedirectToAction("OlanRandevular", "Doktor");
                    }
                }
                else
                {
                    // Kullanıcı girişi başarısız
                    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı.");
                }*/
            //}

            // Model geçerli değilse veya giriş başarısızsa aynı sayfaya geri dön
            return View(model);
        }

        /*public bool GirisKontrolEt(string No, string Sifre) { 
            
        }*/

    }
}
