using SelfCompany.Eshop.Domain.Core;

namespace SelfCompany.Eshop.Domain.Catalog;

public interface ICatalogService: IDomainService<Catalog>
{
    IQueryable<Catalog> GetAll();

    Catalog Create();

    void MoveToArchive(Catalog catalog);
}