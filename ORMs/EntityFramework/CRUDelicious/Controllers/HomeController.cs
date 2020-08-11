using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ All "GET" goes here ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Home Page ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // lowercase "dishes" matches with "MyContext" "dishes" get;set;
            List<Dishes> AllDishes = dbContext.dishes.ToList();
            ViewBag.allDishes = AllDishes;
            return View();
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Dish Info ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet]
        [Route("{Dish_ID}")]
        public IActionResult DishInfo(int Dish_ID)
        {
            List<Dishes> DishInfo = dbContext.dishes.Where(dish => dish.id == Dish_ID).ToList();
            ViewBag.dishinfo = DishInfo;
            return View("DishInfo");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Create Dish ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet]
        [Route("new")]
        public IActionResult newDish()
        {
            return View("CreateDish");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Edit Dish ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet]
        [Route("edit/{Dish_ID}")]
        public IActionResult EditDish(int dish_id)
        {
            Dishes edited_dish = dbContext.dishes.FirstOrDefault(d => d.id == dish_id);

            return View("EditDish", edited_dish);
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Delete Dish ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        [HttpGet("delete/{dish_id}")]
        public IActionResult delete_dish(Dishes deleted_dish, int dish_id)
        {
            Dishes retrievedDish = dbContext.dishes.FirstOrDefault(dish => dish.id == dish_id);
            dbContext.dishes.Remove(retrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ All "POST" goes here ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Create Dish Function~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost("create")]
        public IActionResult CreateDish_Function(Dishes dish)
        {
            if (ModelState.IsValid)
            {
                Dishes newDish = new Dishes
                {
                    Name = dish.Name,
                    Chef = dish.Chef,
                    Tastiness = dish.Tastiness,
                    Calories = dish.Calories,
                    Description = dish.Description,
                };
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                System.Console.WriteLine(newDish);

                return RedirectToAction("Index");
            }
            else
            {
                return View("CreateDish");
            }
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Edit Dish Function~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost("edit/{dish_id}")]
        public IActionResult EditDish_Function(Dishes edited_dish, int dish_id)
        {
            Dishes retrievedDish = dbContext.dishes.FirstOrDefault(dish => dish.id == dish_id);
            ViewBag.dishinfo = retrievedDish;

            if (ModelState.IsValid)
            {
                retrievedDish.Name = edited_dish.Name;
                retrievedDish.Chef = edited_dish.Chef;
                retrievedDish.Description = edited_dish.Description;
                retrievedDish.Tastiness = edited_dish.Tastiness;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditDish", edited_dish);
            }
        }
    }
}
