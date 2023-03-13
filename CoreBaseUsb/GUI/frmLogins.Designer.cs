using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using KeyboardClassLibrary;
using CoreBaseUsb.RAW;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    partial class frmLogins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool IsLoginOK
        {
            get
            {
                return this.bool_0;
            }
        }
        private void frmLogins_Load(object sender, EventArgs e)
        {
            this.btlKeyboad.Image = this.picUnHide.Image;
            this.txtPass.Focus();
            this.bool_1 = false;
            this.btlKeyboad.Image = this.picHide.Image;
            this.keyboardcontrol1.Visible = false;
            base.Height = base.Height - this.keyboardcontrol1.Height + 40;
            base.Width = this.groupBox1.Width;
            this.keyboardcontrol1.KeyboardType = BoW.Alphabetical;
            string this_U = this.method_5();
            usbpublic.THIS_U = this_U;
            this.method_6();
        }

        // Token: 0x0600010A RID: 266 RVA: 0x000027D7 File Offset: 0x000009D7
        private void cmdChange_Click(object sender, EventArgs e)
        {
            this.grpLogin.Visible = false;
            this.grpDoiMK.Visible = true;
            this.txtPass1.Focus();
        }

        // Token: 0x0600010B RID: 267 RVA: 0x000027FD File Offset: 0x000009FD
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.grpLogin.Visible = true;
            this.grpDoiMK.Visible = false;
            this.txtPass.Focus();
        }

        // Token: 0x0600010C RID: 268 RVA: 0x00012B8C File Offset: 0x00010D8C
        private void cmdOK1_Click(object sender, EventArgs e)
        {
            string text = this.method_5();
            if (text == "")
            {
                MessageBox.Show("Lỗi truy cập USB hoặc USB không được mã hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                this.ReadKeyFromUSB();
                string text2 = this.txtPass1.Text.Trim();
                byte[] array = UMD5.smethod_2(text2);
                string @string = Encoding.ASCII.GetString(array);
                text2 = @string;
                if (text2 != this.txtKeys.Text && this.txtKeys.Text.Length > 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng, xin mời nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.txtPass2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mật khẩu nhập mới không đúng, xin mời nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!this.txtPass2.Text.Equals(this.txtPass3.Text) && this.txtPass2.Text.Length > 0)
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng, xin mời nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    byte[] u_HEADER = UMD5.U_HEADER;
                    byte[] bytes = Encoding.ASCII.GetBytes(UMD5.RandomString(256));
                    array = UMD5.smethod_2(this.txtPass2.Text.Trim());
                    byte[] array2 = new byte[512];
                    for (int i = 0; i <= u_HEADER.Length - 1; i++)
                    {
                        array2[i] = u_HEADER[i];
                    }
                    for (int i = 0; i <= array.Length - 1; i++)
                    {
                        array2[i + u_HEADER.Length] = array[i];
                    }
                    for (int i = 0; i <= bytes.Length - 1; i++)
                    {
                        array2[i + u_HEADER.Length + array.Length] = bytes[i];
                    }
                    int num = u_HEADER.Length + array.Length + bytes.Length;
                    for (int i = num; i <= 511; i++)
                    {
                        array2[i] = bytes[i - num + 1];
                    }
                    DISK.streamer iface = DISK.CreateStream(text, FileAccess.ReadWrite);
                    int num2 = DISK.smethod_0(2L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(3L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(4L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(5L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(6L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(7L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(8L, 512, array2, iface);
                    num2 = DISK.smethod_0(9L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num2 = DISK.smethod_0(10L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    if (num2 == -1)
                    {
                        MessageBox.Show("Lỗi đổi mật khẩu. Xin kiểm tra lại USB!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        DISK.DropStream(iface);
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.grpDoiMK.Visible = false;
                        this.grpLogin.Visible = true;
                    }
                }
            }
        }

        // Token: 0x0600010D RID: 269 RVA: 0x00002823 File Offset: 0x00000A23
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.cmdLogin_Click(sender, e);
            }
        }

        // Token: 0x0600010E RID: 270 RVA: 0x00012F64 File Offset: 0x00011164
        private void cmdExit_Click(object sender, EventArgs e)
        {
            string text = UMD5.GenerateID();
            MessageBox.Show(text);
            text = UMD5.GenerateID();
            MessageBox.Show(text);
        }

        // Token: 0x0600010F RID: 271 RVA: 0x00012F8C File Offset: 0x0001118C
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.bool_0 = false;
            int num = 0;
            try
            {
                do
                {
                    int num2 = this.ReadKeyFromUSB();
                    if (num2 != 0 && this.txtKeys.Text.Length != 0)
                    {
                        goto IL_6C;
                    }
                    num++;
                }
                while (num <= 2);
                MessageBox.Show("Chưa nhận dạng được USB, xin kiểm tra lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUSB.Text = "ReadKeyFromUSB Error";
                return;
            IL_6C:
                this.Read_CountPassFalse();
                if (this.int_0 < 0)
                {
                    MessageBox.Show("USB không đúng định dạng, xin kiểm tra lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.int_0 >= 9)
                {
                    MessageBox.Show("USB đã bị khóa. Xin liên hệ với nhà sản xuất!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string strPassword = this.txtPass.Text.Trim();
                    byte[] bytes = UMD5.smethod_2(strPassword);
                    string @string = Encoding.ASCII.GetString(bytes);
                    LTOOLSnet.MAINMK = @string;
                    if (@string == this.txtKeys.Text && this.txtKeys.Text.Length > 0)
                    {
                        usbpublic.KEY_FORMAT = DISK.READ_FKEY_FromUSB();
                        this.bool_0 = true;
                        this.method_4(55);
                        base.Dispose();
                    }
                    else if (this.int_0 < 5)
                    {
                        this.method_4(this.int_0 + 55 + 1);
                        MessageBox.Show("Mật khẩu đăng nhập sai, xin mời nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (this.int_0 <= 10)
                    {
                        this.method_4(this.int_0 + 55 + 1);
                        MessageBox.Show("Mật khẩu đăng nhập sai.\n Cảnh báo: USB sẽ bị khóa sau (" + (10 - this.int_0).ToString() + ") lần đăng nhập sai tiếp theo!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("USB đã bị khóa. Xin liên hệ với nhà sản xuất!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Token: 0x06000110 RID: 272 RVA: 0x000131A0 File Offset: 0x000113A0
        private void method_0(object sender, EventArgs e)
        {
            this.bool_0 = false;
            int num = 0;
            try
            {
                do
                {
                    int num2 = this.ReadKeyFromUSB();
                    if (num2 != 0 && this.txtKeys.Text.Length != 0)
                    {
                        goto IL_6A;
                    }
                    num++;
                }
                while (num <= 2);
                MessageBox.Show("Thiết bị chưa sẵn sàng, xin kiểm tra lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUSB.Text = "ReadKeyFromUSB Error";
                return;
            IL_6A:
                string text = this.txtPass.Text;
                text = Encoding.ASCII.GetString(UMD5.U_HEADER) + UMD5.smethod_0(text);
                if (text == this.txtKeys.Text && this.txtKeys.Text.Length > 0)
                {
                    this.bool_0 = true;
                    base.Dispose();
                }
                else
                {
                    MessageBox.Show("Mật khẩu đăng nhập sai, xin mời nhập lại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Token: 0x06000111 RID: 273 RVA: 0x000132B8 File Offset: 0x000114B8
        private int method_1()
        {
            string text = this.method_5();
            int result;
            if (text == "")
            {
                MessageBox.Show("Lỗi truy cập USB hoặc USB không được mã hóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = -1;
            }
            else
            {
                string fileName = Application.StartupPath + "\\par00.bin";
                byte[] data = UMD5.ReadFileToByteArray(fileName);
                DISK.streamer iface = DISK.CreateStream(text, FileAccess.ReadWrite);
                int num = DISK.smethod_0(0L, 512, data, iface);
                DISK.DropStream(iface);
                if (num == 0)
                {
                    result = 0;
                }
                else
                {
                    result = -1;
                }
            }
            return result;
        }

        // Token: 0x06000112 RID: 274 RVA: 0x0001334C File Offset: 0x0001154C
        private void btlKeyboad_Click(object sender, EventArgs e)
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
                this.btlKeyboad.Image = this.picHide.Image;
                this.keyboardcontrol1.Visible = false;
                base.Height = base.Height - this.keyboardcontrol1.Height + 40;
            }
            else
            {
                this.bool_1 = true;
                this.btlKeyboad.Image = this.picUnHide.Image;
                this.keyboardcontrol1.Visible = true;
                base.Height = base.Height + this.keyboardcontrol1.Height - 40;
            }
        }

        // Token: 0x06000113 RID: 275 RVA: 0x000022A9 File Offset: 0x000004A9
        private void keyboardcontrol1_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x06000114 RID: 276 RVA: 0x0000283C File Offset: 0x00000A3C
        private void method_2(object sender, KeyboardEventArgs e)
        {
            if (this.grpLogin.Visible)
            {
                this.txtPass.Focus();
            }
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        // Token: 0x06000115 RID: 277 RVA: 0x000022A9 File Offset: 0x000004A9
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000116 RID: 278 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_3(object sender, EventArgs e)
        {
        }

        // Token: 0x06000117 RID: 279 RVA: 0x000133F0 File Offset: 0x000115F0
        public void Read_CountPassFalse()
        {
            try
            {
                DISK.streamer iface = DISK.CreateStream(usbpublic.THIS_U, FileAccess.Read);
                byte[] array = DISK.ReadUSec(16, 512, iface);
                byte[] u_HEADER = UMD5.U_HEADER;
                for (int i = 0; i <= u_HEADER.Length - 1; i++)
                {
                    if (array[i] != u_HEADER[i])
                    {
                        this.int_0 = -1;
                        DISK.DropStream(iface);
                        return;
                    }
                }
                this.int_0 = Convert.ToInt32(array[u_HEADER.Length + 1]) - 55;
                DISK.DropStream(iface);
            }
            catch
            {
                MessageBox.Show("Lỗi đọc tham số flash!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Token: 0x06000118 RID: 280 RVA: 0x00013494 File Offset: 0x00011694
        private void method_4(int int_1)
        {
            try
            {
                byte[] u_HEADER = UMD5.U_HEADER;
                byte[] bytes = Encoding.ASCII.GetBytes(UMD5.RandomString(512));
                for (int i = 0; i <= u_HEADER.Length - 1; i++)
                {
                    bytes[i] = u_HEADER[i];
                }
                bytes[u_HEADER.Length + 1] = Convert.ToByte(int_1);
                DISK.streamer iface = DISK.CreateStream(usbpublic.THIS_U, FileAccess.ReadWrite);
                int num = DISK.smethod_0(16L, 512, bytes, iface);
                num = DISK.smethod_0(17L, 512, bytes, iface);
                num = DISK.smethod_0(18L, 512, bytes, iface);
                num = DISK.smethod_0(19L, 512, bytes, iface);
                num = DISK.smethod_0(20L, 512, bytes, iface);
                if (num == -1)
                {
                    DISK.DropStream(iface);
                    MessageBox.Show("Lỗi ghi tham số USB. Xin kiểm tra lại USB!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    DISK.DropStream(iface);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi ghi tham số flash!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Token: 0x06000119 RID: 281 RVA: 0x000135BC File Offset: 0x000117BC
        public int ReadKeyFromUSB()
        {
            int result;
            try
            {
                string text = this.method_5();
                usbpublic.THIS_U = text;
                if (text == "")
                {
                    this.txtUSB.Text = "USB device Error";
                    this.txtKeys.Text = "";
                    result = 0;
                }
                else
                {
                    DISK.streamer iface = DISK.CreateStream(text, FileAccess.Read);
                    if (iface.isERROR)
                    {
                        this.txtUSB.Text = "myStream.isERROR";
                        this.txtKeys.Text = "";
                        DISK.DropStream(iface);
                        result = 0;
                    }
                    else if (iface.m_iUSBKey != 1)
                    {
                        this.txtUSB.Text = "myStream.isERROR";
                        this.txtKeys.Text = "";
                        DISK.DropStream(iface);
                        result = 0;
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
                        this.txtKeys.Text = @string;
                        result = 1;
                    }
                }
            }
            catch
            {
                this.txtUSB.Text = "ReadKeyFromUSB ERROR";
                this.txtKeys.Text = "";
                result = 0;
            }
            return result;
        }

        // Token: 0x0600011A RID: 282 RVA: 0x00013730 File Offset: 0x00011930
        private string method_5()
        {
            string text = "";
            string text2 = "PHYSICALDRIVE";
            string result;
            try
            {
                ArrayList arrayList = new ArrayList();
                this.comboBox_0.Items.Clear();
                arrayList = this.GetPhysicalDriveName();
                foreach (object item in arrayList)
                {
                    this.comboBox_0.Items.Add(item);
                }
                for (int i = 0; i <= this.comboBox_0.Items.Count - 1; i++)
                {
                    this.comboBox_0.SelectedIndex = i;
                    int num = this.comboBox_0.Text.IndexOf(text2);
                    if (num > 0)
                    {
                        text = text2 + this.comboBox_0.Text.Substring(this.comboBox_0.Text.Length - 1, 1);
                        DISK.streamer iface = DISK.CreateStream(text, FileAccess.Read);
                        if (!iface.isERROR)
                        {
                            byte[] array = DISK.ReadUSec(8, 512, iface);
                            DISK.DropStream(iface);
                            byte[] array2 = new byte[UMD5.U_HEADER.Length];
                            for (int j = 0; j <= UMD5.U_HEADER.Length - 1; j++)
                            {
                                array2[j] = array[j];
                            }
                            string @string = Encoding.ASCII.GetString(array2);
                            if (@string == Encoding.ASCII.GetString(UMD5.U_HEADER))
                            {
                                break;
                            }
                            text = "";
                        }
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

        // Token: 0x0600011B RID: 283 RVA: 0x00013904 File Offset: 0x00011B04
        public ArrayList GetPhysicalDriveName()
        {
            int num = 0;
            string value = string.Empty;
            ArrayList arrayList = new ArrayList();
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive Where InterfaceType='USB' And Size>1000000000 and Size<32000000000");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    num++;
                    value = (string)managementObject["Name"];
                    arrayList.Add(value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arrayList;
        }

        // Token: 0x0600011C RID: 284 RVA: 0x000139B4 File Offset: 0x00011BB4
        public ArrayList GetStuff(string queryObject)
        {
            int num = 0;
            string text = string.Empty;
            ArrayList arrayList = new ArrayList();
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM " + queryObject + " Where InterfaceType='USB' And Size>1000000000 and Size<10000000000");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    num++;
                    text = (string)managementObject["Name"];
                    PropertyDataCollection properties = managementObject.Properties;
                    foreach (PropertyData value in properties)
                    {
                        arrayList.Add(value);
                    }
                    MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arrayList;
        }

        // Token: 0x0600011D RID: 285 RVA: 0x00013AD0 File Offset: 0x00011CD0
        private void method_6()
        {
            string text = usbpublic.THIS_U;
            if (text.Length > 0)
            {
                text = text.Replace("PHYSICALDRIVE", "");
            }
            USBSerialNumber usbserialNumber = new USBSerialNumber();
            string driveLetterFromPhysicalDisk = usbserialNumber.getDriveLetterFromPhysicalDisk(text);
            try
            {
                if (!USBSerialNumber.GetVolumeNameForVolumeMountPoint(driveLetterFromPhysicalDisk + "\\", this.stringBuilder_0, 260U))
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
                if (!USBSerialNumber.DeleteVolumeMountPoint(driveLetterFromPhysicalDisk + "\\"))
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600011E RID: 286 RVA: 0x00013B68 File Offset: 0x00011D68
        private void method_7()
        {
            try
            {
                foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
                {
                    if (driveInfo.DriveType == DriveType.Removable)
                    {
                        string fullName = driveInfo.RootDirectory.FullName;
                    }
                }
                if (!USBSerialNumber.SetVolumeMountPoint("I:\\", this.stringBuilder_0.ToString()))
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600011F RID: 287 RVA: 0x000022A9 File Offset: 0x000004A9
        private void picUnHide_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000120 RID: 288 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_8(object sender, EventArgs e)
        {
        }

        // Token: 0x06000121 RID: 289 RVA: 0x00013BE0 File Offset: 0x00011DE0
        private static void smethod_0()
        {
            try
            {
                string this_U = usbpublic.THIS_U;
                DISK.streamer iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                string fileName = Application.StartupPath + "\\sec0.bin";
                byte[] data = UMD5.ReadFileToByteArray(fileName);
                DISK.smethod_0(0L, 512, data, iface);
                DISK.DropStream(iface);
            }
            catch
            {
            }
        }

        // Token: 0x06000122 RID: 290 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_9(object sender, EventArgs e)
        {
        }

        // Token: 0x06000123 RID: 291 RVA: 0x000022A9 File Offset: 0x000004A9
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000124 RID: 292 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_10(object sender, EventArgs e)
        {
        }

        // Token: 0x06000125 RID: 293 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_11(object sender, EventArgs e)
        {
        }

        // Token: 0x06000126 RID: 294 RVA: 0x00002865 File Offset: 0x00000A65
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000127 RID: 295 RVA: 0x00013C48 File Offset: 0x00011E48
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogins));
            this.grpLogin = new GroupBox();
            this.cmdLogin = new Button();
            this.cmdChange = new Button();
            this.textBox3 = new TextBox();
            this.label2 = new Label();
            this.txtPass = new TextBox();
            this.btlKeyboad = new Button();
            this.cmdExit = new Button();
            this.grpDoiMK = new GroupBox();
            this.label1 = new Label();
            this.txtPass3 = new TextBox();
            this.cmdClose = new Button();
            this.cmdOK1 = new Button();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.txtPass2 = new TextBox();
            this.txtPass1 = new TextBox();
            this.txtKeys = new RichTextBox();
            this.txtUSB = new RichTextBox();
            this.comboBox_0 = new ComboBox();
            this.picUnHide = new PictureBox();
            this.picHide = new PictureBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.groupBox1 = new GroupBox();
            this.keyboardcontrol1 = new Keyboardcontrol();
            this.pictureBox2 = new PictureBox();
            this.grpLogin.SuspendLayout();
            this.grpDoiMK.SuspendLayout();
            ((ISupportInitialize)this.picUnHide).BeginInit();
            ((ISupportInitialize)this.picHide).BeginInit();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            base.SuspendLayout();
            this.grpLogin.BackColor = Color.DarkSeaGreen;
            this.grpLogin.Controls.Add(this.cmdLogin);
            this.grpLogin.Controls.Add(this.cmdChange);
            this.grpLogin.Controls.Add(this.textBox3);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpLogin.ForeColor = Color.Red;
            this.grpLogin.Location = new Point(97, 10);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new Size(353, 119);
            this.grpLogin.TabIndex = 30;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Đăng nhập";
            this.cmdLogin.BackColor = SystemColors.ButtonFace;
            this.cmdLogin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdLogin.ForeColor = Color.Black;
            this.cmdLogin.Image = (Image)componentResourceManager.GetObject("cmdLogin.Image");
            this.cmdLogin.Location = new Point(303, 34);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new Size(35, 27);
            this.cmdLogin.TabIndex = 52;
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += this.cmdLogin_Click;
            this.cmdChange.BackColor = Color.FromArgb(224, 224, 224);
            this.cmdChange.FlatStyle = FlatStyle.Flat;
            this.cmdChange.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdChange.ForeColor = Color.Blue;
            this.cmdChange.ImageAlign = ContentAlignment.MiddleRight;
            this.cmdChange.Location = new Point(257, 70);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new Size(82, 23);
            this.cmdChange.TabIndex = 53;
            this.cmdChange.Text = "Đổi mật khẩu";
            this.cmdChange.UseVisualStyleBackColor = false;
            this.cmdChange.Click += this.cmdChange_Click;
            this.textBox3.BackColor = Color.DarkSeaGreen;
            this.textBox3.BorderStyle = BorderStyle.None;
            this.textBox3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox3.ForeColor = Color.Blue;
            this.textBox3.Location = new Point(6, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(65, 13);
            this.textBox3.TabIndex = 51;
            this.textBox3.Text = "Mật khẩu";
            this.textBox3.TextAlign = HorizontalAlignment.Center;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0, 13);
            this.label2.TabIndex = 39;
            this.txtPass.BackColor = Color.White;
            this.txtPass.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtPass.Location = new Point(73, 39);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new Size(224, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += this.txtPass_TextChanged;
            this.txtPass.KeyPress += this.txtPass_KeyPress;
            this.btlKeyboad.BackColor = SystemColors.ButtonFace;
            this.btlKeyboad.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btlKeyboad.ForeColor = Color.Black;
            this.btlKeyboad.Image = (Image)componentResourceManager.GetObject("btlKeyboad.Image");
            this.btlKeyboad.Location = new Point(8, 132);
            this.btlKeyboad.Name = "btlKeyboad";
            this.btlKeyboad.Size = new Size(36, 22);
            this.btlKeyboad.TabIndex = 38;
            this.btlKeyboad.TextAlign = ContentAlignment.MiddleRight;
            this.btlKeyboad.UseVisualStyleBackColor = false;
            this.btlKeyboad.Click += this.btlKeyboad_Click;
            this.cmdExit.BackColor = SystemColors.ButtonFace;
            this.cmdExit.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdExit.ForeColor = Color.Black;
            this.cmdExit.Image = (Image)componentResourceManager.GetObject("cmdExit.Image");
            this.cmdExit.ImageAlign = ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new Point(518, 8);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new Size(32, 32);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Visible = false;
            this.cmdExit.Click += this.cmdExit_Click;
            this.grpDoiMK.BackColor = Color.PowderBlue;
            this.grpDoiMK.Controls.Add(this.label1);
            this.grpDoiMK.Controls.Add(this.txtPass3);
            this.grpDoiMK.Controls.Add(this.cmdClose);
            this.grpDoiMK.Controls.Add(this.cmdOK1);
            this.grpDoiMK.Controls.Add(this.Label8);
            this.grpDoiMK.Controls.Add(this.Label7);
            this.grpDoiMK.Controls.Add(this.txtPass2);
            this.grpDoiMK.Controls.Add(this.txtPass1);
            this.grpDoiMK.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.grpDoiMK.ForeColor = Color.Red;
            this.grpDoiMK.Location = new Point(95, 10);
            this.grpDoiMK.Name = "grpDoiMK";
            this.grpDoiMK.Size = new Size(354, 119);
            this.grpDoiMK.TabIndex = 31;
            this.grpDoiMK.TabStop = false;
            this.grpDoiMK.Text = "Thay mật khẩu";
            this.grpDoiMK.Visible = false;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.Blue;
            this.label1.Location = new Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "(nhập lại)";
            this.txtPass3.BackColor = Color.White;
            this.txtPass3.Location = new Point(79, 80);
            this.txtPass3.Name = "txtPass3";
            this.txtPass3.PasswordChar = '*';
            this.txtPass3.Size = new Size(176, 20);
            this.txtPass3.TabIndex = 7;
            this.cmdClose.BackColor = SystemColors.ButtonFace;
            this.cmdClose.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdClose.ForeColor = Color.Black;
            this.cmdClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.cmdClose.Location = new Point(287, 72);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new Size(60, 28);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Hủy";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += this.cmdClose_Click;
            this.cmdOK1.BackColor = SystemColors.ButtonFace;
            this.cmdOK1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmdOK1.ForeColor = Color.Black;
            this.cmdOK1.ImageAlign = ContentAlignment.MiddleLeft;
            this.cmdOK1.Location = new Point(287, 28);
            this.cmdOK1.Name = "cmdOK1";
            this.cmdOK1.Size = new Size(60, 28);
            this.cmdOK1.TabIndex = 8;
            this.cmdOK1.Text = "Đồng ý";
            this.cmdOK1.UseVisualStyleBackColor = false;
            this.cmdOK1.Click += this.cmdOK1_Click;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = Color.Blue;
            this.Label8.Location = new Point(6, 55);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(71, 13);
            this.Label8.TabIndex = 28;
            this.Label8.Text = "Mật khẩu mới";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = Color.Blue;
            this.Label7.Location = new Point(6, 25);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(67, 13);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Mật khẩu cũ";
            this.txtPass2.BackColor = Color.White;
            this.txtPass2.Location = new Point(79, 55);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new Size(176, 20);
            this.txtPass2.TabIndex = 6;
            this.txtPass1.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPass1.Location = new Point(79, 28);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new Size(176, 20);
            this.txtPass1.TabIndex = 5;
            this.txtKeys.Location = new Point(154, 231);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new Size(163, 20);
            this.txtKeys.TabIndex = 34;
            this.txtKeys.Text = "";
            this.txtKeys.Visible = false;
            this.txtUSB.Location = new Point(155, 212);
            this.txtUSB.Name = "txtUSB";
            this.txtUSB.Size = new Size(163, 20);
            this.txtUSB.TabIndex = 35;
            this.txtUSB.Text = "";
            this.txtUSB.Visible = false;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(460, 3);
            this.comboBox_0.Name = "cboListUSB";
            this.comboBox_0.Size = new Size(18, 21);
            this.comboBox_0.TabIndex = 36;
            this.comboBox_0.Visible = false;
            this.picUnHide.Image = (Image)componentResourceManager.GetObject("picUnHide.Image");
            this.picUnHide.Location = new Point(244, 143);
            this.picUnHide.Name = "picUnHide";
            this.picUnHide.Size = new Size(37, 16);
            this.picUnHide.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picUnHide.TabIndex = 40;
            this.picUnHide.TabStop = false;
            this.picUnHide.Visible = false;
            this.picUnHide.Click += this.picUnHide_Click;
            this.picHide.Image = (Image)componentResourceManager.GetObject("picHide.Image");
            this.picHide.Location = new Point(202, 142);
            this.picHide.Name = "picHide";
            this.picHide.Size = new Size(37, 16);
            this.picHide.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picHide.TabIndex = 41;
            this.picHide.TabStop = false;
            this.picHide.Visible = false;
            this.textBox2.BackColor = Color.DarkSeaGreen;
            this.textBox2.BorderStyle = BorderStyle.None;
            this.textBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox2.ForeColor = Color.Red;
            this.textBox2.Location = new Point(199, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(103, 15);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "USB - AT";
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.textBox2.TextChanged += this.textBox2_TextChanged;
            this.textBox1.BackColor = Color.DarkSeaGreen;
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.textBox1.ForeColor = Color.FromArgb(0, 64, 64);
            this.textBox1.Location = new Point(361, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(94, 13);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "Version 2.0";
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.groupBox1.Location = new Point(1, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(476, 10);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.keyboardcontrol1.KeyboardType = BoW.Alphabetical;
            this.keyboardcontrol1.Location = new Point(-1, 165);
            this.keyboardcontrol1.Margin = new Padding(4);
            this.keyboardcontrol1.Name = "keyboardcontrol1";
            this.keyboardcontrol1.Size = new Size(580, 158);
            this.keyboardcontrol1.TabIndex = 54;
            this.keyboardcontrol1.Load += this.keyboardcontrol1_Load;
            this.keyboardcontrol1.UserKeyPressed += this.method_2;
            this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new Point(5, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(81, 89);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.DarkSeaGreen;
            base.ClientSize = new Size(476, 292);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.keyboardcontrol1);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btlKeyboad);
            base.Controls.Add(this.picHide);
            base.Controls.Add(this.picUnHide);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.cmdExit);
            base.Controls.Add(this.txtUSB);
            base.Controls.Add(this.txtKeys);
            base.Controls.Add(this.grpLogin);
            base.Controls.Add(this.grpDoiMK);
            this.ForeColor = Color.Black;
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmLogins";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "USB-AT (2.01.04)";
            base.Load += this.frmLogins_Load;
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpDoiMK.ResumeLayout(false);
            this.grpDoiMK.PerformLayout();
            ((ISupportInitialize)this.picUnHide).EndInit();
            ((ISupportInitialize)this.picHide).EndInit();
            ((ISupportInitialize)this.pictureBox2).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x040000C0 RID: 192
        private bool bool_0;

        // Token: 0x040000C1 RID: 193
        private int int_0;

        // Token: 0x040000C2 RID: 194
        private bool bool_1;

        // Token: 0x040000C3 RID: 195
        private StringBuilder stringBuilder_0;

        // Token: 0x040000C4 RID: 196
        private IContainer icontainer_0;

        // Token: 0x040000C5 RID: 197
        internal GroupBox grpLogin;

        // Token: 0x040000C6 RID: 198
        internal TextBox txtPass;

        // Token: 0x040000C7 RID: 199
        internal GroupBox grpDoiMK;

        // Token: 0x040000C8 RID: 200
        internal Button cmdClose;

        // Token: 0x040000C9 RID: 201
        internal Button cmdOK1;

        // Token: 0x040000CA RID: 202
        internal Label Label8;

        // Token: 0x040000CB RID: 203
        internal Label Label7;

        // Token: 0x040000CC RID: 204
        internal TextBox txtPass2;

        // Token: 0x040000CD RID: 205
        internal TextBox txtPass1;

        // Token: 0x040000CE RID: 206
        internal Label label1;

        // Token: 0x040000CF RID: 207
        internal TextBox txtPass3;

        // Token: 0x040000D0 RID: 208
        internal Button cmdExit;

        // Token: 0x040000D1 RID: 209
        private RichTextBox txtKeys;

        // Token: 0x040000D2 RID: 210
        private RichTextBox txtUSB;

        // Token: 0x040000D3 RID: 211
        private ComboBox comboBox_0;

        // Token: 0x040000D4 RID: 212
        internal Button btlKeyboad;

        // Token: 0x040000D5 RID: 213
        private PictureBox picUnHide;

        // Token: 0x040000D6 RID: 214
        private PictureBox picHide;

        // Token: 0x040000D7 RID: 215
        private Label label2;

        // Token: 0x040000D8 RID: 216
        private TextBox textBox2;

        // Token: 0x040000D9 RID: 217
        private TextBox textBox3;

        // Token: 0x040000DA RID: 218
        private TextBox textBox1;

        // Token: 0x040000DB RID: 219
        private GroupBox groupBox1;

        // Token: 0x040000DC RID: 220
        private Keyboardcontrol keyboardcontrol1;

        // Token: 0x040000DD RID: 221
        internal Button cmdLogin;

        // Token: 0x040000DE RID: 222
        internal Button cmdChange;

        // Token: 0x040000DF RID: 223
        private PictureBox pictureBox2;
    }
}