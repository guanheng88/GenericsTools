using System;
using System.Security.Cryptography;
using System.Text;

namespace GenericsTools
{
    public class GenericsUtils
    {
        private static long uuidLastTime = 0;
        private static char[] uuidTimeDigits = {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };

        public static string CreateUuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public static string CreateTimeUuid()
        {
            Guid guid = Guid.NewGuid();
            string id = guid.ToString().Replace("-", "");
            long curremtMillis = CurrentTimeMillis();
            if (uuidLastTime >= curremtMillis)
            {
                uuidLastTime = uuidLastTime + 1;
            }
            else
            {
                uuidLastTime = curremtMillis;
            }
            curremtMillis = uuidLastTime;

            for (int m = 0; m < 8; m++)
            {
                int k = (int)(curremtMillis % uuidTimeDigits.Length);
                curremtMillis = (curremtMillis - k) / uuidTimeDigits.Length;
                id = uuidTimeDigits[k] + id;
            }

            return id;
        }

        public static string Md5(string source)
        {
            byte[] bytes = Encoding.Default.GetBytes(source);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(bytes);
            string result = BitConverter.ToString(output).Replace("-", "");
            return result;
        }

        public static long CurrentTimeMillis()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds);
        }
    }
}
