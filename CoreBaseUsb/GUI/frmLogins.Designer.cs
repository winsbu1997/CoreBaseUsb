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

        // Token: 0x06000114 RID: 276 RVA: 0x0000283C File Offset: 0x00000A3C
        private void method_2(object sender, KeyboardEventArgs e)
        {
            if (this.grpLogin.Visible)
            {
                this.txtPass.Focus();
            }
            SendKeys.Send(e.KeyboardKeyPressed);
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdChange = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btlKeyboad = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.grpDoiMK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass3 = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOK1 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtKeys = new System.Windows.Forms.RichTextBox();
            this.txtUSB = new System.Windows.Forms.RichTextBox();
            this.comboBox_0 = new System.Windows.Forms.ComboBox();
            this.picUnHide = new System.Windows.Forms.PictureBox();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyboardcontrol1 = new KeyboardClassLibrary.Keyboardcontrol();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            this.grpDoiMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grpLogin.Controls.Add(this.cmdLogin);
            this.grpLogin.Controls.Add(this.cmdChange);
            this.grpLogin.Controls.Add(this.textBox3);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.Red;
            this.grpLogin.Location = new System.Drawing.Point(194, 19);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(6);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(6);
            this.grpLogin.Size = new System.Drawing.Size(706, 229);
            this.grpLogin.TabIndex = 30;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Đăng nhập";
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.Black;
            this.cmdLogin.Image = global::CoreBaseUsb.Properties.Resources.cmdLogin;
            this.cmdLogin.Location = new System.Drawing.Point(606, 65);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(6);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(70, 52);
            this.cmdLogin.TabIndex = 52;
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdChange
            // 
            this.cmdChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChange.ForeColor = System.Drawing.Color.Blue;
            this.cmdChange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdChange.Location = new System.Drawing.Point(514, 135);
            this.cmdChange.Margin = new System.Windows.Forms.Padding(6);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(164, 44);
            this.cmdChange.TabIndex = 53;
            this.cmdChange.Text = "Đổi mật khẩu";
            this.cmdChange.UseVisualStyleBackColor = false;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(12, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 25);
            this.textBox3.TabIndex = 51;
            this.textBox3.Text = "Mật khẩu";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 39;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(146, 75);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(444, 37);
            this.txtPass.TabIndex = 1;
            // 
            // btlKeyboad
            // 
            this.btlKeyboad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btlKeyboad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlKeyboad.ForeColor = System.Drawing.Color.Black;
            this.btlKeyboad.Location = new System.Drawing.Point(16, 254);
            this.btlKeyboad.Margin = new System.Windows.Forms.Padding(6);
            this.btlKeyboad.Name = "btlKeyboad";
            this.btlKeyboad.Size = new System.Drawing.Size(72, 42);
            this.btlKeyboad.TabIndex = 38;
            this.btlKeyboad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlKeyboad.UseVisualStyleBackColor = false;
            this.btlKeyboad.Click += new System.EventHandler(this.btlKeyboad_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.Black;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(1036, 15);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(6);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(64, 62);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Visible = false;
            // 
            // grpDoiMK
            // 
            this.grpDoiMK.BackColor = System.Drawing.Color.PowderBlue;
            this.grpDoiMK.Controls.Add(this.label1);
            this.grpDoiMK.Controls.Add(this.txtPass3);
            this.grpDoiMK.Controls.Add(this.cmdClose);
            this.grpDoiMK.Controls.Add(this.cmdOK1);
            this.grpDoiMK.Controls.Add(this.Label8);
            this.grpDoiMK.Controls.Add(this.Label7);
            this.grpDoiMK.Controls.Add(this.txtPass2);
            this.grpDoiMK.Controls.Add(this.txtPass1);
            this.grpDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDoiMK.ForeColor = System.Drawing.Color.Red;
            this.grpDoiMK.Location = new System.Drawing.Point(190, 19);
            this.grpDoiMK.Margin = new System.Windows.Forms.Padding(6);
            this.grpDoiMK.Name = "grpDoiMK";
            this.grpDoiMK.Padding = new System.Windows.Forms.Padding(6);
            this.grpDoiMK.Size = new System.Drawing.Size(708, 229);
            this.grpDoiMK.TabIndex = 31;
            this.grpDoiMK.TabStop = false;
            this.grpDoiMK.Text = "Thay mật khẩu";
            this.grpDoiMK.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "(nhập lại)";
            // 
            // txtPass3
            // 
            this.txtPass3.BackColor = System.Drawing.Color.White;
            this.txtPass3.Location = new System.Drawing.Point(158, 154);
            this.txtPass3.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass3.Name = "txtPass3";
            this.txtPass3.PasswordChar = '*';
            this.txtPass3.Size = new System.Drawing.Size(348, 32);
            this.txtPass3.TabIndex = 7;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.Black;
            this.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.Location = new System.Drawing.Point(574, 138);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(6);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(120, 54);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Hủy";
            this.cmdClose.UseVisualStyleBackColor = false;
            // 
            // cmdOK1
            // 
            this.cmdOK1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdOK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK1.ForeColor = System.Drawing.Color.Black;
            this.cmdOK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK1.Location = new System.Drawing.Point(574, 54);
            this.cmdOK1.Margin = new System.Windows.Forms.Padding(6);
            this.cmdOK1.Name = "cmdOK1";
            this.cmdOK1.Size = new System.Drawing.Size(120, 54);
            this.cmdOK1.TabIndex = 8;
            this.cmdOK1.Text = "Đồng ý";
            this.cmdOK1.UseVisualStyleBackColor = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Blue;
            this.Label8.Location = new System.Drawing.Point(12, 106);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(143, 26);
            this.Label8.TabIndex = 28;
            this.Label8.Text = "Mật khẩu mới";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(12, 48);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(130, 26);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Mật khẩu cũ";
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.Color.White;
            this.txtPass2.Location = new System.Drawing.Point(158, 106);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(348, 32);
            this.txtPass2.TabIndex = 6;
            // 
            // txtPass1
            // 
            this.txtPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPass1.Location = new System.Drawing.Point(158, 54);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(348, 32);
            this.txtPass1.TabIndex = 5;
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(308, 444);
            this.txtKeys.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(322, 35);
            this.txtKeys.TabIndex = 34;
            this.txtKeys.Text = "";
            this.txtKeys.Visible = false;
            // 
            // txtUSB
            // 
            this.txtUSB.Location = new System.Drawing.Point(310, 408);
            this.txtUSB.Margin = new System.Windows.Forms.Padding(6);
            this.txtUSB.Name = "txtUSB";
            this.txtUSB.Size = new System.Drawing.Size(322, 35);
            this.txtUSB.TabIndex = 35;
            this.txtUSB.Text = "";
            this.txtUSB.Visible = false;
            // 
            // comboBox_0
            // 
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new System.Drawing.Point(920, 6);
            this.comboBox_0.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_0.Name = "comboBox_0";
            this.comboBox_0.Size = new System.Drawing.Size(32, 33);
            this.comboBox_0.TabIndex = 36;
            this.comboBox_0.Visible = false;
            // 
            // picUnHide
            // 
            this.picUnHide.Location = new System.Drawing.Point(488, 275);
            this.picUnHide.Margin = new System.Windows.Forms.Padding(6);
            this.picUnHide.Name = "picUnHide";
            this.picUnHide.Size = new System.Drawing.Size(37, 16);
            this.picUnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUnHide.TabIndex = 40;
            this.picUnHide.TabStop = false;
            this.picUnHide.Visible = false;
            // 
            // picHide
            // 
            this.picHide.Location = new System.Drawing.Point(404, 273);
            this.picHide.Margin = new System.Windows.Forms.Padding(6);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(37, 16);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHide.TabIndex = 41;
            this.picHide.TabStop = false;
            this.picHide.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(398, 269);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 30);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "USB - AT";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(722, 273);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 25);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "Version 2.0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(952, 19);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // keyboardcontrol1
            // 
            this.keyboardcontrol1.KeyboardType = KeyboardClassLibrary.BoW.Alphabetical;
            this.keyboardcontrol1.Location = new System.Drawing.Point(-2, 317);
            this.keyboardcontrol1.Margin = new System.Windows.Forms.Padding(8);
            this.keyboardcontrol1.Name = "keyboardcontrol1";
            this.keyboardcontrol1.Size = new System.Drawing.Size(1160, 304);
            this.keyboardcontrol1.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.keyboardcontrol1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btlKeyboad);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.picUnHide);
            this.Controls.Add(this.comboBox_0);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.txtUSB);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpDoiMK);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB-AT (2.01.04)";
            this.Load += new System.EventHandler(this.frmLogins_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpDoiMK.ResumeLayout(false);
            this.grpDoiMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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