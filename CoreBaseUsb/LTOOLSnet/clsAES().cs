using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.LTOOLSnet
{
    public sealed class clsAES
    {
            // Token: 0x06000007 RID: 7 RVA: 0x000022AB File Offset: 0x000004AB
            private clsAES()
            {
                Class3.vd4OXo2zYFEgU();
                //base..ctor();
            }

            // Token: 0x17000003 RID: 3
            // (get) Token: 0x06000008 RID: 8 RVA: 0x000034C4 File Offset: 0x000016C4
            public static clsAES Instance
            {
                get
                {
                    return clsAES.clsAES_0;
                }
            }

            // Token: 0x06000009 RID: 9 RVA: 0x000034D8 File Offset: 0x000016D8
            public string Decrypt(string cipheredtext, string key)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(key);
                byte[] buffer = Convert.FromBase64String(cipheredtext);
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Mode = CipherMode.CBC;
                rijndaelManaged.Padding = PaddingMode.None;
                byte[] bytes2 = Encoding.ASCII.GetBytes("myVerySecretIVKe");
                ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
                MemoryStream memoryStream = new MemoryStream(buffer);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
                StreamReader streamReader = new StreamReader(cryptoStream, Encoding.UTF8);
                string s = streamReader.ReadToEnd();
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(Convert.FromBase64String(s));
            }

            // Token: 0x0600000A RID: 10 RVA: 0x00003574 File Offset: 0x00001774
            public string Encrypt(string plaintext, string key)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(key);
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Mode = CipherMode.CBC;
                rijndaelManaged.Padding = PaddingMode.None;
                byte[] bytes2 = Encoding.ASCII.GetBytes("myVerySecretIVKe");
                ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                byte[] bytes3 = Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(plaintext)));
                cryptoStream.Write(bytes3, 0, bytes3.Length);
                cryptoStream.FlushFinalBlock();
                byte[] array = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(array, 0, array.Length);
            }

            // Token: 0x0600000B RID: 11 RVA: 0x000022B8 File Offset: 0x000004B8
            static clsAES()
            {
                Class3.vd4OXo2zYFEgU();
                clsAES.clsAES_0 = new clsAES();
            }

            // Token: 0x0400000A RID: 10
            private static readonly clsAES clsAES_0;
    }
}
