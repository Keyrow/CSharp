using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        // [Route("")]
        [HttpGet("")] // doing this condenses the above code in one line :D
        public string IndexFromController()
        {
            return "This is my Index!";
        }

        // localhost:5000/projects
        // [Route("projects")]
        [HttpGet("projects")] // doing this condenses the above code in one line :D
        public string Projects()
        {
            return "These are my projects";
        }

        // localhost:5000/projects
        // [Route("projects")]
        [HttpGet("contact")] // doing this condenses the above code in one line :D
        public string Contacts()
        {
            return "This is my Contact!";
        }
        // localhost:5000/username/???
        // [HttpGet("users/{username}/{location}")]
        // public string HelloUser(string username, string location)
        // {
        //     if (location.ToLower() == "codingdojo")
        //         return $"Hello {username} from {location}, Go Ninjas!";
        //     return $"Hello {username} from {location}";
        // }
    }
}








//         public IActionResult Index()
//         {
//             return View();
//         }
//         [HttpGet("projects")]
//         public IActionResult Projects()
//         {
//             return View();
//         }
//         [HttpGet("contact")]
//         public IActionResult Contact()
//         {
//             return View();
//         }