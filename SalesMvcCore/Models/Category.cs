using System.ComponentModel.DataAnnotations;

namespace SalesMvcCore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
