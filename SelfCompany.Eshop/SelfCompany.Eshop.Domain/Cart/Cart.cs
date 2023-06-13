namespace SelfCompany.Eshop.Domain.Cart;

public class Cart
{
    private List<Item.Item> _items;

    protected Cart(User.User owner, List<Item.Item> items)
    {
        Owner = owner;
        _items = items;
    }
    
    public User.User Owner { get; protected set; }

    public IReadOnlyList<Item.Item> Items => _items;

    public static Cart Create(User.User owner)
    {
        return new Cart(owner, new List<Item.Item>());
    }
}