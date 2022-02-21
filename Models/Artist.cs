namespace ArtAPI.Models
{
  public class Artist
  {
    public Artist(string name, int age, string email, string bio)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Age = age;
      Email = email;
      Bio = bio;
    }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Email { get; set; }
    public string? Bio { get; set; }
  }
}