using System;
using System.Runtime.InteropServices;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    public class PlatformInvokeKernel32
    {
        // Token: 0x060001D9 RID: 473
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        public static extern int GetDriveType(string lpRootPathName);

        // Token: 0x060001DA RID: 474 RVA: 0x000022AB File Offset: 0x000004AB
        public PlatformInvokeKernel32()
        {
            Class3.vd4OXo2zYFEgU();
        }

        // Token: 0x040001A0 RID: 416
        public const int DriveUnknown = 0;

        // Token: 0x040001A1 RID: 417
        public const int DriveNoRootdir = 1;

        // Token: 0x040001A2 RID: 418
        public const int DriveRemoveable = 2;

        // Token: 0x040001A3 RID: 419
        public const int DriveFixed = 3;

        // Token: 0x040001A4 RID: 420
        public const int DriveRemote = 4;

        // Token: 0x040001A5 RID: 421
        public const int int_0 = 5;

        // Token: 0x040001A6 RID: 422
        public const int DriveRamdisk = 6;
    }
}
