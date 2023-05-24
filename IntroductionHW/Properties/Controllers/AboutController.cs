using Microsoft.AspNetCore.Mvc;

namespace IntroductionHW.Properties.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
