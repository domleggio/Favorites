using Favorites.Domain;

namespace Favorites.Application.Services.interfaces;

public interface ICategoryRepository
{
    Task AddCategoryAsync(Category category);
    Task<IReadOnlyList<Category>> GetCategoriesAsync();
}