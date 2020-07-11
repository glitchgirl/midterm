
using Microsoft.AspNetCore.Mvc;


namespace Smtih_Midterm.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
