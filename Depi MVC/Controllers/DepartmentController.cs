using Depi_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Depi_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            WebAppContext _context = new WebAppContext();
            var depts = _context.Departments.ToList();
            return View(depts);
        }
    }
}
