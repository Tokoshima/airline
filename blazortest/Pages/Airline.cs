using Microsoft.AspNetCore.Mvc;

namespace blazortest.Pages
{
    public class Airline : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}