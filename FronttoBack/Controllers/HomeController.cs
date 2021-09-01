using FronttoBack.DAL;
using FronttoBack.Views.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Controllers
{
    public class HomeController : Controller
    {
       

        public AppDBContext _context { get; }
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            ViewModels viewmodels = new ViewModels
            {
                Introductions = await _context.Introductions.ToListAsync(),
                Slides = await _context.Slides.ToListAsync(),
                Catagories = await _context.Catagories.Where(c => c.IsDeleted == false).ToListAsync(),
                Products=await _context.Products.Where(p=>p.IsDeleted==false).Include(p=>p.Images).Include(p=>p.Catagory).OrderByDescending(p=>p.Id).Take(8).ToListAsync()
            };
            return View(viewmodels);
        }
    }
}
