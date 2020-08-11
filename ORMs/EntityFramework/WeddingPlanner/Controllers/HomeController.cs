using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ GET Routes ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet("")]
        public IActionResult LogReg()
        {
            return View();
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard(int id)
        {
            return View();
        }

        //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ POST Routes ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        public IActionResult LogReg_Register_Function(UserVM logreg)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.user.Any(u => u.Email == logreg.user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("LogReg");
                }
                // Initializing a PasswordHasher object, providing our User class as its type
                PasswordHasher<Register> Hasher = new PasswordHasher<Register>();
                logreg.user.Password = Hasher.HashPassword(logreg.user, logreg.user.Password);
                // Add new user to database
                dbContext.Add(logreg.user);
                //Save your user object to the database
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserID", logreg.user.UserID);
                return RedirectToAction("Dashboard");
            }
            return View("LogReg");
        }

        public IActionResult LogReg_Login_Function(UserVM logreg)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.user.FirstOrDefault(u => u.Email == logreg.login.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("login.LoginEmail", "Invalid Email/Password");
                    return View("LogReg");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<Login>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(logreg.login, userInDb.Password, logreg.login.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("login.LoginEmail", "Invalid Email/Password");
                    return View("LogReg");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserID);
                return RedirectToAction("Dashboard");
            }
            return View("LogReg");
        }
    }
}

