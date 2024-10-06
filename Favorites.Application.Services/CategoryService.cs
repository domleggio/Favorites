using CSharpFunctionalExtensions;
using Favorites.Application.Services.dto;
using Favorites.Domain;
using Favorites.Services;
namespace Favorites.Application.Services;

public class CategoryService (ICategoryRepository categoryRepository) : ICategoryService
{
    public async Task<Result> AddCategoryAsync(CategoryDto dto)
    {
        try
        {
            var category = new Category(dto.Name);
            await categoryRepository.AddCategoryAsync(category);
            return Result.Success(category);
        }
        catch (Exception)
        {
            return Result.Failure("Could not add category");
        }

    }

    public async Task<Result<IReadOnlyList<Category>>> GetCategoriesAsync()
    {
        try
        {
            var categories = await categoryRepository.GetCategoriesAsync();
            return Result.Success(categories);
        }
        catch (Exception)
        {
            return Result.Failure<IReadOnlyList<Category>>("Could not get Categories");
        }

    }
}
