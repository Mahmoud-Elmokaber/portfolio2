using Microsoft.AspNetCore.Mvc;

namespace portfolio2.Controllers
{
    public class ContactFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
