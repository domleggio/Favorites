using Favorites.Domain;

namespace Favorites.Application.Services
{
    public interface IFavoritesService
    {
        Task<IReadOnlyList<Favorite>> GetFavorites();
    }
}