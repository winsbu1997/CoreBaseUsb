using CoreBaseUsb.RAW;
using CoreBaseUsb.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    public partial class LTOOLSnet : Form
    {
        public LTOOLSnet()
        {
            Class3.vd4OXo2zYFEgU();
            this.string_0 = "";
            this.int_0 = 0;
            try
            {
                foreach (Process process in Process.GetProcessesByName("ucom"))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (!LTOOLSnet.bool_7)
            {
                base.Dispose();
            }
            this.InitializeComponent();
            if (LTOOLSnet.bool_5)
            {
                LTOOLSnet.debugDialog = new MyDebug();
                this.menuItem_9.Visible = false;
                if (LTOOLSnet.debugDialog.Visible)
                {
                    this.menuItem_9.Checked = true;
                }
            }
            LTOOLSnet.ltoolsnet_0 = this;
            this.timer_0.Enabled = LTOOLSnet.bool_2;
            if (LTOOLSnet.MAINMK == "")
            {
                LTOOLSnet.ltoolsnet_0.Dispose();
            }
            if (!Directory.Exists(DirFilePanel.tempPathLinuxFiles))
            {
                LTOOLSnet.smethod_0("Create Directory " + DirFilePanel.tempPathLinuxFiles);
                Directory.CreateDirectory(DirFilePanel.tempPathLinuxFiles);
            }
            string[] files = Directory.GetFiles(DirFilePanel.tempPathLinuxFiles);
            foreach (string text in files)
            {
                LTOOLSnet.smethod_0("delete file: " + text);
                try
                {
                    File.Delete(text);
                }
                catch
                {
                    break;
                }
            }
            LTOOLSnet.smethod_0("TempPathUSBFiles: " + DirFilePanel.tempPathLinuxFiles);
            LTOOLSnet.smethod_0("Current Directory : " + Environment.CurrentDirectory);
            this.menuItem_15.Checked = LTOOLSnet.bool_1;
            this.toolBarButtonReadOnly.Pushed = LTOOLSnet.bool_1;
            this.toolBarButtonReadOnly.Visible = false;
            this.menuItem_12.Checked = LTOOLSnet.bool_0;
            this.toolBarButtonConfirmDelete.Pushed = LTOOLSnet.bool_0;
            this.menuItem_28.Checked = LTOOLSnet.bool_3;
            this.toolBarButtonEncrypt.Pushed = LTOOLSnet.bool_3;
            LTOOLSnet.UpdateStatusToolBar();
            this.dosFilePanel.SetDebugDialog(LTOOLSnet.debugDialog);
            DISK.ReadABCFromUSB();
            if (LTOOLSnet.MAINMK == "")
            {
                base.Dispose();
            }
            this.dosFilePanel.FillDosDirectoryTree();
            this.linuxFilePanel.SetDebugDialog(LTOOLSnet.debugDialog);
            this.linuxFilePanel.FillLinuxDirectoryTree();
            DateTime now = DateTime.Now;
            string format = "dd/MM/yyyy";
            this.statusBarPanel0.Text = "USB - AT (Version 2.0)";
            this.statusBarPanel2.Text = "Ngày làm việc: " + now.ToString(format);
            LTOOLSnet.bool_1 = false;
            DCOPY.ENABLE_COPY_DIR = new ArrayList();
            DCOPY.ENABLE_COPY_DIR.Add("C:\\DOWNLOADS");
            DCOPY.ENABLE_COPY_DIR.Add("C:\\UPLOAD");
            DCOPY.ENABLE_COPY_DIR.Add("D:\\VSKEY-DATA");
        }
    }
}
