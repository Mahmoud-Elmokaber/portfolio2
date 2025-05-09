using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;

namespace portfolio2.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactFormController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Form form)
        {
            _context.forms.Add(form);

            if (_context.SaveChanges() > 0)
            { 
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        
    }
}
