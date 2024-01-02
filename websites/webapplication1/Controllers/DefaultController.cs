using Microsoft.AspNetCore.Mvc;

namespace webapplication1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index(int? id, int a=4, int b = 2, int c = 3)
        {
            //if(id == null)
            //     return  NotFound();
            ViewBag.id = id;
            ViewBag.a = a;  
            ViewBag.b = b;
            ViewBag.c = c;
            return View();
        }
        public IActionResult view1()
        {
            return View("Index1");
        }
        public IActionResult view2()
        {
            return View();
        }
        //public IActionResult view1()
        //{
        //    return View();
        //}
        //public IActionResult view1()
        //{
        //    return View();
        //}
        //public IActionResult view1()
        //{
        //    return View();
        //}

    }
}
