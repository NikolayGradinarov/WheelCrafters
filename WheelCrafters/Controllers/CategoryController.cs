using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WheelCrafters.Core.Contracts;

namespace WheelCrafters.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        public async Task <IActionResult> All()
        {
            var model = await categoryService.GetAllAsync();
            return View();
        }
    }
}
