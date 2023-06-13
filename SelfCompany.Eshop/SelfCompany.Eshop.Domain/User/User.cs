namespace SelfCompany.Eshop.Domain.User;

public class User
{
    protected User(Guid id, string username, string passwordHash)
    {
        Id = id;
        Username = username;
        PasswordHash = passwordHash;
    }

    public Guid Id { get; protected set; }
    
    public string Username { get; protected set; }
    
    public string PasswordHash { get; protected set; }

    public User Create(string username, string password, string passwordConfirmation, IPasswordHashAlgorithm passwordHashAlgorithm)
    {
        CheckPassword(username, password, passwordConfirmation);

        var hash = passwordHashAlgorithm.Hash(password);
        return new User(Guid.NewGuid(), username, hash);
    }

    protected static void CheckPassword(string username, string password, string passwordConfirmation)
    {
        if (!string.Equals(password, passwordConfirmation))
        {
            throw new ArgumentException($"{nameof(passwordConfirmation)} should be the same of {nameof(password)}");
        }

        if (string.Equals(username, password))
        {
            throw new ArgumentException("You cannot use username as password");
        }
    }
}