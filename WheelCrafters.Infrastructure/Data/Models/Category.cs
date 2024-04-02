using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WheelCrafters.Infrastructure.Constants.ValidationConstants.Category;

namespace WheelCrafters.Infrastructure.Data.Models
{
    [Comment("Rims Category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Category Name")]
        public string Name { get; set; } = string.Empty;

        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
