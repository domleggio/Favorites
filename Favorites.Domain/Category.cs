namespace Favorites.Domain;

public class Category(string name)
{
    public int Id { get; set; }
    public string Name { get; init; } = name;
}
