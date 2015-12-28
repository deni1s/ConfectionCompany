using System.Security.Cryptography;
using System.Text;

namespace СonfectioneryСompany
{
    public class Sha1Util
    {
        public static string Sha1HashStringForUtf8String(string s)//получить хэш sha1 от строки
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        private static string HexStringFromBytes(byte[] bytes)//получить hex строку из байтов
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
}