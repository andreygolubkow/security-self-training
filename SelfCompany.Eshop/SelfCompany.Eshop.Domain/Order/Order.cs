namespace SelfCompany.Eshop.Domain.Order;

public class Order
{
    private readonly IReadOnlyList<OrderItem> _items;
    
    
    public Guid Id { get; protected set; }

    public IReadOnlyList<OrderItem> Items => _items;

    public User.User Owner { get; protected set; }
}