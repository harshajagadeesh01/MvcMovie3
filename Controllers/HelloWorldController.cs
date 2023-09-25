using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{ 

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
   /* public string Index()
    {
        return "This is my default action...";
    }*/

        //Here is part 3, adding a view by replacing the default index method above
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Deposit to: " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }
}