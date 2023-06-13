using SelfCompany.Eshop.Domain.User;

namespace SelfCompany.Eshop.Domain.Item;

public class Item
{
    protected Item(Guid id, string title, decimal price, decimal count, BusinessUser owner)
    {
        Id = id;
        Title = title;
        Price = price;
        InStockCount = count;
        Owner = owner;
    }

    public Guid Id { get; protected set; }
    
    public string Title { get; protected set; }
    
    public decimal Price { get; protected set; }
    
    public decimal InStockCount { get; protected set; }
    
    public virtual BusinessUser Owner { get; protected set; }

    public Item Create(string title, decimal price, BusinessUser owner)
    {
        return new Item(Guid.NewGuid(), title, price, 0, owner);
    }
}