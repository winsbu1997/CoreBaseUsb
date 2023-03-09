using System;
using System.Collections;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.RAW
{
    public class MY_U
    {
        public int BytesPerSector(int drive)
        {
            int num = 0;
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    if (num == drive)
                    {
                        object obj = managementObject["BytesPerSector"];
                        return int.Parse(obj.ToString());
                    }
                    num++;
                }
            }
            catch (ManagementException)
            {
                return -1;
            }
            return 0;
        }

        // Token: 0x0600003C RID: 60 RVA: 0x000049C0 File Offset: 0x00002BC0
        public ArrayList GetDriveList()
        {
            ArrayList arrayList = new ArrayList();
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    arrayList.Add(managementObject["DeviceID"].ToString());
                }
            }
            catch (ManagementException)
            {
                return null;
            }
            return arrayList;
        }

        // Token: 0x0600003D RID: 61 RVA: 0x00004A58 File Offset: 0x00002C58
        public static int GetTotalSectors(int drive)
        {
            int num = 0;
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    if (num == drive)
                    {
                        object obj = managementObject["TotalSectors"];
                        return int.Parse(obj.ToString());
                    }
                    num++;
                }
            }
            catch (ManagementException)
            {
                return -1;
            }
            return -1;
        }

        // Token: 0x0600003E RID: 62 RVA: 0x00004AFC File Offset: 0x00002CFC
        public static int GetSectorsPerTrack(int drive)
        {
            int num = 0;
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    if (num == drive)
                    {
                        object obj = managementObject["SectorsPerTrack"];
                        return int.Parse(obj.ToString());
                    }
                    num++;
                }
            }
            catch (ManagementException)
            {
                return -1;
            }
            return -1;
        }

        // Token: 0x0600003F RID: 63 RVA: 0x00004BA0 File Offset: 0x00002DA0
        public static int GetTotalTracks(int drive)
        {
            int num = 0;
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    if (num == drive)
                    {
                        object obj = managementObject["TotalTracks"];
                        return int.Parse(obj.ToString());
                    }
                    num++;
                }
            }
            catch (ManagementException)
            {
                return -1;
            }
            return -1;
        }

        // Token: 0x06000040 RID: 64
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SetFilePointer([In] SafeFileHandle safeFileHandle_0, [In] long long_0, out int int_0, [In] MY_U.EMoveMethod emoveMethod_0);

        // Token: 0x06000041 RID: 65
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

        // Token: 0x06000042 RID: 66
        [DllImport("kernel32", SetLastError = true)]
        internal static extern int ReadFile(SafeFileHandle safeFileHandle_0, byte[] byte_0, int int_0, out int int_1, IntPtr intptr_0);

        // Token: 0x06000043 RID: 67 RVA: 0x00004C44 File Offset: 0x00002E44
        public static byte[] DumpSector(string drive, double sector, int bytesPerSector)
        {
            SafeFileHandle safeFileHandle = MY_U.CreateFile(drive, 0U, 0U, IntPtr.Zero, 0U, 0U, IntPtr.Zero);
            if (safeFileHandle.IsInvalid)
            {
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }
            double num = sector * (double)bytesPerSector;
            int num2 = int.Parse(bytesPerSector.ToString());
            byte[] array = new byte[num2];
            int num3 = 0;
            int num4;
            MY_U.SetFilePointer(safeFileHandle, (long)int.Parse(num.ToString()), out num4, MY_U.EMoveMethod.Begin);
            MY_U.ReadFile(safeFileHandle, array, num2, out num3, IntPtr.Zero);
            safeFileHandle.Close();
            return array;
        }

        // Token: 0x06000044 RID: 68 RVA: 0x00004CCC File Offset: 0x00002ECC
        private byte[] method_0(string string_0, double double_0, int int_0, int int_1)
        {
            SafeFileHandle safeFileHandle = MY_U.CreateFile(string_0, 2147483648U, 0U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
            if (safeFileHandle.IsInvalid)
            {
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
            }
            double num = double_0 * (double)int_0 * (double)int_1;
            int num2 = int.Parse(int_0.ToString());
            byte[] array = new byte[num2 * int_1];
            int num3 = 0;
            int num4;
            MY_U.SetFilePointer(safeFileHandle, long.Parse(num.ToString()), out num4, MY_U.EMoveMethod.Begin);
            MY_U.ReadFile(safeFileHandle, array, num2, out num3, IntPtr.Zero);
            safeFileHandle.Close();
            return array;
        }

        // Token: 0x06000045 RID: 69 RVA: 0x000022AB File Offset: 0x000004AB
        public MY_U()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x0200000E RID: 14
        public enum EMoveMethod : uint
        {
            // Token: 0x0400001E RID: 30
            Begin,
            // Token: 0x0400001F RID: 31
            Current,
            // Token: 0x04000020 RID: 32
            End
        }
    }
}
