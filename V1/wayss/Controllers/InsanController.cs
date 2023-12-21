using Microsoft.AspNetCore.Mvc;

namespace wayss.Controllers
{
    public class InsanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
