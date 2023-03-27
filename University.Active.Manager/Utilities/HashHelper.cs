using System;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Options;

namespace University.Active.Manager.Utilities;

public class HashHelper
{
    private readonly HashOptions _hashOptions;
    public HashHelper(IOptionsMonitor<HashOptions> hashOptionsMonitor)
    {
        _hashOptions = hashOptionsMonitor.CurrentValue;
    }

    public string GetHashPassword(string password)
    {
        return  Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: Encoding.UTF8.GetBytes(_hashOptions.Salt),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
    }
}