using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Insurance.UI.Models;

namespace Insurance.UI.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult FileClaim()
        {
            return View();
        }
    }
}