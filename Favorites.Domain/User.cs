namespace Favorites.Domain;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email {  get; set; }
    public User()
    {
    }
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
