using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var emps = new List<Employee>
            {
                new() {EmpID = 101,EmpName = "Srikanth",Salary = 12345},
                new() {EmpID = 101,EmpName = "Srikanth",Salary = 12345},
                new() {EmpID = 101,EmpName = "Srikanth",Salary = 12345},
                new() {EmpID = 101,EmpName = "Srikanth",Salary = 12345},
                new() {EmpID = 101,EmpName = "Srikanth",Salary = 12345}
            };

            return View(emps);
        }
    }
}
