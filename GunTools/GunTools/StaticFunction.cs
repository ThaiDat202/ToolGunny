using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using zlib;

namespace GunTools
{
    public class StaticFunction
    {
        public static RSACryptoServiceProvider RsaCryptor => CryptoHelper.GetRSACrypto(ConfigurationManager.AppSettings["privateKey"]);

        public static byte[] Compress(string str)
        {
            return Compress(Encoding.UTF8.GetBytes(str));
        }

        public static byte[] Compress(byte[] src)
        {
            return Compress(src, 0, src.Length);
        }

        public static byte[] Compress(byte[] src, int offset, int length)
        {
            MemoryStream memoryStream = new MemoryStream();
            ZOutputStream zoutputStream = new ZOutputStream(memoryStream, 9);
            zoutputStream.Write(src, offset, length);
            zoutputStream.Close();
            return memoryStream.ToArray();
        }

        public static string Uncompress(string str)
        {
            return Encoding.UTF8.GetString(Uncompress(Encoding.UTF8.GetBytes(str)));
        }

        public static byte[] Uncompress(byte[] src)
        {
            MemoryStream memoryStream = new MemoryStream();
            ZOutputStream zoutputStream = new ZOutputStream(memoryStream);
            zoutputStream.Write(src, 0 ,src.Length);
            zoutputStream.Close();
            return memoryStream.ToArray();
        }
    }
}
