using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// This is a simple ViewModel to represent the data from the registration form.
// In a real application, you would create this in a separate Models folder.
public class RegisterViewModel
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

// This is a simple ViewModel for the login form.
public class LoginViewModel
{
    public string UsernameOrEmail { get; set; }
    public string Password { get; set; }
}

public class AccountController : Controller
{
    // GET: /Account/Register
    // This action displays the registration form.
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // POST: /Account/Register
    // This action handles the form submission for user registration.
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Here you would use ASP.NET Core Identity to create a new user.
            // Example: var result = await _userManager.CreateAsync(user, model.Password);

            // For now, we'll just show a placeholder message.
            ViewBag.Message = "Registration successful! You can now log in.";
            return View("Login"); // Redirect to the login page after successful registration
        }

        // If the model state is not valid, redisplay the form with errors.
        return View(model);
    }

    // GET: /Account/Login
    // This action displays the login form.
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    // POST: /Account/Login
    // This action handles the form submission for user login.
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Here you would use ASP.NET Core Identity to sign the user in.
            // Example: var result = await _signInManager.PasswordSignInAsync(model.UsernameOrEmail, model.Password, isPersistent: false, lockoutOnFailure: false);

            // For demonstration, we'll assume a successful login and redirect.
            return RedirectToAction("Dashboard", "Home"); // Redirect to the dashboard
        }

        // If the login fails, redisplay the form with an error.
        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        return View(model);
    }

    // POST: /Account/Logout
    // This action handles user logout.
    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        // Here you would use ASP.NET Core Identity to sign the user out.
        // Example: await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home"); // Redirect to the homepage after logout
    }

    // An example of a protected action that requires authentication.
    // The [Authorize] attribute ensures only logged-in users can access this page.
    [HttpGet]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public IActionResult Dashboard()
    {
        // You can access user information via the 'User' object.
        ViewBag.Message = $"Welcome to your dashboard, {User.Identity.Name}!";
        return View();
    }
}
