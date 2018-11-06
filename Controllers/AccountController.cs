using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AIMS_Portal.Data;
using AIMS_Portal.Models;
using CryptoHelper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AIMS_Portal.Controllers
{
    public class AccountController : Controller
    {
        //private readonly DataContext _context;

        //public int Id { get; set; }

        //public AccountController(DataContext context)
        //{
        //    _context = context;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(UserAccountViewModel user)
        //{
        //    var userLog = await _context.User
        //        .SingleOrDefaultAsync(m => m.Email == user.Email);
        //    try
        //    {
        //        bool pass = Crypto.VerifyHashedPassword(userLog.Password, user.Password);
        //        if (pass == true)
        //        {
        //            var claims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Email, userLog.Email),
        //                new Claim(ClaimTypes.Role, userLog.Role)
        //            };

        //            var claimsIdentity = new ClaimsIdentity(
        //                claims, CookieAuthenticationDefaults.AuthenticationScheme);

        //            var authProperties = new AuthenticationProperties
        //            {
        //                //AllowRefresh = <bool>,
        //                // Refreshing the authentication session should be allowed.

        //                //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
        //                // The time at which the authentication ticket expires. A 
        //                // value set here overrides the ExpireTimeSpan option of 
        //                // CookieAuthenticationOptions set with AddCookie.

        //                //IsPersistent = true,
        //                // Whether the authentication session is persisted across 
        //                // multiple requests. Required when setting the 
        //                // ExpireTimeSpan option of CookieAuthenticationOptions 
        //                // set with AddCookie. Also required when setting 
        //                // ExpiresUtc.

        //                //IssuedUtc = <DateTimeOffset>,
        //                // The time at which the authentication ticket was issued.

        //                //RedirectUri = <string>
        //                // The full path or absolute URI to be used as an http 
        //                // redirect response value.
        //            };

        //            await HttpContext.SignInAsync(
        //                CookieAuthenticationDefaults.AuthenticationScheme,
        //                new ClaimsPrincipal(claimsIdentity),
        //                authProperties);
        //            if (userLog.Role == "Admin")
        //            {
        //                return RedirectToAction("Index", "Users");
        //            }
        //            else
        //            {
        //                return Redirect("http://www.badgerbadgerbadger.com/");
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("Error", "Invalid Email or Password.");
        //            return View(user);
        //        }
        //    }
        //    catch
        //    {
        //        ModelState.AddModelError("Error", "Invalid Email or Password.");
        //        return View(user);
        //    }

        //    //return RedirectToAction("Index", "Users");
        //}

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{

        //    await HttpContext.SignOutAsync(
        //        CookieAuthenticationDefaults.AuthenticationScheme);

        //    return RedirectToAction(nameof(Login));
        //}
    }
}