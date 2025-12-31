using ProniaAppProject.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace ProniaAppProject.Models
{
    public class Category : BaseEntity
    {
        
        [MaxLength(30, ErrorMessage = "Name cannot be more than 30 character")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }


    }
}