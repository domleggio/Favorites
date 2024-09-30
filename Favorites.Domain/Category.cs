namespace Favorites.Domain;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }
}
