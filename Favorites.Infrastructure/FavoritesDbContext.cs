using Favorites.Domain;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Infrastructure;

public class FavoritesDbContext : DbContext
{ 
    public FavoritesDbContext (DbContextOptions<FavoritesDbContext> options) : base(options) { }

    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<Favorite> Favorite { get; set; }
    public virtual DbSet<Category> Category { get; set; }

}
