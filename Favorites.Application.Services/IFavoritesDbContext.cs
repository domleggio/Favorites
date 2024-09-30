using Favorites.Domain;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Application.Services;

public interface IFavoritesDbContext
{
    DbSet<User> User { get; }
    DbSet<Favorite> Favorite { get; }
    DbSet<Category> Category { get; }
}
