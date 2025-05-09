using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio2.Models;

namespace portfolio2.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var projects = _context.Projects
                .Include(p => p.technologies)
                .Include(p => p.link)
                .ToList();

            return View(projects);
        }
    }
}
