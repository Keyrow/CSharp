using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ GET ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("account/{id}")]
        public IActionResult Account(int id)
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserID");
            AccountWrapper vMod = new AccountWrapper();
            vMod.User = dbContext.Users.FirstOrDefault(u => u.id == id);
            vMod.Transactions = dbContext.Transactions.ToList();
            vMod.FormTransaction = new Transaction();
            // Register user = dbContext.Users.FirstOrDefault(u => u.id == IntVariable);
            return View(vMod);
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ POST ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost("register")]
        public IActionResult Register(Register newRegister)
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
                HttpContext.Session.SetInt32("UserID", newRegister.id);
                return RedirectToAction("Account", new { id = newRegister.id });
            }
            return View("Index");
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
                HttpContext.Session.SetInt32("UserID", userInDb.id);
                return RedirectToAction("Account", new { id = userInDb.id });


            }
            return View("Login");
        }
        //     [HttpPost("transaction")]
        //     // public IActionResult Transaction(float amt)
        //     // {
        //     //     // int? UserId = HttpContext.Session.GetInt32("UserId");
        //     //     // User user = dbContext.Users
        //     //     //                 .Where(u => u.id == UserId).SingleOrDefault();
        //     //     // if (amt < 0 && amt * -1 > user.balance)
        //     //     // {
        //     //     //     TempData["Error"] = "Insufficient Funds";
        //     //     // }
        //     //     // else if (amt == 0)
        //     //     // {
        //     //     //     TempData["Error"] = "Please specify amount to withdraw or deposit";
        //     //     // }
        //     //     // else
        //     //     // {
        //     //     //     Account ac = new Account
        //     //     //     {
        //     //     //         amount = amt,
        //     //     //         User = user,
        //     //     //         created_at = DateTime.Now,
        //     //     //         updated_at = DateTime.Now
        //     //     //     };
        //     //     //     user.balance += amt;
        //     //     //     _context.accounts.Add(ac);
        //     //     //     _context.SaveChanges();
        //     // }
        //         return Redirect($"/account/{UserId}");
        // }
    }
}


