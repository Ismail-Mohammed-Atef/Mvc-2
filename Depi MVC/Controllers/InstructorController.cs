using Depi_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Depi_MVC.Controllers
{
    public class InstructorController : Controller
    {
        //Instructor/Index
       
        public IActionResult Index()
        {
            WebAppContext context = new WebAppContext();
            var instructors = context.Instructors.ToList();
            return View(instructors);
        }
        public IActionResult Details(int id)
        {
            WebAppContext context = new WebAppContext();
            var instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(instructor);
        }

        
    }
}
