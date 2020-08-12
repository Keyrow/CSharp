using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ GET ROUTES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpGet]
        [Route("dashboard")]
        public IActionResult Dashboard()
        {
            // if user is not logged in and tries to go to this route then redirect back to home
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "User");
            }
            // include a view model that allows all the models to display on one page
            DashboardModel view = new DashboardModel()
            {
                Users = new User(),
                Hobbies = new Hobby(),
            };
            int? user_id = HttpContext.Session.GetInt32("id");
            User curruser = _context.Users.Where(u => u.Id == user_id).SingleOrDefault();
            List<Hobby> allHobbies = _context.Hobbies.Include(w => w.Enthusiasts).ToList();                  
            // store lists and user in viewbag to display on page
            ViewBag.UserId = user_id;
            ViewBag.User = curruser;
            ViewBag.Hobbies = allHobbies;
            return View(view);
        }
        [HttpGet]
        [Route("NewHobby")]
        public IActionResult NewHobby()
        {
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        [HttpGet]
        [Route("Hobby/{HobbyId}")]
        public IActionResult Hobby(int HobbyId)
        {
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "User");
            }
            // include guests lists and then inclide invited user within the guests list
            Hobby hobby = _context.Hobbies
                            .Include(w => w.Enthusiasts)
                            .ThenInclude(g => g.JoinedUser)
                            .SingleOrDefault(w => w.Id == HobbyId);
            // // store current wedding and all the guests in viewbag to display on page
            ViewBag.CurrentHobby = hobby;
            ViewBag.Description = hobby.Description;
            ViewBag.HobbyEnthusiasts = hobby.Enthusiasts;
            return View();
        }

        [HttpPost]
        [Route("addhobby/{HobbyId}")]
        public IActionResult AddToHobbies(int HobbyId)
        {
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "User");
            }
            int? user_id = HttpContext.Session.GetInt32("id");
            User curruser = _context.Users.Where(u => u.Id == user_id).SingleOrDefault();
            Hobby hobby = _context.Hobbies
                            .Include(w => w.Enthusiasts)
                            .ThenInclude(g => g.JoinedUser)
                            .SingleOrDefault(h => h.Id == HobbyId);
            Join newJoin = new Join
            {
                UserId = curruser.Id,
                JoinedUser = curruser,
                HobbyId = hobby.Id,
                Hobby = hobby
            };
            hobby.Enthusiasts.Add(newJoin);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ POST ROUTES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        [HttpPost]
        [Route("CreateHobby")]
        public IActionResult CreateHobby(NewHobby hobby)
        {
            if (HttpContext.Session.GetInt32("id") == null)
            {
                return RedirectToAction("Index", "User");
            }
            int? user_id = HttpContext.Session.GetInt32("id");
            if (ModelState.IsValid)
            {
                Hobby NewHobby = new Hobby
                {
                    Name = hobby.Name,
                    Description = hobby.Description,
                    Created_At = DateTime.Now,
                    Updated_At = DateTime.Now,
                };
                _context.Add(NewHobby);
                _context.SaveChanges();
                return RedirectToAction("Dashboard", "Home");
            }
            return View("NewHobby");
        }
    }
}

