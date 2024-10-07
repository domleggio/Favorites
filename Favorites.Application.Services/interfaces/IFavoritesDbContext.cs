using Favorites.Domain;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Application.Services.interfaces;

public interface IFavoritesDbContext
{
    DbSet<User> User { get; }
    DbSet<Favorite> Favorite { get; }
    DbSet<Category> Category { get; }
    Task<int> SaveChangesAsync();

}
