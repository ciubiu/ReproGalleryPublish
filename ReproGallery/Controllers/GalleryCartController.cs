using Microsoft.AspNetCore.Mvc;
using ReproGallery.Models;

namespace ReproGallery.Controllers;

public class GalleryCartController : Controller
{
    private readonly IReproRepository reproRepository;
    private readonly IGalleryCart galleryCart;

    public GalleryCartController(IReproRepository _reproRepository, IGalleryCart _galleryCart)
    {
        reproRepository = _reproRepository;
        galleryCart = _galleryCart;
    }

    public IActionResult Index()
    {
        var items = galleryCart.GetGalleryCartItems();
        galleryCart.GalleryCartItems = items;
        var cartVM = new GalleryCartViewModel(galleryCart, galleryCart.GetGalleryCartTotal());
        
        return View(cartVM);
    }

    public RedirectToActionResult AddToCart(int id)
    {
        var repro = reproRepository.AllRepros.FirstOrDefault(r => r.ReproId == id);

        if (repro != null)
        {
            galleryCart.AddToCart(repro);
        }

        return RedirectToAction("Index");
    }

    public RedirectToActionResult RemoveFromCart(int id)
    {
        var repro = reproRepository.AllRepros.FirstOrDefault(r => r.ReproId == id);

        if (repro != null)
        {
            galleryCart.RemoveFromCart(repro);
        }

        return RedirectToAction("Index");
    }
}
