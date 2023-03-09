using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace CoreBaseUsb.RAW
{
    public class USBSerialNumber
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern bool GetVolumeNameForVolumeMountPoint(string lpszVolumeMountPoint, [Out] StringBuilder lpszVolumeName, uint cchBufferLength);

        // Token: 0x06000051 RID: 81
        [DllImport("Kernel32.dll")]
        public static extern bool DeleteVolumeMountPoint(string lpszVolumeMountPoint);

        // Token: 0x06000052 RID: 82
        [DllImport("Kernel32.dll")]
        public static extern bool SetVolumeMountPoint(string lpszVolumeMountPoint, string lpszVolumeName);

        // Token: 0x06000053 RID: 83 RVA: 0x00005250 File Offset: 0x00003450
        public string getSerialNumberFromDriveLetter(string driveLetter)
        {
            this.string_1 = driveLetter.ToUpper();
            if (!this.string_1.Contains(":"))
            {
                this.string_1 += ":";
            }
            this.method_0();
            return this.string_0;
        }

        // Token: 0x06000054 RID: 84 RVA: 0x000052A0 File Offset: 0x000034A0
        private void method_0()
        {
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                string a = this.method_2(managementObject["Dependent"].ToString());
                string[] array = this.method_2(managementObject["Antecedent"].ToString()).Split(new char[]
                {
                    ','
                });
                string str = array[0].Remove(0, 6).Trim();
                if (a == this.string_1)
                {
                    ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                    foreach (ManagementBaseObject managementBaseObject2 in managementObjectSearcher2.Get())
                    {
                        ManagementObject managementObject2 = (ManagementObject)managementBaseObject2;
                        if (managementObject2["Name"].ToString() == "\\\\.\\PHYSICALDRIVE" + str & managementObject2["InterfaceType"].ToString() == "USB")
                        {
                            this.string_0 = this.method_1(managementObject2["PNPDeviceID"].ToString());
                        }
                    }
                }
            }
        }

        // Token: 0x06000055 RID: 85 RVA: 0x00005438 File Offset: 0x00003638
        public string getDriveLetterFromPhysicalDisk(string physicalDisk)
        {
            string result = "";
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                string text = this.method_2(managementObject["Dependent"].ToString());
                string[] array = this.method_2(managementObject["Antecedent"].ToString()).Split(new char[]
                {
                    ','
                });
                string a = array[0].Remove(0, 6).Trim();
                if (a == physicalDisk)
                {
                    result = text;
                }
            }
            return result;
        }

        // Token: 0x06000056 RID: 86 RVA: 0x00005508 File Offset: 0x00003708
        private string method_1(string string_2)
        {
            string[] array = string_2.Split(new char[]
            {
                '\\'
            });
            int num = array.Length - 1;
            string[] array2 = array[num].Split(new char[]
            {
                '&'
            });
            return array2[0];
        }

        // Token: 0x06000057 RID: 87 RVA: 0x00005550 File Offset: 0x00003750
        private string method_2(string string_2)
        {
            int num = string_2.IndexOf("\"");
            int num2 = string_2.IndexOf("\"", num + 1);
            return string_2.Substring(num + 1, num2 - num - 1);
        }

        // Token: 0x06000058 RID: 88 RVA: 0x00005594 File Offset: 0x00003794
        public static bool USB_WriteProtect()
        {
            try
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies");
                if (Convert.ToInt16(registryKey.GetValue("WriteProtect", null)) == 1)
                {
                    return true;
                }
                return false;
            }
            catch (NullReferenceException)
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control", true);
                registryKey.CreateSubKey("StorageDevicePolicies");
                registryKey.Close();
            }
            catch (Exception)
            {
            }
            return false;
        }

        // Token: 0x06000059 RID: 89 RVA: 0x000022AB File Offset: 0x000004AB
        public USBSerialNumber()
        {
            Class3.vd4OXo2zYFEgU();
            base..ctor();
        }

        // Token: 0x04000026 RID: 38
        public const int MAX_PATH = 260;

        // Token: 0x04000027 RID: 39
        private string string_0;

        // Token: 0x04000028 RID: 40
        private string string_1;
    }
}
