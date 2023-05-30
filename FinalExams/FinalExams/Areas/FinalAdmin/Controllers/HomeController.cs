using Microsoft.AspNetCore.Mvc;

namespace FinalExams.Areas.FinalAdmin.Controllers
{
    [Area("FinalAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
