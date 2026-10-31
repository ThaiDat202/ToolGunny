using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GunTools
{
    public class CryptoHelper
    {
        public static RSACryptoServiceProvider GetRSACrypto(string privateKey)
        {
            RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters
            {
                Flags = CspProviderFlags.UseMachineKeyStore
            });
            rSACryptoServiceProvider.FromXmlString(privateKey);
            return rSACryptoServiceProvider;
        }

        public static string RsaDecrypt(string privateKey, string src)
        {
            RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters
            {
                Flags = CspProviderFlags.UseMachineKeyStore
            });
            rSACryptoServiceProvider.FromXmlString(privateKey);
            return RsaDecrypt(rSACryptoServiceProvider, src);
        }

        public static string RsaDecrypt(RSACryptoServiceProvider rsa, string src)
        {
            byte[] rgb = Convert.FromBase64String(src);
            return Encoding.UTF8.GetString(rsa.Decrypt(rgb, fOAEP: false));
        }

        public static byte[] StringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] array = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return array;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
            for (int i = 0; i < ba.Length; i++)
            {
                stringBuilder.Append(ba[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public static byte[] RsaDecryt2(RSACryptoServiceProvider rsa, string src)
        {
            byte[] buffer = Convert.FromBase64String(src);
            int num = rsa.KeySize / 8;
            byte[] array = new byte[num];
            MemoryStream memoryStream = new MemoryStream(buffer);
            MemoryStream memoryStream2 = new MemoryStream();
            for (int num2 = memoryStream.Read(array, 0, num); num2 > 0; num2 = memoryStream.Read(array, 0, num))
            {
                byte[] array2 = new byte[num2];
                Array.Copy(array, 0, array2, 0, num2);
                byte[] array3 = rsa.Decrypt(array2, fOAEP: false);
                memoryStream2.Write(array3, 0, array3.Length);
            }
            memoryStream.Close();
            byte[] result = memoryStream2.ToArray();
            memoryStream2.Close();
            rsa.Clear();
            return result;
        }

        public static byte[] RsaDecryt3(RSACryptoServiceProvider rsa, string src)
        {
            byte[] rgb = Convert.FromBase64String(src);
            return rsa.Decrypt(rgb, fOAEP: false);
        }

        public static string TripleDesDecrypt(string privateKey, string iv, string cypherText)
        {
            byte[] key = StringToByteArray(privateKey);
            byte[] array = StringToByteArray(cypherText);
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros,
                IV = StringToByteArray(iv)
            };
            return Encoding.UTF8.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length)).Replace('\0', ' ').Trim();
        }

        public static string TripleDesEncrypt(string privateKey, string plainText, ref string iv)
        {
            byte[] key = StringToByteArray(privateKey);
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
            {
                Key = key,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros
            };
            if (iv != null && iv.Length == 16)
            {
                tripleDESCryptoServiceProvider.IV = StringToByteArray(iv);
            }
            string result = ByteArrayToString(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
            if (iv == null)
            {
                return result;
            }
            iv = ByteArrayToString(tripleDESCryptoServiceProvider.IV);
            return result;
        }
    }
}
