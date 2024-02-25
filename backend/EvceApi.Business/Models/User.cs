namespace EvceApi.Business.Models;

public class User
{
    public int? Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }

    public User()
    {
        
    }

    public User(string? username, string? email)
    {
        Username = username;
        Email = email;
    }
}