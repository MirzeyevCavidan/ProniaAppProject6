using ProniaAppProject.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaAppProject.Models
{
    public class Slider : BaseEntity
    {
        public string? Discount { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string ImagePath { get; set; }
        public int Order { get; set; }

        [NotMapped]
        public IFormFile? Photo{ get; set; }
    }
}
