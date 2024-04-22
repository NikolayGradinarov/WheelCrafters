using System.ComponentModel.DataAnnotations;
using WheelCrafters.Infrastructure.Data.Enums;
using static WheelCrafters.Infrastructure.Constants.ValidationConstants.Product;

namespace WheelCrafters.Core.Models.Product
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public SizeType Size { get; set; }

        [Required]
        [Range(typeof(decimal), PriceMaxValue, PriceMinValue)]
        public decimal Price { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public bool IsAvailable { get; set; }
    }
}