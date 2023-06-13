namespace SelfCompany.Eshop.Domain.Cart;

public class CartItem
{
    protected CartItem(Item.Item item, decimal count)
    {
        Count = count;
        Item = item;
    }
    
    public decimal Count { get; protected set; }
    
    public Item.Item Item { get; protected set; }

    public static CartItem Create(Item.Item item, decimal count)
    {
        return new CartItem(item, count);
    }
}