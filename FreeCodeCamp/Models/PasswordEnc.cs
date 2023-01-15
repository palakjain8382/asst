using System.Text;

namespace FreeCodeCamp.Models
{
    public class PasswordEnc
    {
        public static string pwdEncryption(string password)
        {
            return Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}
