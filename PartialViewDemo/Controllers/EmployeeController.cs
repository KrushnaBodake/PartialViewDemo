using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Data;

namespace PartialViewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController(ApplicationDbContext context)
        {
                this.context = context;
        }
        public IActionResult Index()
        {
           var emp= context.Employees.ToList();
            return View(emp);
        }
    }
}
