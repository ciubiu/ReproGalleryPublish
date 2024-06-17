namespace ReproGallery.Models;

public interface IGalleryCart
{
    List<GalleryCartItem> GalleryCartItems { get; set; }

    List<GalleryCartItem> GetGalleryCartItems();

    decimal GetGalleryCartTotal();

    void AddToCart(Repro repro);

    int RemoveFromCart(Repro repro);

    void ClearCart();
}
