using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Insurance.UI.Models;

namespace Insurance.UI.Controllers
{
	public class PolicyController : Controller
	{
		public IActionResult BuyPolicy()
		{
			return View();
		}

        public IActionResult ViewPolicies()
        {
            return View();
        }
    }
}