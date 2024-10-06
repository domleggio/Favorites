using Favorites.Application.Services;
using Favorites.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Infrastructure;

public class FavoritesDbContext : IdentityDbContext<User>, IFavoritesDbContext
{ 
    public FavoritesDbContext (DbContextOptions<FavoritesDbContext> options) : base(options) { }

    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<Favorite> Favorite { get; set; }
    public virtual DbSet<Category> Category { get; set; }

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }

}
