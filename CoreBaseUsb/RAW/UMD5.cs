using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace CoreBaseUsb.RAW
{
    public class UMD5
    {
        public static string RandomString(int numberOfCharacters)
        {
            int length = UMD5.string_0.Length;
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numberOfCharacters; i++)
            {
                stringBuilder.Append(UMD5.string_0.Substring(random.Next(0, length), 1));
            }
            return stringBuilder.ToString();
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00003D24 File Offset: 0x00001F24
        public static string GetMD5(string chuoi)
        {
            string text = "";
            byte[] array = Encoding.UTF8.GetBytes(chuoi);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            array = md5CryptoServiceProvider.ComputeHash(array);
            foreach (byte b in array)
            {
                text += b.ToString("X2");
            }
            return text;
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00003D88 File Offset: 0x00001F88
        public static string smethod_0(string pass)
        {
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(pass);
            array = md5CryptoServiceProvider.ComputeHash(array);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in array)
            {
                stringBuilder.Append(b.ToString("x1").ToLower());
            }
            pass = stringBuilder.ToString();
            return pass;
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00003DF8 File Offset: 0x00001FF8
        public static string smethod_1(string pass)
        {
            SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(pass);
            array = sha1CryptoServiceProvider.ComputeHash(array);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in array)
            {
                stringBuilder.Append(b.ToString("x1").ToLower());
            }
            pass = stringBuilder.ToString();
            return pass;
        }

        // Token: 0x06000024 RID: 36 RVA: 0x00003E68 File Offset: 0x00002068
        public static byte[] smethod_2(string strPassword)
        {
            string @string = Encoding.ASCII.GetString(UMD5.U_STRING);
            byte[] bytes = Encoding.ASCII.GetBytes(@string + strPassword);
            SHA512Managed sha512Managed = new SHA512Managed();
            return sha512Managed.ComputeHash(bytes);
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00003EAC File Offset: 0x000020AC
        public static byte[] ReadFileToByteArray(string fileName)
        {
            byte[] result = null;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    result = binaryReader.ReadBytes((int)fileStream.Length);
                }
                fileStream.Close();
            }
            return result;
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00003F20 File Offset: 0x00002120
        public static int EncryptFile(string fileIn, string fileOut, string Password, bool confirmE)
        {
            int result;
            try
            {
                if (confirmE)
                {
                    FileStream fileStream = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
                    FileStream fileStream2 = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
                    PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, UMD5.U_STRING);
                    Rijndael rijndael = Rijndael.Create();
                    rijndael.Key = passwordDeriveBytes.GetBytes(32);
                    rijndael.IV = passwordDeriveBytes.GetBytes(16);
                    CryptoStream cryptoStream = new CryptoStream(fileStream2, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
                    int count = 4096;
                    byte[] buffer = new byte[4096];
                    int num;
                    do
                    {
                        num = fileStream.Read(buffer, 0, count);
                        cryptoStream.Write(buffer, 0, num);
                    }
                    while (num != 0);
                    cryptoStream.Close();
                    fileStream.Close();
                    fileStream2.Close();
                    result = 1;
                }
                else
                {
                    File.Copy(fileIn, fileOut, true);
                    result = 1;
                }
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        // Token: 0x06000027 RID: 39 RVA: 0x00003FFC File Offset: 0x000021FC
        public static int DecryptFile(string fileIn, string fileOut, string Password, bool confirmE)
        {
            int result;
            try
            {
                if (confirmE)
                {
                    FileStream fileStream = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
                    FileStream fileStream2 = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
                    PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, UMD5.U_STRING);
                    Rijndael rijndael = Rijndael.Create();
                    rijndael.Key = passwordDeriveBytes.GetBytes(32);
                    rijndael.IV = passwordDeriveBytes.GetBytes(16);
                    CryptoStream cryptoStream = new CryptoStream(fileStream2, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
                    int count = 4096;
                    byte[] buffer = new byte[4096];
                    int num;
                    do
                    {
                        num = fileStream.Read(buffer, 0, count);
                        cryptoStream.Write(buffer, 0, num);
                    }
                    while (num != 0);
                    cryptoStream.Close();
                    fileStream.Close();
                    fileStream2.Close();
                    result = 1;
                }
                else
                {
                    File.Copy(fileIn, fileOut, true);
                    result = 1;
                }
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        // Token: 0x06000028 RID: 40 RVA: 0x000040D8 File Offset: 0x000022D8
        public static string AddStringToCryptFile(string sCurentFile)
        {
            int num = 0;
            int startIndex = 0;
            while (sCurentFile.IndexOf('\\', startIndex) != -1)
            {
                num = sCurentFile.IndexOf('\\', startIndex);
                startIndex = num + 1;
            }
            string text = sCurentFile.Substring(num + 1);
            string str = sCurentFile.Substring(0, num + 1);
            text = text.Replace('.', '_');
            return str + text + ".xyz";
        }

        // Token: 0x06000029 RID: 41 RVA: 0x00004140 File Offset: 0x00002340
        public static string GetFileNameFromDecrypt(string strFileToDecrypt)
        {
            int num = 0;
            int startIndex = 0;
            int num2 = 0;
            while (strFileToDecrypt.IndexOf('\\', startIndex) != -1)
            {
                num = strFileToDecrypt.IndexOf('\\', startIndex);
                startIndex = num + 1;
            }
            while (strFileToDecrypt.IndexOf(".", startIndex) != -1)
            {
                num2 = strFileToDecrypt.IndexOf(".", startIndex);
                startIndex = num2 + 1;
            }
            string text = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 4);
            strFileToDecrypt.Substring(num2 + 1, strFileToDecrypt.Length - num2 - 1);
            string str = strFileToDecrypt.Substring(0, num + 1);
            text = text.Substring(num + 1);
            return str + text.Replace('_', '.');
        }

        // Token: 0x0600002A RID: 42 RVA: 0x000041EC File Offset: 0x000023EC
        public static string EncryptName(string toEncrypt, bool useHashing)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            string @string = Encoding.ASCII.GetString(UMD5.U_STRING);
            string s = @string;
            byte[] key;
            if (useHashing)
            {
                MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
                md5CryptoServiceProvider.Clear();
            }
            else
            {
                key = Encoding.UTF8.GetBytes(s);
            }
            TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Key = key;
            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
            tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
            byte[] array = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
            tripleDESCryptoServiceProvider.Clear();
            return Convert.ToBase64String(array, 0, array.Length);
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00004298 File Offset: 0x00002498
        public static string DecryptName(string cipherString, bool useHashing)
        {
            string result;
            try
            {
                byte[] array = Convert.FromBase64String(cipherString);
                string @string = Encoding.ASCII.GetString(UMD5.U_STRING);
                string s = @string;
                byte[] key;
                if (useHashing)
                {
                    MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
                    key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
                    md5CryptoServiceProvider.Clear();
                }
                else
                {
                    key = Encoding.UTF8.GetBytes(s);
                }
                TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
                tripleDESCryptoServiceProvider.Key = key;
                tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
                tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
                byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
                tripleDESCryptoServiceProvider.Clear();
                result = Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00004360 File Offset: 0x00002560
        public static string ConvertStringToHex_old(string input, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(input);
            StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                stringBuilder.AppendFormat("{0:X2}", b);
            }
            return stringBuilder.ToString();
        }

        // Token: 0x0600002D RID: 45 RVA: 0x000043B4 File Offset: 0x000025B4
        public static string ConvertHexToString_Old(string hexInput, Encoding encoding)
        {
            string result;
            try
            {
                int length = hexInput.Length;
                byte[] array = new byte[length / 2];
                for (int i = 0; i < length; i += 2)
                {
                    array[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
                }
                result = encoding.GetString(array);
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x0600002E RID: 46 RVA: 0x00004418 File Offset: 0x00002618
        public static string ConvertToUnSign(string s)
        {
            string text = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(text[i]);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(text[i]);
                }
            }
            stringBuilder = stringBuilder.Replace('Đ', 'D');
            stringBuilder = stringBuilder.Replace('đ', 'd');
            stringBuilder = stringBuilder.Replace('/', '_');
            stringBuilder = stringBuilder.Replace('*', '_');
            stringBuilder = stringBuilder.Replace('@', '_');
            stringBuilder = stringBuilder.Replace('#', '_');
            stringBuilder = stringBuilder.Replace('%', '_');
            stringBuilder = stringBuilder.Replace('$', '_');
            stringBuilder = stringBuilder.Replace('&', '_');
            stringBuilder = stringBuilder.Replace('\\', '_');
            return stringBuilder.ToString().Normalize(NormalizationForm.FormD);
        }

        // Token: 0x0600002F RID: 47 RVA: 0x000044EC File Offset: 0x000026EC
        public static bool IsVietnamFileName(string str1)
        {
            string text = "ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ#$%^*/|&~\\";
            bool result = false;
            for (int i = 0; i <= str1.Length - 1; i++)
            {
                int num = text.IndexOf(str1[i]);
                if (num > 0)
                {
                    result = true;
                    return result;
                }
            }
            return result;
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00004538 File Offset: 0x00002738
        public static string CreateRandom(int size)
        {
            RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] array = new byte[size];
            rngcryptoServiceProvider.GetBytes(array);
            return Convert.ToBase64String(array);
        }

        // Token: 0x06000031 RID: 49 RVA: 0x00004564 File Offset: 0x00002764
        public static string GenerateID()
        {
            DateTime now = DateTime.Now;
            string format = "yyyyMMddhhmmss";
            return now.ToString(format) + UMD5.RandomString(16);
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00004598 File Offset: 0x00002798
        public static string ConvertStringToHex2Byte(string asciiString, Encoding encoding)
        {
            string result;
            try
            {
                string text = "";
                foreach (char c in asciiString)
                {
                    int num = (int)(c * '\u0002' - '\u0001');
                    if (num >= 511)
                    {
                        num = 189;
                    }
                    text += string.Format("{0:X2}", Convert.ToUInt32(num.ToString()));
                }
                result = text;
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x06000033 RID: 51 RVA: 0x00004624 File Offset: 0x00002824
        public static string ConvertHexToString2Byte(string HexString, Encoding encoding)
        {
            string result;
            try
            {
                string text = "";
                for (int i = 0; i < HexString.Length; i += 2)
                {
                    if (HexString.Length >= i + 2)
                    {
                        string value = HexString.Substring(i, 2);
                        text += Convert.ToChar(Convert.ToInt32((Convert.ToInt32(value, 16) / 2 + 1).ToString())).ToString();
                    }
                }
                result = text;
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x06000034 RID: 52 RVA: 0x000046B0 File Offset: 0x000028B0
        public static string ConvertStringToHex(string input, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(input);
            new StringBuilder(bytes.Length * 2);
            string text = "";
            string result;
            if (input.Length == 0)
            {
                result = "";
            }
            else
            {
                int num = bytes.Length;
                for (int i = 0; i < num; i++)
                {
                    if (i % 2 == 0)
                    {
                        text += string.Format("{0:X2}", bytes[i]);
                    }
                    else if (bytes[i] != 0)
                    {
                        text = text + "_" + string.Format("{0:X2}", bytes[i]);
                    }
                }
                result = text;
            }
            return result;
        }

        // Token: 0x06000035 RID: 53 RVA: 0x00004750 File Offset: 0x00002950
        public static string ConvertHexToString(string input, Encoding encoding)
        {
            string text = "";
            string result;
            if (input.Length == 0)
            {
                result = "";
            }
            else
            {
                string text2 = input;
                do
                {
                    if (text2.Substring(0, 1).IndexOf("_") < 0)
                    {
                        text = text + text2.Substring(0, 2) + "00";
                        text2 = text2.Substring(2, text2.Length - 2);
                    }
                    else
                    {
                        text = text.Substring(0, text.Length - 2) + text2.Substring(1, 2);
                        text2 = text2.Substring(3, text2.Length - 3);
                    }
                }
                while (text2.Length >= 2);
                if (text.Length > 0)
                {
                    int length = text.Length;
                    byte[] array = new byte[length / 2];
                    for (int i = 0; i < length; i += 2)
                    {
                        array[i / 2] = Convert.ToByte(text.Substring(i, 2), 16);
                    }
                    result = encoding.GetString(array);
                }
                else
                {
                    result = "---";
                }
            }
            return result;
        }

        // Token: 0x06000036 RID: 54 RVA: 0x00004864 File Offset: 0x00002A64
        public static string GetChecksum(string file)
        {
            string result;
            using (FileStream fileStream = File.OpenRead(file))
            {
                SHA256Managed sha256Managed = new SHA256Managed();
                byte[] value = sha256Managed.ComputeHash(fileStream);
                result = BitConverter.ToString(value).Replace("-", string.Empty);
            }
            return result;
        }

        // Token: 0x06000037 RID: 55 RVA: 0x000048BC File Offset: 0x00002ABC
        public static string GetChecksumBuffered(Stream stream)
        {
            string result;
            using (BufferedStream bufferedStream = new BufferedStream(stream, 32768))
            {
                SHA256Managed sha256Managed = new SHA256Managed();
                byte[] value = sha256Managed.ComputeHash(bufferedStream);
                result = BitConverter.ToString(value).Replace("-", string.Empty);
            }
            return result;
        }

        // Token: 0x06000038 RID: 56 RVA: 0x000022AB File Offset: 0x000004AB
        public UMD5()
        {
            Class3.vd4OXo2zYFEgU();
            base..ctor();
        }

        // Token: 0x06000039 RID: 57 RVA: 0x000022F1 File Offset: 0x000004F1
        static UMD5()
        {
            Class3.vd4OXo2zYFEgU();
            UMD5.U_HEADER = new byte[]
            {
                161,
                178,
                99,
                97,
                34,
                67,
                83,
                99,
                115,
                95,
                18,
                96,
                136,
                17,
                67,
                50,
                100,
                116,
                101,
                100,
                101,
                118,
                85,
                18,
                98,
                129,
                85,
                62,
                33,
                74,
                50,
                94,
                84,
                131,
                178,
                161
            };
            UMD5.U_STRING = new byte[]
            {
                65,
                114,
                99,
                97,
                34,
                67,
                83,
                99,
                115,
                85,
                18,
                96,
                136,
                17,
                67,
                52,
                100,
                118,
                101,
                100,
                101,
                118,
                85,
                19,
                98,
                129
            };
            UMD5.string_0 = "abcdfghjklmnpqrstvxz0123456789~!@#$%^&*()_+?<>";
        }

        // Token: 0x04000015 RID: 21
        public const int MAX_FILESIZE = 104857600;

        // Token: 0x04000016 RID: 22
        public const string encryptHeader = "%@#$*&^!**$#&@^%";

        // Token: 0x04000017 RID: 23
        public static readonly byte[] U_HEADER;

        // Token: 0x04000018 RID: 24
        public static readonly byte[] U_STRING;

        // Token: 0x04000019 RID: 25
        private static readonly string string_0;
    }
}
