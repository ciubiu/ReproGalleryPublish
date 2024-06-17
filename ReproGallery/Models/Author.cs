namespace ReproGallery.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Repro> Repros { get; set; } = new List<Repro>();

}
