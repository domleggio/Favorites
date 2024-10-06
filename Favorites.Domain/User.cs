using Microsoft.AspNetCore.Identity;

namespace Favorites.Domain;

public class User : IdentityUser
{
    public List<Favorite>? Favorite {  get; set; }
}
