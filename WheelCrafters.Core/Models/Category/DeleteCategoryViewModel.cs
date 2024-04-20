using System.ComponentModel.DataAnnotations;

namespace WheelCrafters.Core.Models.Category
{
    public class DeleteCategoryViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        public IEnumerable<Infrastructure.Data.Models.Category> Categories { get; set; } = new List<Infrastructure.Data.Models.Category>();
    }
}
