using FinalExams.DAL;
using FinalExams.Models;
using FinalExams.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace FinalExams.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<CustomServices> customServices = _context.CustomServices.ToList();

            HomeVM homeVM = new HomeVM
            {

                customServices = customServices

            };

            return View(homeVM);
        }


    }
}
﻿