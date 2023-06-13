namespace SelfCompany.Eshop.Domain.Catalog;

public class Catalog
{
    protected Catalog(Guid id, string title)
    {
        Id = id;
        Title = title;
    }

    public Guid Id { get; protected set; }
    
    public string Title { get; protected set; }
    
    public virtual IList<Item.Item> Items { get; set; } = new List<Item.Item>();
    
    public Catalog Create(string title)
    {
        return new Catalog(Guid.NewGuid(), title);
    }
}