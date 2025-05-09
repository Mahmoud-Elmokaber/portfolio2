using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;
using System.ComponentModel.DataAnnotations;

namespace portfolio2.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contactinfo = _context.contactInfo.First();

            return View(contactinfo);
        }
    }
}
