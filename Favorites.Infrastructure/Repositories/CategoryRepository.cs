using Favorites.Application.Services.interfaces;
using Favorites.Domain;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Infrastructure.Repositories;

public class CategoryRepository(IFavoritesDbContext context) : ICategoryRepository
{
    public async Task AddCategoryAsync(Category category)
    {
        await context.Category.AddAsync(category);
    }

    public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
    {
        var categories = await context.Category.ToListAsync();
        return categories;
    }
}
