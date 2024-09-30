namespace Favorites.Domain;

public class Favorite
{
    public int Id { get; set; }
    public string Name { get; set; }
    public required Category Category { get; set; }

    public Favorite()
    {

    }

    public Favorite(string name)
    {
        Name = name;
    }
}