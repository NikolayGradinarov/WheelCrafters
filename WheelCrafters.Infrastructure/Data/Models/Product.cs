using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WheelCrafters.Infrastructure.Data.Enums;
using static WheelCrafters.Infrastructure.Constants.ValidationConstants.Product;

namespace WheelCrafters.Infrastructure.Data.Models
{
    [Comment("Rims")]
    public class Product
    {
        [Key]
        [Comment("Product Identifier")]
        public int Id { get; set; } 

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Product Description")]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [EnumDataType(typeof(SizeType))]
        [Comment("Rims size")]
        public SizeType Size { get; set; }

        [Required]
        [Column(TypeName ="decimal(18, 2)")]
        [Range(typeof(decimal), PriceMinValue, PriceMaxValue)]
        [Comment("Rims price")]
        public decimal Price { get; set; }

        [Required]
        [Range(MinQuantity, MaxQuantity)]
        [Comment("Rims quantity")]
        public int Quantity { get; set; }

        [Required]
        [Comment("Rims Image")]
        public string ImageUrl { get; set; } = string.Empty;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

        [Required]
        public bool IsAvailable { get; set; } = true;

        public virtual ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; }
            = new List<ShoppingCartProduct>();

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
            = new List<OrderProduct>();
    }
}
