using System.Security.Cryptography;

namespace GjkEvent.Models
{
    public static class RandomStringGenerator
    {
        public static string RandomString(int length)
        {
            var randomNumber = new byte[32];
            string refreshToken = "";
            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(randomNumber);
                refreshToken = Convert.ToBase64String(randomNumber);
            }
            return refreshToken;
        }
    }
}
