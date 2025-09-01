using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Insurance.UI.Models;

namespace Insurance.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login() => View();



        [HttpPost]

        public IActionResult Login(string username, string password) => RedirectToAction("Dashboard");
        public IActionResult Register() => View();
        [HttpPost]
        public IActionResult Register(string username,string email, string password) => RedirectToAction("Dashboard");


        public IActionResult Dashboard() => View();

        public IActionResult ManageCustomers() => View();

        public IActionResult AddCustomer() => View();

        public IActionResult Policies() => View();

        public IActionResult AddPolicy() => View();

        public IActionResult Claims() => View();

        public IActionResult AddClaim() => View();

        public IActionResult Reports() => View();

        public IActionResult GenerateReport() => View();
    }
}
