using Insurance.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Insurance.UI.Controllers
{
    // The class definition for the HomeController goes here
    public class HomeController : Controller
    {
        // This is the public method for the Index action
        public IActionResult Index() => View();

        // The Dashboard action with the Authorize attribute
        [Authorize]
        public IActionResult Dashboard()
        {
            // If the login failed, the user will be redirected to the Login page
            // before this code even executes.
            return View();
        }
    }
}
