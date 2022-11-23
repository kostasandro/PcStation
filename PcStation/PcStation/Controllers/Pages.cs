using Microsoft.AspNetCore.Mvc;

namespace PcStation.Controllers
{
    public class Pages : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult neaRefPc()
        {
            return View();
        }

    
    }
}
