using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;
using System.ComponentModel.DataAnnotations;

namespace portfolio2.Controllers
{
    public class ContactInfoController : Controller
    {
        public IActionResult Index()
        {
            ContactInfo contactinfo = new ContactInfo()
            {
                Email = "mahmoudelmokaber4@gmail.com",
                Phone = "+20 102-346-9727",
                Location = "Tanta, Egypt",
                IsAvailable = false
            };
                

            return View(contactinfo);
        }
    }
}
