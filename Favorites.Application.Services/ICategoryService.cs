using CSharpFunctionalExtensions;
using Favorites.Application.Services.dto;
using Favorites.Domain;

namespace Favorites.Application.Services
{
    public interface ICategoryService
    {
        Task<Result> AddCategoryAsync(CategoryDto dto);
        Task<Result<IReadOnlyList<Category>>> GetCategoriesAsync();
    }
}