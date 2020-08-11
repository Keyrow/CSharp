using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegister.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginRegister.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ GET ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ POST ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost("register")]
        public IActionResult CreateUser(Register newRegister)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.RegisterEmail == newRegister.RegisterEmail))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("RegisterEmail", "Email already in use!");
                    // You may consider returning to the View at this point
                    return View("Index");
                }
                // Initializing a PasswordHasher object, providing our User class as its type
                PasswordHasher<Register> Hasher = new PasswordHasher<Register>();
                newRegister.RegisterPassword = Hasher.HashPassword(newRegister, newRegister.RegisterPassword);
                // Add new user to database
                dbContext.Add(newRegister);
                //Save your user object to the database
                dbContext.SaveChanges();
                return RedirectToAction("Success");
            }
            return View();
        }
        [HttpPost("login")]
        public IActionResult LogUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault(u => u.RegisterEmail == newUser.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                return RedirectToAction("Success");
            }
            return View("Index");
        }
    }
}


