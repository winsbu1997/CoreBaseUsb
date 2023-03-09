using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.RAW
{
    public class DISK
    {
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern SafeFileHandle CreateFile(string string_0, FileAccess fileAccess_0, FileShare fileShare_0, uint uint_0, FileMode fileMode_0, uint uint_1, uint uint_2);

        // Token: 0x06000047 RID: 71 RVA: 0x00004D5C File Offset: 0x00002F5C
        public static DISK.streamer CreateStream(string drive, FileAccess type)
        {
            DISK.streamer streamer = default(DISK.streamer);
            int num = 0;
            DISK.streamer result;
            try
            {
                SafeFileHandle safeFileHandle;
                do
                {
                    safeFileHandle = DISK.CreateFile("\\\\.\\" + drive, type, FileShare.None, 0U, FileMode.Open, 0U, 0U);
                    if (!safeFileHandle.IsInvalid)
                    {
                        goto IL_4E;
                    }
                    num++;
                }
                while (num <= 6);
                streamer.isERROR = true;
                return streamer;
            IL_4E:
                if (!safeFileHandle.IsInvalid)
                {
                    Stream str = new FileStream(safeFileHandle, type);
                    streamer.SH = safeFileHandle;
                    streamer.STR = str;
                    streamer.isERROR = false;
                    streamer.THIS_U = drive;
                    byte[] array = DISK.ReadUSec(0, 512, streamer);
                    if (array[450] == 213 || array[466] == 213)
                    {
                        streamer.m_iUSBKey = 1;
                    }
                    result = streamer;
                }
                else
                {
                    streamer.isERROR = true;
                    result = streamer;
                }
            }
            catch
            {
                streamer.isERROR = true;
                result = streamer;
            }
            return result;
        }

        // Token: 0x06000048 RID: 72 RVA: 0x00004E54 File Offset: 0x00003054
        public static byte[] ReadUSec(int startingsector, int numberofsectors, DISK.streamer iface)
        {
            try
            {
                byte[] array = new byte[numberofsectors];
                if (!iface.SH.IsInvalid && iface.STR.CanRead)
                {
                    iface.STR.Seek((long)(startingsector * 512), SeekOrigin.Begin);
                    iface.STR.Read(array, 0, numberofsectors);
                    return array;
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00004ECC File Offset: 0x000030CC
        public static int smethod_0(long startingsector, int numberofsectors, byte[] data, DISK.streamer iface)
        {
            int result;
            if (!iface.SH.IsInvalid && iface.STR.CanWrite)
            {
                iface.STR.Seek(startingsector * 512L, SeekOrigin.Begin);
                iface.STR.Write(data, 0, numberofsectors);
                iface.STR.Flush();
                result = 0;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        // Token: 0x0600004A RID: 74 RVA: 0x00004F34 File Offset: 0x00003134
        public static bool DropStream(DISK.streamer iface)
        {
            bool result;
            try
            {
                iface.STR.Close();
                iface.SH.Close();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        // Token: 0x0600004B RID: 75 RVA: 0x00004F74 File Offset: 0x00003174
        public static string READ_FKEY_FromUSB()
        {
            string result;
            try
            {
                if (usbpublic.THIS_U == "")
                {
                    result = "";
                }
                else
                {
                    DISK.streamer iface = DISK.CreateStream(usbpublic.THIS_U, FileAccess.Read);
                    if (iface.isERROR)
                    {
                        result = "";
                    }
                    else
                    {
                        byte[] array = DISK.ReadUSec(13, 512, iface);
                        DISK.DropStream(iface);
                        byte[] array2 = new byte[64];
                        for (int i = 0; i < 64; i++)
                        {
                            array2[i] = array[i + UMD5.U_HEADER.Length];
                        }
                        string @string = Encoding.ASCII.GetString(array2);
                        result = @string;
                    }
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x0600004C RID: 76 RVA: 0x0000502C File Offset: 0x0000322C
        public static long READ_FILE_SIZE()
        {
            long result;
            try
            {
                if (usbpublic.THIS_U == "")
                {
                    result = -1L;
                }
                else
                {
                    DISK.streamer iface = DISK.CreateStream(usbpublic.THIS_U, FileAccess.Read);
                    if (iface.isERROR)
                    {
                        result = -1L;
                    }
                    else
                    {
                        byte[] array = DISK.ReadUSec(34, 512, iface);
                        DISK.DropStream(iface);
                        long num = (long)(((int)array[24] << 24) + ((int)array[25] << 16) + ((int)array[26] << 8) + (int)array[27]);
                        result = num;
                    }
                }
            }
            catch
            {
                result = -1L;
            }
            return result;
        }

        // Token: 0x0600004D RID: 77 RVA: 0x000050DC File Offset: 0x000032DC
        public static long READ_COPY_SIZE()
        {
            long result;
            try
            {
                if (usbpublic.THIS_U == "")
                {
                    result = -1L;
                }
                else
                {
                    DISK.streamer iface = DISK.CreateStream(usbpublic.THIS_U, FileAccess.Read);
                    if (iface.isERROR)
                    {
                        result = -1L;
                    }
                    else
                    {
                        byte[] array = DISK.ReadUSec(34, 512, iface);
                        DISK.DropStream(iface);
                        long num = (long)(((int)array[16] << 24) + ((int)array[17] << 16) + ((int)array[18] << 8) + (int)array[19]);
                        result = num;
                    }
                }
            }
            catch
            {
                result = -1L;
            }
            return result;
        }

        // Token: 0x0600004E RID: 78 RVA: 0x0000518C File Offset: 0x0000338C
        public static string ReadABCFromUSB()
        {
            string this_U = usbpublic.THIS_U;
            string result;
            try
            {
                if (this_U == "")
                {
                    result = "";
                }
                else
                {
                    DISK.streamer iface = DISK.CreateStream(this_U, FileAccess.Read);
                    if (iface.isERROR || iface.m_iUSBKey != 1)
                    {
                        result = "";
                    }
                    else
                    {
                        byte[] array = DISK.ReadUSec(8, 512, iface);
                        DISK.DropStream(iface);
                        byte[] array2 = new byte[64];
                        for (int i = 0; i < 64; i++)
                        {
                            array2[i] = array[i + UMD5.U_HEADER.Length];
                        }
                        string @string = Encoding.ASCII.GetString(array2);
                        result = @string;
                    }
                }
            }
            catch
            {
                result = "";
            }
            return result;
        }

        // Token: 0x0600004F RID: 79 RVA: 0x000022AB File Offset: 0x000004AB
        public DISK()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x02000010 RID: 16
        public struct streamer
        {
            // Token: 0x04000021 RID: 33
            public Stream STR;

            // Token: 0x04000022 RID: 34
            public SafeFileHandle SH;

            // Token: 0x04000023 RID: 35
            public bool isERROR;

            // Token: 0x04000024 RID: 36
            public string THIS_U;

            // Token: 0x04000025 RID: 37
            public int m_iUSBKey;
        }
    }
}
