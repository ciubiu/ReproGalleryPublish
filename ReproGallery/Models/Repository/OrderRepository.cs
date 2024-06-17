namespace ReproGallery.Models;

public class OrderRepository : IOrderRepository
{
    private readonly ReproGalleryContext context;
    private readonly IGalleryCart galleryCart;

    public OrderRepository(ReproGalleryContext _context, IGalleryCart _galleryCart)
    {
        galleryCart = _galleryCart;
        context = _context;
    }

    public void CreateOrder(Order order)
    {
        List<GalleryCartItem> galleryCartItems = galleryCart.GalleryCartItems;

        order.OrderDate = DateTime.Now;
        order.OrderTotal = galleryCart.GetGalleryCartTotal();
        order.OrderDetails = new List<OrderDetail>();


        foreach (GalleryCartItem? item in galleryCartItems)
        {
            var orderDetail = new OrderDetail
            {
                ReproId = item.Repro.ReproId,
                Quantity = item.Quantity,
                Price = item.Repro.Price,
                Repro = context.Repros.FirstOrDefault(r => r.ReproId == item.Repro.ReproId)
            };

            order.OrderDetails.Add(orderDetail);
        }

        context.Orders.Add(order);
        context.SaveChanges();
    }
}
