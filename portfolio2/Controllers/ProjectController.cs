using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;

namespace portfolio2.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            List<Project> projects = new List<Project>();
            projects.Add(new Project
            {
                Id = 1,
                Title = "E-commerce Platform",
                Description = "A full-stack e-commerce solution for electronic products, featuring a modern UI and seamless shopping experience.",
                ImageUrl = "~/images/E-commerceImage.jpg",
                technology = new List<string> { "C#", "ASP.NET Core", "Entity Framework", "SQL Server", "HTML", "CSS" },
                link = new Link(1, "https://github.com/RenadAlshooni/SWD5_S2_T3")
            });
            projects.Add(new Project
            {
                Id = 2,
                Title = "Flight-booking system database",
                Description = "A database-driven flight booking system built with Microsoft SQL Server. It supports essential functionalities such as flight management, passenger bookings, cancellations, and schedule management.",
                ImageUrl = "~/images/Flight-booking database system.png",
                technology = new List<string> { "Database design", "SQL Server" },
                link = new Link(2, "https://github.com/Mahmoud-Elmokaber/flight-booking-system")
            });
            projects.Add(new Project
            {
                Id = 3,
                Title = "A Portfolio website",
                Description = "A Portfolio that showcases who I am  , my skills , projects that i worked on , contact information  and a way too cennect with me. ",
                ImageUrl = "~/images/PortfolioImage.png",
                technology = new List<string> { "C#", "ASP.NET Core", "Entity Framework", "SQL Server", "HTML", "CSS" },
            });
            return View(projects);
        }
    }
}
