using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAppProject.DAL;
using ProniaAppProject.Models;
using ProniaAppProject.ViewModels;

namespace ProniaAppProject.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.OrderBy(s => s.Order).Take(2).ToListAsync(),
                Products = await _context.Products.Include(p => p.ProductImages).ToListAsync(),
                Blogs = await _context.Blogs.ToListAsync(),
                NewProducts = await _context.Products.Include(p => p.ProductImages).OrderByDescending(p => p.CreateAt).Take(4).ToListAsync()
            };

            return View(homeVM);

        }

        public IActionResult PageNotFound()
        {
            return View();
        }

    }
}