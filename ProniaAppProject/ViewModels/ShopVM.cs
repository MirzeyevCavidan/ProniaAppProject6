using ProniaAppProject.Models;

namespace ProniaAppProject.ViewModels
{
    public class ShopVM
    {
        public Product? Product { get; set; }
        public List<Product>? RelatedProducts { get; set; }
    }
}
