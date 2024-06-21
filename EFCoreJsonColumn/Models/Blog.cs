namespace EFCoreJsonColumn.Models;

public sealed class Blog
{
    public Blog(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Post> Posts { get; } = new();
}
