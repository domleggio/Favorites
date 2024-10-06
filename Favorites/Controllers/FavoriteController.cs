using Favorites.Application.Services;
using Favorites.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Favorites.Controllers;

[ApiController]
[Route("[controller]")]
public class FavoriteController(ILogger<FavoriteController> logger, IFavoritesService favorites) : ControllerBase
{

    private readonly ILogger<FavoriteController> _logger = logger;
    private readonly IFavoritesService _favoritesService = favorites;

    [HttpGet]
    public async Task<IReadOnlyList<Favorite>> GetFavorites()
    {
        var favorites = await _favoritesService.GetFavorites();
        return favorites;
    }
}