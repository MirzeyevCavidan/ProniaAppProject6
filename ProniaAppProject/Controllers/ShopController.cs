using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAppProject.DAL;
using ProniaAppProject.Models;
using ProniaAppProject.ViewModels;

namespace ProniaAppProject.Controllers
{
    public class ShopController : Controller
    {
       
        
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Detail(int? id)
        {

            if (id == null || id < 1)
            {
                return BadRequest();
            }

            Product? product = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }



            List<Product> relatedProducts = _context.Products.Include(p => p.ProductImages).Include(p => p.Category).Where(p => p.CategoryId == product.CategoryId && p.Id != id).ToList();

            ShopVM shopVM = new ShopVM
            {
                Product = product,
                RelatedProducts = relatedProducts
            };
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleDetail()
        {
            return View();
        }

        public IActionResult WishList()
        {
            return View();
        }
    
    }
}
