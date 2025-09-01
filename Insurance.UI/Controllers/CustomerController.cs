using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Insurance.UI.Models;

namespace Insurance.UI.Controllers { 


    public class CustomerController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Login(string email, string password) => RedirectToAction("Dashboard");

        public IActionResult Register() => View();
        [HttpPost]
        public IActionResult Register(string username, string email, string password) => RedirectToAction("Dashboard");

        public IActionResult Dashboard() => View();

        public IActionResult Profile() => View();

        public IActionResult BuyPolicy() => View();
        public IActionResult MyClaimsHistory() => View();
        public IActionResult FileClaim() => View();
    }
}
