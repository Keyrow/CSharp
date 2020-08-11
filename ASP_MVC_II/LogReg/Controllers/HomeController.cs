using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;

namespace LogReg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult CreateUser(Register newRegister)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("login")]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}


