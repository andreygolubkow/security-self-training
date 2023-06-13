using SelfCompany.Eshop.Domain.Cart;

namespace SelfCompany.Eshop.Domain.Order;

public class OrderItem
{
    protected OrderItem(Guid id, string title, decimal price, decimal count, DateTimeOffset snapshotDate, Item.Item originalItem)
    {
        Id = id;
        Title = title;
        Price = price;
        Count = count;
        SnapshotDate = snapshotDate;
        OriginalItem = originalItem;
    }
    
    public Guid Id { get; protected set; }
    
    public string Title { get; protected set; }
    
    public decimal Price { get; protected set; }
    
    public decimal Count { get; protected set; }
    
    public DateTimeOffset SnapshotDate { get; protected set; }
    
    public Item.Item OriginalItem { get; protected set; }

    public static OrderItem Create(CartItem cartItem)
    {
        return new OrderItem(Guid.NewGuid(), cartItem.Item.Title, cartItem.Item.Price, cartItem.Count,
            DateTimeOffset.Now, cartItem.Item);
    }
}