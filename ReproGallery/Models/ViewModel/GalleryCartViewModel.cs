namespace ReproGallery.Models;

public class GalleryCartViewModel
{
    public IGalleryCart Cart { get; }
    public decimal CartTotal { get; }

    public GalleryCartViewModel(IGalleryCart cart, decimal cartTotal)
    {
        Cart = cart;
        CartTotal = cartTotal;
    }
}
