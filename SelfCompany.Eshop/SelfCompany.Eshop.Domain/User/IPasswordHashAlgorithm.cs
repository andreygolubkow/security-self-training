namespace SelfCompany.Eshop.Domain.User;

public interface IPasswordHashAlgorithm
{
    string Hash(string password);

    bool Validate(string password, string hash);
}