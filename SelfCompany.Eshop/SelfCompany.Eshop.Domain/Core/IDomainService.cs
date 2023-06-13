namespace SelfCompany.Eshop.Domain.Core;

public interface IDomainService<TObject> where TObject:class
{
    public TObject? FindById(Guid id);
}