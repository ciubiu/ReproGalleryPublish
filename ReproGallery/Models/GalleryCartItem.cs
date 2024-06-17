namespace ReproGallery.Models;

public class GalleryCartItem
{
    public int GalleryCartItemId { get; set; }
    public Repro Repro { get; set; } = default!;
    public int Quantity { get; set; }
    public string? GalleryCartId { get; set; }

}
