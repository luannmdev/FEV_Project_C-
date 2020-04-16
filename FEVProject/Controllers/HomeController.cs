using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FEVProject.Models;
using FEVProject.Data;

namespace FEVProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FEVContext _context;

        public HomeController(FEVContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel data)
        {            

            if(ModelState.IsValid)
            {
                var user = await _context.Users
                .FirstOrDefaultAsync(m => (m.username == data.username) && (m.password == data.password));
                if (user != null)
                {
                    HttpContext.Session.SetString("id", user.username);
                    HttpContext.Session.SetString("role", user.role + "");
                    return RedirectToAction("Index", "Dashboard", "");
                }
                ModelState.AddModelError("loginfail", "Wrong username or password");
                return View();
            }
            return View();
        }
        [Route("Logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("id");
            HttpContext.Session.Remove("role");
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
