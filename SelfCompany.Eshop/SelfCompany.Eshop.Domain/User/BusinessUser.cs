namespace SelfCompany.Eshop.Domain.User;

public class BusinessUser: User
{
    protected BusinessUser(Guid id, string username, string passwordHash, string companyName, string bankIdentifierCode, string bankAccountNumber) 
        : base(id, username, passwordHash)
    {
        CompanyName = companyName;
        BankIdentifierCode = bankIdentifierCode;
        BankAccountNumber = bankAccountNumber;
    }

    public string CompanyName { get; protected set; }
    
    public string BankIdentifierCode { get; protected set; }
    
    public string BankAccountNumber { get; protected set; }

    public BusinessUser Create(string username, string password, string passwordConfirmation, string companyName,
        string bik, string bankAccount, IPasswordHashAlgorithm passwordHashAlgorithm)
    {
        CheckPassword(username, password, passwordConfirmation);

        var hash = passwordHashAlgorithm.Hash(password);
        return new BusinessUser(Guid.NewGuid(), username, hash, companyName, bik, bankAccount);
    }
}