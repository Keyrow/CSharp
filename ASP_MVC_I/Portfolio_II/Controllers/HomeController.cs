using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult Home()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}