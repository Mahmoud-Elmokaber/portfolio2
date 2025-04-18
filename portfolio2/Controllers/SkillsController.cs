using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;
namespace portfolio2.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            List<Skill> skills = new List<Skill>();
            skills.Add(new Skill
            {
                Id = 1,
                Name = "C#",
                Percentage = 90
            });
            skills.Add(new Skill
            {
                Id = 2,
                Name = "HTML5",
                Percentage = 75
            });
            skills.Add(new Skill
            {
                Id = 3,
                Name = "CSS",
                Percentage = 60
            });
            skills.Add(new Skill
            {
                Id = 4,
                Name = "MVC",
                Percentage = 75
            });
            skills.Add(new Skill
            {
                Id = 5,
                Name = "Problem solving algorithms",
                Percentage = 65
            }); 
            skills.Add(new Skill
            {
                Id = 6,
                Name = "Python",
                Percentage = 70
            }); skills.Add(new Skill
            {
                Id = 7,
                Name = "Data structures",
                Percentage = 70
            }); skills.Add(new Skill
            {
                Id = 8,
                Name = "DataBase design",
                Percentage = 80
            });
            return View(skills);
        }
    }
}
