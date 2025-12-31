using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAppProject.DAL;
using ProniaAppProject.Models;

namespace ProniaAppProject.Areas.Admin.Controllers
{

    [Area("admin")]

    public class SlideController : Controller
    {

        public readonly AppDbContext _context;
        
        public SlideController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            List<Slider> slides = await _context.Sliders.ToListAsync();
            return View(slides);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]


        public async Task<ActionResult> Create(Slider slides)
        {
            if (!ModelState.IsValid)
            {
                return View(slides);
            }

            if (!slides.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Something went wrong about image size");
                return View(slides);
            }

            if (slides.Photo.Length > 2 * 1024 * 1024)
            {
                ModelState.AddModelError("Photo", "Something went wrong about image size");
                return View(slides);
            }
            string fileName = String.Concat(Guid.NewGuid().ToString(), slides.Photo.FileName);

            string path = "C:\\Users\\Cavidan\\source\\repos\\ProniaAppProject\\ProniaAppProject\\wwwroot\\assets\\images\\website-images\\" + fileName;
            FileStream fileStream = new(path, FileMode.Create);
            await slides.Photo.CopyToAsync(fileStream);
            fileStream.Close();
            slides.ImagePath = fileName;

            await _context.Sliders.AddAsync(slides);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}