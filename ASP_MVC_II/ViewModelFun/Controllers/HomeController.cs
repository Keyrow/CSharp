using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {   
        // localhost:5000
        [HttpGet("")]
        public IActionResult Home()
        {
            MyModels Message = new MyModels();
            
            Message.Message = "Blah, Blah, Blah, Message goes here";
            
            return View(Message);
        }
        // localhost:5000/numbers
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            MyModels MyNumbers = new MyModels();
            MyNumbers.Numbers.Add(1);
            MyNumbers.Numbers.Add(2);
            MyNumbers.Numbers.Add(3);
            MyNumbers.Numbers.Add(4);

            return View(MyNumbers);
        }
        // localhost:5000/users
        [HttpGet("users")]
        public IActionResult Users()
        {
            MyModels MyUsers = new MyModels();
            MyUsers.Users.Add("Song");
            MyUsers.Users.Add("Denys");
            MyUsers.Users.Add("Hunter");
            MyUsers.Users.Add("Becky");
            MyUsers.Users.Add("Cote");
            return View(MyUsers);
        }
        // localhost:5000/User
        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            MyModels User = new MyModels();
            
            User.User = "Song";
            return View(User);
        }
    }
}
