using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployee(employee);
                return View("ConfirmPage", employee);
            }
            else
                return View();
        }

        public ViewResult EmployeeData()
        {
            return View(Repository.GetEmployees().Where(e => e.isActive == true));
        }
    }
}