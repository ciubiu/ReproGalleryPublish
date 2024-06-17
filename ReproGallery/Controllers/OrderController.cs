using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReproGallery.Models;

namespace ReproGallery.Controllers;

[Authorize]
public class OrderController : Controller
{
    private readonly IOrderRepository orderRepository;
    private readonly IGalleryCart galleryCart;

    public OrderController(IOrderRepository orderRepository, IGalleryCart galleryCart)
    {
        this.orderRepository = orderRepository;
        this.galleryCart = galleryCart;
    }

    public IActionResult Checkout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Checkout(Order order)
    {
        var items = galleryCart.GetGalleryCartItems();
        galleryCart.GalleryCartItems = items;

        if (galleryCart.GalleryCartItems.Count == 0)
        {
            ModelState.AddModelError("", "Your cart is still empty");
        }

        if(ModelState.IsValid)
        {
            orderRepository.CreateOrder(order);
            galleryCart.ClearCart();
            return RedirectToAction("CheckoutComplete");
        }

        return View(order);
    }

    public IActionResult CheckoutComplete()
    {

        ViewBag.CheckoutCompleteMessage = "Thank you for your order. You will soon receive your order.";
        return View();
    }

    public IActionResult Index()
    {
        return Content("404 page - Order");

    }
}
