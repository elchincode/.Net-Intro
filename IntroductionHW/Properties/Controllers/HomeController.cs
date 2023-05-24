using Microsoft.AspNetCore.Mvc;

namespace IntroductionHW.Properties.Controllers
{
    public class HomeController : Controller 
    {
        //public ViewResult Index()
        //{
        //    return View();
        //}

        //public ContentResult Index()
        //{                                            
        //    return Content("P331");
        //}

        public ActionResult Index()   // ActionResult ikisinede miras verdiyine gore hem content hemde View isleyecek
        {
            //ViewBag
            //Viewdata
            //TempData
            ViewBag.Name = "Elcin";
            ViewData["Surname"] = "Ismayilov";
            TempData["Age"] = 18;
            TempData["Country"] = "Azerbaijan";
            TempData["Phone Number"] = 0514915055;
            return View();
            //return RedirectToAction("Test");
        }

        //public ActionResult Test()
        //{
        //    var age = TempData["Age"];
        //    var surname = ViewData["Surname"];

        //    return Ok();
        //}

        //public int Test()
        //{
        //    return 5;
        //}

        //public int Details(int id)
        //{
        //    return id;
        //}

    }
}
