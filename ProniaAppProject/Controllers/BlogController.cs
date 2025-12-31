using Microsoft.AspNetCore.Mvc;

namespace ProniaAppProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
