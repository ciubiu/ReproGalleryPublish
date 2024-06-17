namespace ReproGallery.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Repro> Repros { get; set; } = new List<Repro>();
}
