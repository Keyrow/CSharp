using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormSubmission.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User response)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }

            return View();
        }
    }
}