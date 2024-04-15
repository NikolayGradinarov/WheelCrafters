using System.ComponentModel.DataAnnotations;
using static WheelCrafters.Infrastructure.Constants.ValidationConstants.Category;

namespace WheelCrafters.Core.Models.Category
{
    public class CategoryViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = string.Empty;
    }
}
