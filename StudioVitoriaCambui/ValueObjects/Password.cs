using System.Security.Cryptography;
using System.Text;

namespace StudioVitoriaCambui.ValueObjects
{
    public class Password
    {
        public string HashPassword { get; }

        public Password(string plainPassword)
        {
            HashPassword = HashString(plainPassword);
        }

        private static string HashString(string input)
        {
            using (var sha = SHA256.Create())
            {
                var byteArray = Encoding.UTF8.GetBytes(input);
                var hashedPassword = sha.ComputeHash(byteArray);
                return Convert.ToBase64String(hashedPassword);
            }
        }
    }
}