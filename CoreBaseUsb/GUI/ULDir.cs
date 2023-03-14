using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using CoreBaseUsb.GUI;
using CoreBaseUsb.RAW;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    // Token: 0x0200001C RID: 28
    public sealed class ULDir
    {
        // Token: 0x1700000E RID: 14
        // (get) Token: 0x06000130 RID: 304 RVA: 0x00015928 File Offset: 0x00013B28
        public string Response
        {
            get
            {
                return this.string_1;
            }
        }

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000131 RID: 305 RVA: 0x00015940 File Offset: 0x00013B40
        public string DiskSpace
        {
            get
            {
                return this.string_0;
            }
        }

        // Token: 0x06000132 RID: 306 RVA: 0x00015958 File Offset: 0x00013B58
        public ULDir(string command, string args)
        {
            Class3.vd4OXo2zYFEgU();
            this.string_0 = "";
            this.string_1 = "";
            Cursor value = Cursor.Current;
            Cursor waitCursor = Cursors.WaitCursor;
            try
            {
                Cursor.Current = waitCursor;
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    if (process.ProcessName.ToString() == "ucom")
                    {
                        process.Close();
                    }
                }
                this.SetDebugDialog(LTOOLSnet.debugDialog);
                this.method_0("ULDir(): " + command + " " + args);
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = command;
                processStartInfo.Arguments = args;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.WorkingDirectory = LTOOLSnet.GUIDirectory;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                if (args.IndexOf("WRITE") > 0)
                {
                    LTOOLSnet.ShowStatusBar(true, usbpublic.FILE_SIZE);
                }
                Process process2 = Process.Start(processStartInfo);
                if (args.IndexOf("WRITE") > 0)
                {
                    while (!process2.HasExited)
                    {
                        Application.DoEvents();
                    }
                }
                StreamReader standardOutput = process2.StandardOutput;
                this.string_1 = standardOutput.ReadToEnd();
                standardOutput.Close();
                if (args.IndexOf("WRITE") > 0 || args.IndexOf("READ") > 0)
                {
                    LTOOLSnet.ShowStatusBar(false, 0L);
                }
                if (this.string_1.LastIndexOf("\r\n") > 0 && this.string_1.IndexOf("Disk space:") > 0)
                {
                    int num = this.string_1.LastIndexOf("\r\n");
                    int length = this.string_1.LastIndexOf("\r\n", num - 2);
                    if (this.string_1.IndexOf("Disk space:") > 0)
                    {
                        this.string_0 = this.string_1.Substring(this.string_1.IndexOf("Disk space:") + "Disk space".Length, this.string_1.Length - 2 - this.string_1.IndexOf("Disk space:") - "Disk space".Length);
                        this.string_0 = "Dung lượng" + this.string_0.Replace(" of ", "/").Replace("free", " (free)");
                        LTOOLSnet.UpdateStatusBarPanel_Size(this.string_0);
                        LTOOLSnet.USBInfo = this.string_0;
                    }
                    string text = this.string_1.Substring(0, length);
                    this.string_1 = text;
                }
                process2.Close();
                string path = "zzz.zwz";
                if (args.IndexOf("-x") > 0 && File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                LTOOLSnet.ShowProgessBar(false);
                MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Cursor.Current = value;
        }

        // Token: 0x06000133 RID: 307 RVA: 0x00015C78 File Offset: 0x00013E78
        public ULDir(string command, string args, Socket s)
        {
            Class3.vd4OXo2zYFEgU();
            this.string_0 = "";
            this.string_1 = "";
            //base..ctor();
            Cursor value = Cursor.Current;
            Cursor waitCursor = Cursors.WaitCursor;
            try
            {
                Cursor.Current = waitCursor;
                this.SetDebugDialog(LTOOLSnet.debugDialog);
                this.method_0("ULDir()-remote: " + command + " " + args);
                Encoding ascii = Encoding.ASCII;
                string s2 = string.Concat(new string[]
                {
                    "EXECUTE\n",
                    command,
                    " ",
                    args,
                    "\n"
                });
                byte[] bytes = ascii.GetBytes(s2);
                byte[] array = new byte[LTOOLSnet.BUFSIZE];
                s.Send(bytes, bytes.Length, SocketFlags.None);
                int num = s.Receive(array, array.Length, SocketFlags.None);
                string text = "";
                text += ascii.GetString(array, 0, num);
                int i = 0;
                int num2 = int.Parse(text);
                this.string_1 = "";
                if (num2 > 0)
                {
                    while (i < num2)
                    {
                        num = s.Receive(array, array.Length, SocketFlags.None);
                        i += num;
                        this.string_1 += ascii.GetString(array, 0, num);
                    }
                }
                else
                {
                    this.string_1 = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Cursor.Current = value;
        }

        // Token: 0x06000134 RID: 308 RVA: 0x00015E08 File Offset: 0x00014008
        public string GetPartitions()
        {
            this.method_0("GetPartitions()");
            string text = this.string_1;
            string text2 = "*** Partition table info from LTOOLS: ***\n";
            string text3 = "";
            int num = 0;
            for (; ; )
            {
                num = text.IndexOf("#", num);
                if (num < 0)
                {
                    break;
                }
                int num2 = text.IndexOf("\n", num);
                int num3;
                if ((num3 = text.Substring(num, num2 - num).IndexOf("Disk ")) > 0)
                {
                    text3 = text.Substring(num, num2 - num).Substring(num3 + 11, 8);
                    text2 += "------------------------------------------------\n";
                }
                else if ((num3 = text.Substring(num, num2 - num).IndexOf("Type:")) > 0)
                {
                    string text4 = text.Substring(num, num2 - num).Substring(1, 3);
                    string text5 = text.Substring(num, num2 - num).Substring(num3 + 5, num3 + 25 - (num3 + 5));
                    text2 = string.Concat(new string[]
                    {
                        text2,
                        " ",
                        text3,
                        text4,
                        " :   ",
                        text5,
                        "\n"
                    });
                }
                else if (text.Substring(num, num2 - num).IndexOf("RFSTOOL infos") > 0)
                {
                    text2 += "\n*** Partition table info from RFSTOOL: ***\n";
                }
                num = num2;
            }
            return text2;
        }

        // Token: 0x06000135 RID: 309 RVA: 0x000028CC File Offset: 0x00000ACC
        public void SetDebugDialog(MyDebug dDialog)
        {
            ULDir.debugDialog = dDialog;
        }

        // Token: 0x06000136 RID: 310 RVA: 0x000028D4 File Offset: 0x00000AD4
        private void method_0(string string_2)
        {
            if (ULDir.debugDialog != null)
            {
                ULDir.debugDialog.AppendText(string_2 + "\r\n");
            }
        }

        // Token: 0x06000137 RID: 311 RVA: 0x000028F5 File Offset: 0x00000AF5
        static ULDir()
        {
            Class3.vd4OXo2zYFEgU();
            ULDir.debugDialog = null;
        }

        // Token: 0x040000ED RID: 237
        private string string_0;

        // Token: 0x040000EE RID: 238
        private string string_1;

        // Token: 0x040000EF RID: 239
        public static MyDebug debugDialog;
    }
}
