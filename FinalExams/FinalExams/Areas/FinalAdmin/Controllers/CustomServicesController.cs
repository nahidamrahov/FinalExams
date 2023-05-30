using FinalExams.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FinalExams.Areas.FinalAdmin.Controllers
{
    [Area("FinalAdmin")]
    public class CustomServicesController : Controller
    {
        readonly AppDbContext _context;

        public CustomServicesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.CustomServices.ToList());
        }
    }
}
