namespace ReproGallery.Models;

public class OrderDetail
{
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ReproId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public Repro Repro { get; set; } = new Repro();
    public Order Order { get; set; } = new Order();
}