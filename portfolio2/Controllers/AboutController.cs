using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;

namespace portfolio2.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

                var personalInfo = _context.personalInfo.First();

                return View(personalInfo);
        }
    }
}
