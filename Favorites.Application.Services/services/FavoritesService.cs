using Favorites.Application.Services.interfaces;
using Favorites.Domain;
using Microsoft.EntityFrameworkCore;

namespace Favorites.Application.Services.services;

public class FavoritesService(IFavoritesDbContext context) : IFavoritesService
{

    public async Task<IReadOnlyList<Favorite>> GetFavorites()
    {
        var favorites = await context.Favorite.ToListAsync();
        return favorites.AsReadOnly();
    }

}