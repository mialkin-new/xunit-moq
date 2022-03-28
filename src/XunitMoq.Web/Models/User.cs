namespace XunitMoq.Web.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public DateTime CreatedAtUtc { get; set; }

    public User(int id, string firstName, DateTime createdAtUtc)
    {
        Id = id;
        FirstName = firstName;
        CreatedAtUtc = createdAtUtc;
    }
}