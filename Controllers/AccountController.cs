using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiAuthentication.ClientWithAPI.Models;

namespace WebApiAuthentication.ClientWithAPI.Controllers;

public class AccountController : Controller
{ 
    public IActionResult Login()
    {
        return View();
    }
 

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (model.Username == "Omar" && model.Password == "123456")
        {

            var claims = new List<Claim>
            {
                new (ClaimTypes.Name, model.Username),
                new (ClaimTypes.Email, "omar@gmail.com"),
                new (ClaimTypes.Country, "Tunisia"),
            };
            
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            var authProperties = new AuthenticationProperties()
            {
                //optionally set preferred properties
                ExpiresUtc = DateTime.UtcNow.AddMinutes(30),
            };
            
            await HttpContext
                .SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, authProperties);

            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        return View(model);
    }

    [Authorize]
    public async Task<IActionResult> Logout()
    { 
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        
        return RedirectToAction("Login", "Account");
    }
}
