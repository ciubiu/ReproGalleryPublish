using Microsoft.AspNetCore.Mvc;
using ReproGallery.Models;

namespace ReproGallery.Components;

public class GalleryCartSummary :ViewComponent
{
    private readonly IGalleryCart galleryCart;

    public GalleryCartSummary(IGalleryCart _galleryCart)
    {
        galleryCart = _galleryCart;
    }

    public IViewComponentResult Invoke()
    {
        var items = galleryCart.GetGalleryCartItems();
        galleryCart.GalleryCartItems = items;

        var cartVM = new GalleryCartViewModel(galleryCart, galleryCart.GetGalleryCartTotal());

        return View(cartVM);
    }
}
