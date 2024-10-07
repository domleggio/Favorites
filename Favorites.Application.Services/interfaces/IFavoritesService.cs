using Favorites.Domain;

namespace Favorites.Application.Services.interfaces
{
    public interface IFavoritesService
    {
        Task<IReadOnlyList<Favorite>> GetFavorites();
    }
}