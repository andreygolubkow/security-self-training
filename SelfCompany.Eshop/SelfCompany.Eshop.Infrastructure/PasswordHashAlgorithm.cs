using System.Security.Cryptography;
using SelfCompany.Eshop.Domain.User;

namespace SelfCompany.Eshop.Infrastructure;

public class PasswordHashAlgorithm: IPasswordHashAlgorithm
{
    public string Hash(string password)
    {
        using var md5 = MD5.Create();
        {
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            var hashBytes = md5.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes);
        }
    }

    public bool Validate(string password, string hash)
    {
        return hash.Equals(Hash(password));
    }
}