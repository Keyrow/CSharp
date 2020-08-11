using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs_N_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_N_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Chefs()
        {
            List<Chefs> vMod = dbContext.chefs.Include(i => i.CreatedDishes).ToList();
            return View(vMod);
        }
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            // DishViewModel vMod = new DishViewModel();
            // vMod.allChefs = dbContext.chefs.ToList();
            List<Dishes> vMod = dbContext.dishes
                // Including OTM "dish" is made up
                .Include(dish => dish.Creator)
                .ToList();
            return View(vMod);
        }
        [HttpGet("new")]
        public IActionResult AddChef()
        {
            return View();
        }
        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            DishViewModel vMod = new DishViewModel();
            vMod.allChefs = dbContext.chefs.ToList();
            return View("AddDish", vMod);
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ POST Route ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost("addingchef")]
        public IActionResult AddChef_Function(Chefs chef)
        {
            if (ModelState.IsValid)
            {
                Chefs newChef = new Chefs
                {
                    Chef_FirstName = chef.Chef_FirstName,
                    Chef_LastName = chef.Chef_LastName,
                    Chef_Age = chef.Chef_Age,
                };
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                System.Console.WriteLine(newChef);
                return RedirectToAction("Chefs");
            }
            else
            {
                return View("AddChef");
            }
        }
        [HttpPost("addingdish")]
        public IActionResult AddDish_Function(DishViewModel VM)
        {
            if (ModelState.IsValid)
            {
                // Dishes newDish = new Dishes
                // {
                //     Food_Name = VM.dish.Food_Name,
                //     Calories = VM.dish.Calories,
                //     Tastiness = VM.dish.Tastiness,
                //     Creator = VM.dish.Creator,
                //     Description = VM.dish.Description,
                // };
                dbContext.dishes.Add(VM.dish);
                dbContext.SaveChanges();
                System.Console.WriteLine(VM.dish);
                return RedirectToAction("Dishes");
            }
            else
            {
                DishViewModel vMod = new DishViewModel();
                vMod.allChefs = dbContext.chefs.ToList();
                return View("AddDish", vMod);
            }
        }
    }
}
