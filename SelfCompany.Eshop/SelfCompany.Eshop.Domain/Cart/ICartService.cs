using SelfCompany.Eshop.Domain.Core;

namespace SelfCompany.Eshop.Domain.Cart;

public interface ICartService: IDomainService<Cart>
{
    Cart CreateCartForUserIfNotExists(User.User user);

    void AddItem(User.User user, Item.Item item, decimal count);

    void RemoveItem(User.User user, CartItem item, decimal count);

    void ChangeCount(User.User user, CartItem item, decimal count);
}