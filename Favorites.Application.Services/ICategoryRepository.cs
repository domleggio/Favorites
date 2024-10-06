using Favorites.Domain;

namespace Favorites.Services;

public interface ICategoryRepository
{
    Task AddCategoryAsync(Category category);
    Task<IReadOnlyList<Category>> GetCategoriesAsync();
}