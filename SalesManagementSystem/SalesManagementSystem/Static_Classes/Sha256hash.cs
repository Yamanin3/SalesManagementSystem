using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SalesManagementSystem.Static_Classes
{
    public static class Sha256hash
    {
        public static string ToHash(string password)
        {
            SHA256 sha = SHA256.Create();
            sha.Initialize();

            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }
    }
}
