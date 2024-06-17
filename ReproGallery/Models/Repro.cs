namespace ReproGallery.Models;

public class Repro
{
    public int ReproId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; } = default!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;

}
