using ProniaAppProject.Models;

namespace ProniaAppProject.ViewModels
{
    public class HomeVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }
        public List<Product> NewProducts { get; set; }
    }
}