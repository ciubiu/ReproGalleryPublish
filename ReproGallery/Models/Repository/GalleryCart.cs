using Microsoft.EntityFrameworkCore;

namespace ReproGallery.Models;

public class GalleryCart : IGalleryCart
{
    private readonly ReproGalleryContext context;

    public string? GalleryCartId { get; set; }

    private GalleryCart(ReproGalleryContext _context)
    {
        context = _context;
    }

    public List<GalleryCartItem> GalleryCartItems { get; set; } = default!;


    // Static Method
    //
    public static GalleryCart GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

        ReproGalleryContext ctx = services.GetService<ReproGalleryContext>() ?? throw new Exception("Error initializing");

        string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

        session?.SetString("CartId", cartId);

        return new GalleryCart(ctx) { GalleryCartId = cartId };
    }


    // Interface Methods
    //
    public List<GalleryCartItem> GetGalleryCartItems()
    {
        return GalleryCartItems ??= context.GalleryCartItems
                        .Where(c => c.GalleryCartId == GalleryCartId)
                        .Include(r => r.Repro)
                        .ToList();


    }


    public void AddToCart(Repro repro)
    {
        var galleryCartItem = context.GalleryCartItems
            .SingleOrDefault(c => c.Repro.ReproId == repro.ReproId && c.GalleryCartId == GalleryCartId);

        if (galleryCartItem == null)
        {
            galleryCartItem = new GalleryCartItem
            {
                GalleryCartId = GalleryCartId,
                Repro = repro,
                Quantity = 1
            };

            context.GalleryCartItems.Add(galleryCartItem);
        }
        else
        {
            galleryCartItem.Quantity++;
        }
        context.SaveChanges();
    }


    public int RemoveFromCart(Repro repro)
    {
        var galleryCartItem = context.GalleryCartItems
            .SingleOrDefault(c => c.Repro.ReproId == repro.ReproId && c.GalleryCartId == GalleryCartId);

        var localQuantity = 0;

        if (galleryCartItem != null)
        {
            if (galleryCartItem.Quantity > 1)
            {
                galleryCartItem.Quantity--;
                localQuantity = galleryCartItem.Quantity;
            }
            else
            {
                context.GalleryCartItems.Remove(galleryCartItem);
            }
        }
        context.SaveChanges();

        return localQuantity;
    }


    public decimal GetGalleryCartTotal()
    {
        var total = context.GalleryCartItems
                .Where(c => c.GalleryCartId == GalleryCartId)
                .Select(c => c.Repro.Price * c.Quantity).Sum();
        return total;
    }


    public void ClearCart()
    {
        var cartItems = context.GalleryCartItems
                .Where(c => c.GalleryCartId == GalleryCartId);

        context.GalleryCartItems.RemoveRange(cartItems);

        context.SaveChanges();
    }

}
