using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Text;
using StudioVitoriaCambui.Converters;

namespace StudioVitoriaCambui.ValueObjects
{
    [JsonConverter(typeof(PasswordConverter))]
    public class Password
    {
        [JsonIgnore] 
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