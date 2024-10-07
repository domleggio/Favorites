using Favorites.Application.Services.dto;
using Favorites.Application.Services.interfaces;
using Favorites.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Favorites.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController (ILogger<CategoryController> logger, ICategoryService categoryService) : ControllerBase
{
    private readonly ILogger<CategoryController> _logger = logger;
    private readonly ICategoryService _categoryService = categoryService;

    [HttpPost("Add")]
    public async Task<long> AddCategory(CategoryDto dto)
    {
        var favorites = await _categoryService.AddCategoryAsync(dto);
        return 5;//FIX
    }

    [HttpGet]
    public async Task<IReadOnlyList<Category>> GetCategories()
    {
        var categories = await _categoryService.GetCategoriesAsync();
        if (categories.IsSuccess)
        {
            return categories.Value;
        }
        return [];//FIX
    }


}
    