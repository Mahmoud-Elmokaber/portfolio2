using Microsoft.AspNetCore.Mvc;
using portfolio2.Models;

namespace portfolio2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {

            PersonalInfo personalInfo = new PersonalInfo
            {
                Name = "Mahmoud Almokaber",
                JobTitle = "Full Stack .NET Web Developer",
                hook = "Passionate about turning ideas into real, functional web experiences with clean code and user-friendly design.",
                Description = "Hey! I'm Mahmoud, a passionate and curious Full Stack .NET Web Developer who loves turning ideas into real, functional web experiences.\r\n\r\nI specialize in building modern, user-friendly web applications using technologies like HTML, CSS, C#, ASP.NET, MVC, and SQL Server. With a strong foundation in data structures, algorithms, and database design, I enjoy solving problems and making things work behind the scenes just as much as I love crafting smooth front-end experiences.\r\n\r\nI'm currently pursuing a degree in Computer Engineering at Tanta University, Faculty of Engineering, maintaining a CGPA of 3.63 (B+), while also taking on freelance projects to sharpen my skills and learn through real-world challenges.\r\n\r\nSo far, I've worked on an e-commerce website, a complete flight booking database system, and my own portfolio website — each one teaching me something new and pushing me to grow as a developer. I believe in writing clean code, continuously improving, and building things that not only work well but also feel great to use.",
                ImageUrl = "~/images/1.jpg"
            };
            return View(personalInfo);
        }
    }
}
