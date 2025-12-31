using ProniaAppProject.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaAppProject.Models
{
    public class ProductImage : BaseEntity
    {
        public string ImagePath { get; set; }
        public bool IsPrimary { get; set; }
        public int? ProductId { get; set; }

        public Product Product { get; set; }

    }
}
