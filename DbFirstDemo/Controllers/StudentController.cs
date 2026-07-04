using DbFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly TestDbContext context;
        public StudentController(TestDbContext context)
        {
            this.context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
