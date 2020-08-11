using Microsoft.AspNetCore.Mvc;
namespace Razor
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult RazorFun()
        {
            // Views/Home/HiThere.cshtml  if not in home, it will check "Shared"
            // Views/Shared/HiThere.cshtml
            return View();
        }

        // // localhost:5000/hello
        // [HttpGet("hello")]
        // public string Hello()
        // {
        //     return "Hi Again!";
        // }
        // localhost:5000/users/???
        // [HttpGet("users/{username}/{location")]
        // public string HelloUser(string username, string location)
        // {
        //     if (location.ToLower() == "Chicago")
        // }
    }
}