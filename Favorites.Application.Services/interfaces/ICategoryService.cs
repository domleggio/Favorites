using CSharpFunctionalExtensions;
using Favorites.Application.Services.dto;
using Favorites.Domain;

namespace Favorites.Application.Services.interfaces
{
    public interface ICategoryService
    {
        Task<Result> AddCategoryAsync(CategoryDto dto);
        Task<Result<IReadOnlyList<Category>>> GetCategoriesAsync();
    }
}