using Microsoft.AspNetCore.Mvc;

namespace etude_aspNet.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
