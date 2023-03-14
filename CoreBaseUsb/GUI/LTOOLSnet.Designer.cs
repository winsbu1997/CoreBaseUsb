using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using CoreBaseUsb.RAW;
using CoreBaseUsb.Utilities;
using System.Collections;

namespace CoreBaseUsb.GUI
{
    partial class LTOOLSnet 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public static LTOOLSnet MyProg
        {
            get
            {
                return LTOOLSnet.ltoolsnet_0;
            }
        }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x06000152 RID: 338 RVA: 0x00016610 File Offset: 0x00014810
        public static ArrayList CopyFilePath
        {
            get
            {
                return LTOOLSnet.arrayList_0;
            }
        }

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x06000153 RID: 339 RVA: 0x00016624 File Offset: 0x00014824
        public static ArrayList CopyFileName
        {
            get
            {
                return LTOOLSnet.arrayList_1;
            }
        }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x06000154 RID: 340 RVA: 0x00016638 File Offset: 0x00014838
        public static ArrayList CopyFileSize
        {
            get
            {
                return LTOOLSnet.arrayList_2;
            }
        }

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x06000155 RID: 341 RVA: 0x0001664C File Offset: 0x0001484C
        public static ArrayList CopyFileDir
        {
            get
            {
                return LTOOLSnet.arrayList_4;
            }
        }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x06000156 RID: 342 RVA: 0x00016660 File Offset: 0x00014860
        public static ArrayList CopyFileDirPath
        {
            get
            {
                return LTOOLSnet.arrayList_3;
            }
        }

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x06000157 RID: 343 RVA: 0x000029A1 File Offset: 0x00000BA1
        public static bool CopyFileIsLinux
        {
            get
            {
                return LTOOLSnet.bool_8;
            }
        }

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x06000158 RID: 344 RVA: 0x000029A8 File Offset: 0x00000BA8
        // (set) Token: 0x06000159 RID: 345 RVA: 0x000029AF File Offset: 0x00000BAF
        public static bool CopyFileIsValid
        {
            get
            {
                return LTOOLSnet.bool_9;
            }
            set
            {
                LTOOLSnet.bool_9 = value;
            }
        }

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x0600015A RID: 346 RVA: 0x00016674 File Offset: 0x00014874
        public static int CopyFileCount
        {
            get
            {
                int result;
                if (LTOOLSnet.arrayList_0 == null)
                {
                    result = 0;
                }
                else
                {
                    result = LTOOLSnet.arrayList_0.Count;
                }
                return result;
            }
        }

        // Token: 0x17000025 RID: 37
        // (get) Token: 0x0600015B RID: 347 RVA: 0x000029B7 File Offset: 0x00000BB7
        public static bool ConfirmDelete
        {
            get
            {
                return LTOOLSnet.bool_0;
            }
        }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x0600015C RID: 348 RVA: 0x000029BE File Offset: 0x00000BBE
        // (set) Token: 0x0600015D RID: 349 RVA: 0x000029C5 File Offset: 0x00000BC5
        public static bool IsLinuxReadOnly
        {
            get
            {
                return LTOOLSnet.bool_1;
            }
            set
            {
                LTOOLSnet.bool_1 = value;
            }
        }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x0600015E RID: 350 RVA: 0x000029CD File Offset: 0x00000BCD
        // (set) Token: 0x0600015F RID: 351 RVA: 0x000029D4 File Offset: 0x00000BD4
        public static bool IsEncryptFile
        {
            get
            {
                return LTOOLSnet.bool_3;
            }
            set
            {
                LTOOLSnet.bool_3 = value;
            }
        }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000160 RID: 352 RVA: 0x000029DC File Offset: 0x00000BDC
        // (set) Token: 0x06000161 RID: 353 RVA: 0x000029E3 File Offset: 0x00000BE3
        public static bool IsViewEditFile
        {
            get
            {
                return LTOOLSnet.bool_2;
            }
            set
            {
                LTOOLSnet.bool_2 = value;
            }
        }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x06000162 RID: 354 RVA: 0x000166A0 File Offset: 0x000148A0
        public static Socket NetSocket
        {
            get
            {
                return LTOOLSnet.socket_0;
            }
        }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x06000163 RID: 355 RVA: 0x000029EB File Offset: 0x00000BEB
        public static bool Connected
        {
            get
            {
                return LTOOLSnet.bool_4;
            }
        }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x06000164 RID: 356 RVA: 0x000029F2 File Offset: 0x00000BF2
        // (set) Token: 0x06000165 RID: 357 RVA: 0x000029F9 File Offset: 0x00000BF9
        public static bool Debug
        {
            get
            {
                return LTOOLSnet.bool_5;
            }
            set
            {
                LTOOLSnet.bool_5 = value;
            }
        }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x06000166 RID: 358 RVA: 0x000166B4 File Offset: 0x000148B4
        public string Partitions
        {
            get
            {
                return this.string_0;
            }
        }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x06000167 RID: 359 RVA: 0x000166CC File Offset: 0x000148CC
        public static string DOSFilePattern
        {
            get
            {
                return LTOOLSnet.string_4;
            }
        }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x06000168 RID: 360 RVA: 0x000166E0 File Offset: 0x000148E0
        public static string LinuxFilePattern
        {
            get
            {
                return LTOOLSnet.string_5;
            }
        }

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000169 RID: 361 RVA: 0x000166F4 File Offset: 0x000148F4
        public static string GUIDirectory
        {
            get
            {
                return LTOOLSnet.string_3;
            }
        }

        // Token: 0x17000030 RID: 48
        // (get) Token: 0x0600016A RID: 362 RVA: 0x00016708 File Offset: 0x00014908
        // (set) Token: 0x0600016B RID: 363 RVA: 0x00002A01 File Offset: 0x00000C01
        public static string USBInfo
        {
            get
            {
                return LTOOLSnet.string_1;
            }
            set
            {
                LTOOLSnet.string_1 = value;
            }
        }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x0600016C RID: 364 RVA: 0x0001671C File Offset: 0x0001491C
        // (set) Token: 0x0600016D RID: 365 RVA: 0x00002A09 File Offset: 0x00000C09
        public static string HDB_No
        {
            get
            {
                return LTOOLSnet.string_2;
            }
            set
            {
                LTOOLSnet.string_2 = value;
            }
        }

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x0600016E RID: 366 RVA: 0x00002A11 File Offset: 0x00000C11
        // (set) Token: 0x0600016F RID: 367 RVA: 0x00002A18 File Offset: 0x00000C18
        public static bool CutSelected
        {
            get
            {
                return LTOOLSnet.bool_6;
            }
            set
            {
                LTOOLSnet.bool_6 = value;
            }
        }

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x06000170 RID: 368 RVA: 0x00002A20 File Offset: 0x00000C20
        // (set) Token: 0x06000171 RID: 369 RVA: 0x00002A27 File Offset: 0x00000C27
        public static bool IsLogined
        {
            get
            {
                return LTOOLSnet.bool_7;
            }
            set
            {
                LTOOLSnet.bool_7 = value;
            }
        }

        // Token: 0x17000034 RID: 52
        // (get) Token: 0x06000172 RID: 370 RVA: 0x00016730 File Offset: 0x00014930
        // (set) Token: 0x06000173 RID: 371 RVA: 0x00002A2F File Offset: 0x00000C2F
        public static string MAINMK
        {
            get
            {
                return LTOOLSnet.string_6;
            }
            set
            {
                LTOOLSnet.string_6 = value;
            }
        }

        // Token: 0x06000174 RID: 372 RVA: 0x00016744 File Offset: 0x00014944
        

        // Token: 0x06000175 RID: 373 RVA: 0x00002A37 File Offset: 0x00000C37
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000176 RID: 374 RVA: 0x00002A5C File Offset: 0x00000C5C
        private void LTOOLSnet_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.menuItem_13_Click(sender, e);
        }

        // Token: 0x06000177 RID: 375 RVA: 0x000022A9 File Offset: 0x000004A9
        private void LTOOLSnet_Resize(object sender, EventArgs e)
        {
        }

        // Token: 0x06000178 RID: 376 RVA: 0x000022A9 File Offset: 0x000004A9
        private void method_0(object sender, SplitterEventArgs e)
        {
        }

        // Token: 0x06000179 RID: 377 RVA: 0x00002A6D File Offset: 0x00000C6D
        private static void smethod_0(string string_7)
        {
            if (LTOOLSnet.bool_5 && LTOOLSnet.debugDialog != null)
            {
                LTOOLSnet.debugDialog.AppendText(string_7 + "\r\n");
            }
        }

        // Token: 0x0600017A RID: 378 RVA: 0x00016A1C File Offset: 0x00014C1C
        public static void SetCopyFilePath(ArrayList path, ArrayList name, ArrayList size, ArrayList dirpath, ArrayList dir, bool isLinux)
        {
            LTOOLSnet.bool_8 = isLinux;
            LTOOLSnet.arrayList_0 = null;
            LTOOLSnet.arrayList_0 = path;
            LTOOLSnet.arrayList_1 = null;
            LTOOLSnet.arrayList_1 = name;
            LTOOLSnet.arrayList_2 = null;
            LTOOLSnet.arrayList_2 = size;
            LTOOLSnet.arrayList_3 = null;
            LTOOLSnet.arrayList_3 = dirpath;
            LTOOLSnet.arrayList_4 = null;
            LTOOLSnet.arrayList_4 = dir;
            if (LTOOLSnet.CopyFileCount > 0)
            {
                LTOOLSnet.bool_9 = true;
            }
        }

        // Token: 0x0600017B RID: 379 RVA: 0x00016A80 File Offset: 0x00014C80
        public void ListViewItemFilesDelete()
        {
            LTOOLSnet.smethod_0("DeleteListViewItemFiles()");
            string text = "Select file or directory to delete in the listview.";
            string caption = "UTools";
            if (this.splitContainer1.ActiveControl == this.dosFilePanel)
            {
                LTOOLSnet.smethod_0("The DOSPanel is active.");
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.dosFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    this.dosFilePanel.DeleteDosFile(selectedListViewItemFile, LTOOLSnet.bool_0);
                }
                else
                {
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
            {
                LTOOLSnet.smethod_0("The USBPanel is active.");
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.linuxFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    this.linuxFilePanel.DeleteLinuxFile(selectedListViewItemFile, LTOOLSnet.bool_0);
                }
                else
                {
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                LTOOLSnet.smethod_0("No Panel is active.");
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            LTOOLSnet.bool_0 = true;
        }

        // Token: 0x0600017C RID: 380 RVA: 0x00016B68 File Offset: 0x00014D68
        public void ListViewItemFilesModify()
        {
            LTOOLSnet.smethod_0("ListViewItemFilesModify");
            string text = "Select file or directory to modify in the listview.";
            string caption = "UTools";
            if (this.splitContainer1.ActiveControl == this.dosFilePanel)
            {
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.dosFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    this.dosFilePanel.ModifyDosFile(selectedListViewItemFile);
                }
                else
                {
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
            {
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.linuxFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    this.linuxFilePanel.ModifyLinuxFile(selectedListViewItemFile);
                }
                else
                {
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Token: 0x0600017D RID: 381 RVA: 0x00016C20 File Offset: 0x00014E20
        public void ListViewItemFilesCopy()
        {
            LTOOLSnet.smethod_0("ListViewItemFilesCopy()");
            string caption = "UTools";
            LTOOLSnet.CopyFileIsValid = false;
            LTOOLSnet.bool_8 = false;
            LTOOLSnet.arrayList_1 = null;
            LTOOLSnet.arrayList_1 = new ArrayList();
            LTOOLSnet.arrayList_0 = null;
            LTOOLSnet.arrayList_0 = new ArrayList();
            LTOOLSnet.arrayList_2 = null;
            LTOOLSnet.arrayList_2 = new ArrayList();
            LTOOLSnet.arrayList_3 = null;
            LTOOLSnet.arrayList_3 = new ArrayList();
            LTOOLSnet.arrayList_4 = null;
            LTOOLSnet.arrayList_4 = new ArrayList();
            ListView.SelectedListViewItemCollection selectedListViewItemCollection = null;
            if (this.splitContainer1.ActiveControl == this.dosFilePanel)
            {
                selectedListViewItemCollection = this.dosFilePanel.GetSelectedListViewItemFile();
                LTOOLSnet.curDosNode = this.dosFilePanel.GetSelectedDirectoryNode();
                LTOOLSnet.bool_8 = false;
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
            {
                selectedListViewItemCollection = this.linuxFilePanel.GetSelectedListViewItemFile();
                LTOOLSnet.curLinuxNode = this.linuxFilePanel.GetSelectedDirectoryNode();
                LTOOLSnet.bool_8 = true;
            }
            if (selectedListViewItemCollection == null)
            {
                string text = "Chọn danh sách file(s) để copy.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                foreach (object obj in selectedListViewItemCollection)
                {
                    ListViewItemFile listViewItemFile = (ListViewItemFile)obj;
                    if (listViewItemFile.IsError)
                    {
                        LTOOLSnet.bool_9 = false;
                        return;
                    }
                    if (!listViewItemFile.FullFilePath.Equals(""))
                    {
                        if (listViewItemFile.IsDirectory)
                        {
                            if (!LTOOLSnet.bool_8)
                            {
                                long num = DCOPY.DirSize_files(listViewItemFile.FullFilePath) / 1000L;
                                string text2 = LTOOLSnet.USBInfo.Substring(12, LTOOLSnet.USBInfo.IndexOf("MB") - 12);
                                long num2 = Convert.ToInt64(text2.Substring(0, text2.IndexOf("."))) * 1000L;
                                if (num > num2 - 200000L)
                                {
                                    string text = "Dung lượng thư mục vượt quá dung lượng trống của USB!";
                                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    LTOOLSnet.bool_9 = false;
                                    return;
                                }
                                long num3 = DCOPY.DirCount_files(listViewItemFile.FullFilePath);
                                if (num3 >= 150L)
                                {
                                    string text = "Số lượng file trong thư mục quá nhiều!";
                                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    LTOOLSnet.bool_9 = false;
                                    return;
                                }
                                ArrayList arrayList = DCOPY.TraverseDOSTree(listViewItemFile.FullFilePath);
                                try{
                                    IEnumerator enumerator2 = arrayList.GetEnumerator();
                                    while (enumerator2.MoveNext())
                                    {
                                        object obj2 = enumerator2.Current;
                                        FileInfo fileInfo = (FileInfo)obj2;
                                        string value = fileInfo.DirectoryName.Replace(listViewItemFile.Directory, "");
                                        LTOOLSnet.arrayList_0.Add(fileInfo.FullName);
                                        LTOOLSnet.arrayList_1.Add(fileInfo.Name);
                                        LTOOLSnet.arrayList_2.Add(fileInfo.Length);
                                        LTOOLSnet.arrayList_3.Add(value);
                                        LTOOLSnet.arrayList_4.Add(listViewItemFile.FileName);
                                    }
                                    continue;
                                }
                                catch { }
                            }
                            string root = listViewItemFile.Directory + UMD5.ConvertStringToHex(listViewItemFile.FileName, Encoding.Unicode) + "/";
                            ArrayList filesLinuxTree = this.linuxFilePanel.GetFilesLinuxTree(root);
                            try{
                                IEnumerator enumerator2 = filesLinuxTree.GetEnumerator();                           
                                while (enumerator2.MoveNext())
                                {
                                    object obj3 = enumerator2.Current;
                                    ListViewItemFile listViewItemFile2 = (ListViewItemFile)obj3;
                                    string text3 = UMD5.ConvertHexToString(listViewItemFile2.FileName, Encoding.Unicode);
                                    string value2 = listViewItemFile2.Directory + text3;
                                    LTOOLSnet.arrayList_0.Add(value2);
                                    LTOOLSnet.arrayList_1.Add(text3);
                                    LTOOLSnet.arrayList_2.Add(listViewItemFile2.FileSize);
                                    string value = listViewItemFile2.Directory.Replace(listViewItemFile.Directory, "");
                                    LTOOLSnet.arrayList_3.Add(value);
                                    LTOOLSnet.arrayList_4.Add(listViewItemFile.FileName);
                                }
                                continue;
                            }
                            catch { }
                        }
                        if (listViewItemFile.IsLink)
                        {
                            LTOOLSnet.smethod_0("Link: " + listViewItemFile.FullFilePath + " ---- " + listViewItemFile.FileName);
                            LTOOLSnet.arrayList_0.Add(this.linuxFilePanel.GetFilePathFromLink(listViewItemFile.FullFilePath));
                            LTOOLSnet.arrayList_1.Add(this.linuxFilePanel.GetFileNameFromLink(listViewItemFile.FullFilePath));
                        }
                        else
                        {
                            LTOOLSnet.arrayList_0.Add(listViewItemFile.FullFilePath);
                            LTOOLSnet.arrayList_1.Add(listViewItemFile.FileName);
                            LTOOLSnet.arrayList_2.Add(listViewItemFile.FileSize);
                            LTOOLSnet.arrayList_3.Add("");
                            LTOOLSnet.arrayList_4.Add("");
                        }
                    }
                }
                if (LTOOLSnet.arrayList_0.Count > 0)
                {
                    LTOOLSnet.bool_9 = true;
                }
                else
                {
                    LTOOLSnet.bool_9 = false;
                }
            }
        }

        // Token: 0x0600017E RID: 382 RVA: 0x00017164 File Offset: 0x00015364
        public void ListViewItemFilesPaste()
        {
            LTOOLSnet.smethod_0("ListViewItemFilesPaste()");
            string caption = "UTools";
            if (!LTOOLSnet.bool_9)
            {
                string text = "Chưa chọn file để copy.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.splitContainer1.ActiveControl == this.dosFilePanel && this.dosFilePanel.GetSelectedDirectoryNode() != null)
            {
                string path = this.dosFilePanel.GetSelectedDirectoryNode().Path;
                this.dosFilePanel.PasteToDos(path, true);
                if (LTOOLSnet.bool_6)
                {
                    this.linuxFilePanel.UpdateLinuxListView(LTOOLSnet.curLinuxNode);
                }
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel && this.linuxFilePanel.GetSelectedDirectoryNode() != null)
            {
                string path = this.linuxFilePanel.GetSelectedDirectoryNode().Path;
                this.linuxFilePanel.PasteToLinux(path, true);
                if (LTOOLSnet.bool_6)
                {
                    this.dosFilePanel.UpdateDosListView(LTOOLSnet.curDosNode);
                }
            }
            else
            {
                string text = "Chọn thư mục để paste.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Token: 0x0600017F RID: 383 RVA: 0x00017274 File Offset: 0x00015474
        public void ListViewItemFilesView()
        {
            LTOOLSnet.smethod_0("ListViewItemFilesView");
            string text = "Select file to view";
            string caption = "UTools";
            if (!LTOOLSnet.bool_2)
            {
                MessageBox.Show("Không cho phép xem và sửa nội dung file!", caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.splitContainer1.ActiveControl == this.dosFilePanel)
            {
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.dosFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    //using (IEnumerator enumerator = selectedListViewItemFile.GetEnumerator())
                    //{
                    //    while (enumerator.MoveNext())
                    //    {
                    //        object obj = enumerator.Current;
                    //        ListViewItemFile item = (ListViewItemFile)obj;
                    //        this.dosFilePanel.StartDosApplication(item, false);
                    //    }
                    //    return;
                    //}
                    try
                    {
                        IEnumerator enumerator = selectedListViewItemFile.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            object obj = enumerator.Current;
                            ListViewItemFile item = (ListViewItemFile)obj;
                            this.dosFilePanel.StartDosApplication(item, false);
                        }
                        return;
                    }
                    catch { }
                }
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
            {
                ListView.SelectedListViewItemCollection selectedListViewItemFile = this.linuxFilePanel.GetSelectedListViewItemFile();
                if (selectedListViewItemFile != null)
                {
                    try{
                        IEnumerator enumerator = selectedListViewItemFile.GetEnumerator();
                    
                        while (enumerator.MoveNext())
                        {
                            object obj2 = enumerator.Current;
                            ListViewItemFile item = (ListViewItemFile)obj2;
                            this.linuxFilePanel.StartLinuxApplication(item, true);
                        }
                        return;
                    }
                    catch{ }
                }
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Token: 0x06000180 RID: 384 RVA: 0x000173DC File Offset: 0x000155DC
        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LTOOLSnet));
            this.mainMenu_0 = new MainMenu(this.icontainer_0);
            this.menuItem_0 = new MenuItem();
            this.menuItem_14 = new MenuItem();
            this.menuItem_22 = new MenuItem();
            this.menuItem_15 = new MenuItem();
            this.menuItem_12 = new MenuItem();
            this.menuItem_23 = new MenuItem();
            this.menuItem_16 = new MenuItem();
            this.menuItem_17 = new MenuItem();
            this.menuItem_25 = new MenuItem();
            this.menuItem_18 = new MenuItem();
            this.menuItem_19 = new MenuItem();
            this.menuItem_24 = new MenuItem();
            this.menuItem_26 = new MenuItem();
            this.menuItem_28 = new MenuItem();
            this.menuItem_29 = new MenuItem();
            this.menuItem_13 = new MenuItem();
            this.menuItem_1 = new MenuItem();
            this.menuItem_3 = new MenuItem();
            this.menuItem_4 = new MenuItem();
            this.menuItem_5 = new MenuItem();
            this.menuItem_6 = new MenuItem();
            this.menuItem_30 = new MenuItem();
            this.menuItem_7 = new MenuItem();
            this.menuItem_27 = new MenuItem();
            this.menuItem_2 = new MenuItem();
            this.menuItem_8 = new MenuItem();
            this.menuItem_20 = new MenuItem();
            this.menuItem_9 = new MenuItem();
            this.menuItem_10 = new MenuItem();
            this.menuItem_21 = new MenuItem();
            this.menuItem_11 = new MenuItem();
            this.imageList_0 = new ImageList(this.icontainer_0);
            this.panelToolbar = new Panel();
            this.toolBar = new ToolBar();
            this.toolBarButtonNew = new ToolBarButton();
            this.toolBarButtonModify = new ToolBarButton();
            this.toolBarButtonDelete = new ToolBarButton();
            this.toolBarButtonCopy = new ToolBarButton();
            this.toolBarButtonPaste = new ToolBarButton();
            this.toolBarButtonSeparator1 = new ToolBarButton();
            this.toolBarButtonReadOnly = new ToolBarButton();
            this.toolBarButtonEncrypt = new ToolBarButton();
            this.toolBarButtonPartitions = new ToolBarButton();
            this.toolBarButtonConnect = new ToolBarButton();
            this.toolBarButtonSeparator2 = new ToolBarButton();
            this.toolBarButtonConfirmDelete = new ToolBarButton();
            this.toolBarButtonSeparator3 = new ToolBarButton();
            this.toolBarButtonHelp = new ToolBarButton();
            this.toolBarButtonAbout = new ToolBarButton();
            this.toolBarButtonExit = new ToolBarButton();
            this.imageList_1 = new ImageList(this.icontainer_0);
            this.panelCenter = new Panel();
            this.splitContainer1 = new SplitContainer();
            this.picDOS = new PictureBox();
            this.lblCopy = new Label();
            this.panelButtons = new Panel();
            this.wWfFmYuNew = new ProgressBar();
            this.statusBar = new StatusBar();
            this.statusBarPanel0 = new StatusBarPanel();
            this.statusBarPanel1 = new StatusBarPanel();
            this.statusBarPanel2 = new StatusBarPanel();
            this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
            this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
            this.dosFilePanel = new DirFilePanel();
            this.linuxFilePanel = new DirFilePanel();
            this.panelToolbar.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((ISupportInitialize)this.picDOS).BeginInit();
            this.panelButtons.SuspendLayout();
            ((ISupportInitialize)this.statusBarPanel0).BeginInit();
            ((ISupportInitialize)this.statusBarPanel1).BeginInit();
            ((ISupportInitialize)this.statusBarPanel2).BeginInit();
            base.SuspendLayout();
            this.mainMenu_0.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_0,
                this.menuItem_1,
                this.menuItem_2
            });
            this.menuItem_0.Index = 0;
            this.menuItem_0.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_14,
                this.menuItem_22,
                this.menuItem_15,
                this.menuItem_12,
                this.menuItem_23,
                this.menuItem_16,
                this.menuItem_17,
                this.menuItem_25,
                this.menuItem_18,
                this.menuItem_19,
                this.menuItem_24,
                this.menuItem_26,
                this.menuItem_28,
                this.menuItem_29,
                this.menuItem_13
            });
            this.menuItem_0.Text = "&Hệ thống";
            this.menuItem_0.Select += this.menuItem_0_Select;
            this.menuItem_14.Index = 0;
            this.menuItem_14.Text = "Remote Connect ...";
            this.menuItem_14.Visible = false;
            this.menuItem_14.Click += this.menuItem_14_Click;
            this.menuItem_22.Index = 1;
            this.menuItem_22.Text = "-";
            this.menuItem_22.Visible = false;
            this.menuItem_15.Checked = true;
            this.menuItem_15.Index = 2;
            this.menuItem_15.Text = "USB read only";
            this.menuItem_15.Visible = false;
            this.menuItem_15.Click += this.menuItem_15_Click;
            this.menuItem_12.Checked = true;
            this.menuItem_12.Index = 3;
            this.menuItem_12.Text = "Confirm Delete";
            this.menuItem_12.Visible = false;
            this.menuItem_12.Click += this.menuItem_12_Click;
            this.menuItem_23.Index = 4;
            this.menuItem_23.Text = "-";
            this.menuItem_23.Visible = false;
            this.menuItem_16.Index = 5;
            this.menuItem_16.Text = "DOS Pattern ...";
            this.menuItem_16.Visible = false;
            this.menuItem_16.Click += this.menuItem_16_Click;
            this.menuItem_17.Index = 6;
            this.menuItem_17.Text = "Linux Pattern ...";
            this.menuItem_17.Visible = false;
            this.menuItem_17.Click += this.menuItem_17_Click;
            this.menuItem_25.Index = 7;
            this.menuItem_25.Text = "-";
            this.menuItem_25.Visible = false;
            this.menuItem_18.Index = 8;
            this.menuItem_18.Text = "Thêm thiết bị Windows";
            this.menuItem_18.Visible = false;
            this.menuItem_18.Click += this.menuItem_18_Click;
            this.menuItem_19.Index = 9;
            this.menuItem_19.Text = "Thêm thiết bị USB bảo mật";
            this.menuItem_19.Visible = false;
            this.menuItem_19.Click += this.menuItem_19_Click;
            this.menuItem_24.Index = 10;
            this.menuItem_24.Text = "-";
            this.menuItem_24.Visible = false;
            this.menuItem_26.Index = 11;
            this.menuItem_26.Text = "Format USB";
            this.menuItem_26.Click += this.menuItem_26_Click;
            this.menuItem_28.Index = 12;
            this.menuItem_28.Text = "Mã hóa file";
            this.menuItem_28.Visible = false;
            this.menuItem_28.Click += this.menuItem_28_Click;
            this.menuItem_29.Index = 13;
            this.menuItem_29.Text = "-";
            this.menuItem_13.Index = 14;
            this.menuItem_13.Text = "Thoát";
            this.menuItem_13.Click += this.menuItem_13_Click;
            this.menuItem_1.Index = 1;
            this.menuItem_1.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_3,
                this.menuItem_4,
                this.menuItem_5,
                this.menuItem_6,
                this.menuItem_30,
                this.menuItem_7,
                this.menuItem_27
            });
            this.menuItem_1.Text = "&Thao tác";
            this.menuItem_3.Index = 0;
            this.menuItem_3.Text = "Mới";
            this.menuItem_3.Click += this.menuItem_3_Click;
            this.menuItem_4.Index = 1;
            this.menuItem_4.Text = "Đổi tên";
            this.menuItem_4.Click += this.menuItem_4_Click;
            this.menuItem_5.Index = 2;
            this.menuItem_5.Text = "Xóa";
            this.menuItem_5.Click += this.menuItem_5_Click;
            this.menuItem_6.Index = 3;
            this.menuItem_6.Shortcut = Shortcut.CtrlC;
            this.menuItem_6.Text = "Sao chép";
            this.menuItem_6.Click += this.menuItem_6_Click;
            this.menuItem_30.Index = 4;
            this.menuItem_30.Text = "Cắt";
            this.menuItem_30.Visible = false;
            this.menuItem_30.Click += this.menuItem_30_Click;
            this.menuItem_7.Index = 5;
            this.menuItem_7.Shortcut = Shortcut.CtrlV;
            this.menuItem_7.Text = "Dán";
            this.menuItem_7.Click += this.menuItem_7_Click;
            this.menuItem_27.Index = 6;
            this.menuItem_27.Text = "Reresh";
            this.menuItem_27.Click += this.menuItem_27_Click;
            this.menuItem_2.Index = 2;
            this.menuItem_2.MenuItems.AddRange(new MenuItem[]
            {
                this.menuItem_8,
                this.menuItem_20,
                this.menuItem_9,
                this.menuItem_10,
                this.menuItem_21,
                this.menuItem_11
            });
            this.menuItem_2.Text = "&Giới thiệu";
            this.menuItem_2.Select += this.menuItem_2_Select;
            this.menuItem_8.Index = 0;
            this.menuItem_8.Text = "Thông tin USB";
            this.menuItem_8.Visible = false;
            this.menuItem_8.Click += this.menuItem_8_Click;
            this.menuItem_20.Index = 1;
            this.menuItem_20.Text = "-";
            this.menuItem_20.Visible = false;
            this.menuItem_9.Index = 2;
            this.menuItem_9.Text = "DebugDialog ...";
            this.menuItem_9.Visible = false;
            this.menuItem_9.Click += this.menuItem_9_Click;
            this.menuItem_10.Index = 3;
            this.menuItem_10.Text = "Help ...";
            this.menuItem_10.Visible = false;
            this.menuItem_10.Click += this.menuItem_10_Click;
            this.menuItem_21.Index = 4;
            this.menuItem_21.Text = "-";
            this.menuItem_21.Visible = false;
            this.menuItem_11.Index = 5;
            this.menuItem_11.Text = "Giới thiệu";
            this.menuItem_11.Click += this.menuItem_11_Click;
            this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("toolbarImageList.ImageStream");
            this.imageList_0.TransparentColor = Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "");
            this.imageList_0.Images.SetKeyName(1, "");
            this.imageList_0.Images.SetKeyName(2, "");
            this.imageList_0.Images.SetKeyName(3, "");
            this.imageList_0.Images.SetKeyName(4, "");
            this.imageList_0.Images.SetKeyName(5, "");
            this.imageList_0.Images.SetKeyName(6, "");
            this.imageList_0.Images.SetKeyName(7, "");
            this.imageList_0.Images.SetKeyName(8, "");
            this.imageList_0.Images.SetKeyName(9, "");
            this.imageList_0.Images.SetKeyName(10, "");
            this.imageList_0.Images.SetKeyName(11, "");
            this.imageList_0.Images.SetKeyName(12, "");
            this.imageList_0.Images.SetKeyName(13, "");
            this.imageList_0.Images.SetKeyName(14, "");
            this.imageList_0.Images.SetKeyName(15, "local security policy.ico");
            this.panelToolbar.Controls.Add(this.toolBar);
            this.panelToolbar.Dock = DockStyle.Top;
            this.panelToolbar.Location = new Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new Size(994, 10);
            this.panelToolbar.TabIndex = 1;
            this.toolBar.Appearance = ToolBarAppearance.Flat;
            this.toolBar.Buttons.AddRange(new ToolBarButton[]
            {
                this.toolBarButtonNew,
                this.toolBarButtonModify,
                this.toolBarButtonDelete,
                this.toolBarButtonCopy,
                this.toolBarButtonPaste,
                this.toolBarButtonSeparator1,
                this.toolBarButtonReadOnly,
                this.toolBarButtonEncrypt,
                this.toolBarButtonPartitions,
                this.toolBarButtonConnect,
                this.toolBarButtonSeparator2,
                this.toolBarButtonConfirmDelete,
                this.toolBarButtonSeparator3,
                this.toolBarButtonHelp,
                this.toolBarButtonAbout,
                this.toolBarButtonExit
            });
            this.toolBar.ButtonSize = new Size(60, 40);
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.imageList_1;
            this.toolBar.Location = new Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new Size(994, 42);
            this.toolBar.TabIndex = 1;
            this.toolBar.Visible = false;
            this.toolBar.ButtonClick += this.toolBar_ButtonClick;
            this.toolBarButtonNew.ImageIndex = 0;
            this.toolBarButtonNew.Name = "toolBarButtonNew";
            this.toolBarButtonNew.Text = "Tạo";
            this.toolBarButtonNew.ToolTipText = "New";
            this.toolBarButtonModify.ImageIndex = 1;
            this.toolBarButtonModify.Name = "toolBarButtonModify";
            this.toolBarButtonModify.Text = "Sửa tên";
            this.toolBarButtonModify.ToolTipText = "Modify";
            this.toolBarButtonDelete.ImageIndex = 2;
            this.toolBarButtonDelete.Name = "toolBarButtonDelete";
            this.toolBarButtonDelete.Text = "Xóa";
            this.toolBarButtonDelete.ToolTipText = "Delete";
            this.toolBarButtonCopy.ImageIndex = 3;
            this.toolBarButtonCopy.Name = "toolBarButtonCopy";
            this.toolBarButtonCopy.Text = "Sao chép";
            this.toolBarButtonCopy.ToolTipText = "Copy";
            this.toolBarButtonPaste.ImageIndex = 4;
            this.toolBarButtonPaste.Name = "toolBarButtonPaste";
            this.toolBarButtonPaste.Text = "Dán";
            this.toolBarButtonPaste.ToolTipText = "Paste";
            this.toolBarButtonSeparator1.Name = "toolBarButtonSeparator1";
            this.toolBarButtonSeparator1.Style = ToolBarButtonStyle.Separator;
            this.toolBarButtonReadOnly.ImageIndex = 7;
            this.toolBarButtonReadOnly.Name = "toolBarButtonReadOnly";
            this.toolBarButtonReadOnly.Style = ToolBarButtonStyle.ToggleButton;
            this.toolBarButtonReadOnly.Text = "Mã file";
            this.toolBarButtonReadOnly.ToolTipText = "Encrypt File";
            this.toolBarButtonReadOnly.Visible = false;
            this.toolBarButtonEncrypt.ImageIndex = 7;
            this.toolBarButtonEncrypt.Name = "toolBarButtonEncrypt";
            this.toolBarButtonEncrypt.Style = ToolBarButtonStyle.ToggleButton;
            this.toolBarButtonEncrypt.Text = "Mã file";
            this.toolBarButtonEncrypt.ToolTipText = "Encrypt File";
            this.toolBarButtonEncrypt.Visible = false;
            this.toolBarButtonPartitions.ImageIndex = 5;
            this.toolBarButtonPartitions.Name = "toolBarButtonPartitions";
            this.toolBarButtonPartitions.Text = "Partitions";
            this.toolBarButtonPartitions.ToolTipText = "Partitions";
            this.toolBarButtonPartitions.Visible = false;
            this.toolBarButtonConnect.ImageIndex = 8;
            this.toolBarButtonConnect.Name = "toolBarButtonConnect";
            this.toolBarButtonConnect.Text = "Connect";
            this.toolBarButtonConnect.ToolTipText = "Connect";
            this.toolBarButtonConnect.Visible = false;
            this.toolBarButtonSeparator2.Name = "toolBarButtonSeparator2";
            this.toolBarButtonSeparator2.Style = ToolBarButtonStyle.Separator;
            this.toolBarButtonSeparator2.Visible = false;
            this.toolBarButtonConfirmDelete.ImageIndex = 13;
            this.toolBarButtonConfirmDelete.Name = "toolBarButtonConfirmDelete";
            this.toolBarButtonConfirmDelete.Style = ToolBarButtonStyle.ToggleButton;
            this.toolBarButtonConfirmDelete.Text = "Xác nhận";
            this.toolBarButtonConfirmDelete.ToolTipText = "Confirm Delete";
            this.toolBarButtonConfirmDelete.Visible = false;
            this.toolBarButtonSeparator3.Name = "toolBarButtonSeparator3";
            this.toolBarButtonSeparator3.Style = ToolBarButtonStyle.Separator;
            this.toolBarButtonSeparator3.Visible = false;
            this.toolBarButtonHelp.ImageIndex = 6;
            this.toolBarButtonHelp.Name = "toolBarButtonHelp";
            this.toolBarButtonHelp.Text = "Help";
            this.toolBarButtonHelp.ToolTipText = "Help";
            this.toolBarButtonHelp.Visible = false;
            this.toolBarButtonAbout.ImageIndex = 5;
            this.toolBarButtonAbout.Name = "toolBarButtonAbout";
            this.toolBarButtonAbout.Text = "Giới thiệu";
            this.toolBarButtonAbout.ToolTipText = "About";
            this.toolBarButtonAbout.Visible = false;
            this.toolBarButtonExit.ImageIndex = 6;
            this.toolBarButtonExit.Name = "toolBarButtonExit";
            this.toolBarButtonExit.Text = "Thoát";
            this.toolBarButtonExit.ToolTipText = "Exit";
            this.imageList_1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("toolbarImageList1.ImageStream");
            this.imageList_1.TransparentColor = Color.Transparent;
            this.imageList_1.Images.SetKeyName(0, "new.ico");
            this.imageList_1.Images.SetKeyName(1, "settings.ico");
            this.imageList_1.Images.SetKeyName(2, "deletered.ico");
            this.imageList_1.Images.SetKeyName(3, "copy.ico");
            this.imageList_1.Images.SetKeyName(4, "paste.png");
            this.imageList_1.Images.SetKeyName(5, "about.png");
            this.imageList_1.Images.SetKeyName(6, "exit.png");
            this.imageList_1.Images.SetKeyName(7, "lock_key.png");
            this.panelCenter.Controls.Add(this.splitContainer1);
            this.panelCenter.Controls.Add(this.lblCopy);
            this.panelCenter.Controls.Add(this.panelButtons);
            this.panelCenter.Dock = DockStyle.Fill;
            this.panelCenter.Location = new Point(0, 10);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new Size(994, 590);
            this.panelCenter.TabIndex = 2;
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.picDOS);
            this.splitContainer1.Panel1.Controls.Add(this.dosFilePanel);
            this.splitContainer1.Panel2.Controls.Add(this.linuxFilePanel);
            this.splitContainer1.Size = new Size(994, 567);
            this.splitContainer1.SplitterDistance = 537;
            this.splitContainer1.TabIndex = 3;
            this.picDOS.BackColor = SystemColors.HotTrack;
            this.picDOS.Image = (Image)componentResourceManager.GetObject("picDOS.Image");
            this.picDOS.Location = new Point(0, 0);
            this.picDOS.Name = "picDOS";
            this.picDOS.Size = new Size(26, 24);
            this.picDOS.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picDOS.TabIndex = 8;
            this.picDOS.TabStop = false;
            this.lblCopy.BackColor = SystemColors.ButtonFace;
            this.lblCopy.BorderStyle = BorderStyle.Fixed3D;
            this.lblCopy.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCopy.ForeColor = Color.FromArgb(0, 0, 192);
            this.lblCopy.Location = new Point(303, 313);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new Size(339, 29);
            this.lblCopy.TabIndex = 39;
            this.lblCopy.Text = "Đang xử lý dữ liệu...";
            this.lblCopy.TextAlign = ContentAlignment.MiddleCenter;
            this.lblCopy.Visible = false;
            this.panelButtons.BackColor = SystemColors.Control;
            this.panelButtons.Controls.Add(this.wWfFmYuNew);
            this.panelButtons.Controls.Add(this.statusBar);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new Point(0, 567);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(994, 23);
            this.panelButtons.TabIndex = 0;
            this.wWfFmYuNew.BackColor = Color.Azure;
            this.wWfFmYuNew.ForeColor = Color.Blue;
            this.wWfFmYuNew.Location = new Point(0, 2);
            this.wWfFmYuNew.Maximum = 50;
            this.wWfFmYuNew.Name = "progressBar1";
            this.wWfFmYuNew.Size = new Size(244, 18);
            this.wWfFmYuNew.TabIndex = 3;
            this.wWfFmYuNew.Visible = false;
            this.statusBar.Location = new Point(0, 1);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new StatusBarPanel[]
            {
                this.statusBarPanel0,
                this.statusBarPanel1,
                this.statusBarPanel2
            });
            this.statusBar.RightToLeft = RightToLeft.No;
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new Size(994, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.PanelClick += this.statusBar_PanelClick;
            this.statusBarPanel0.Name = "statusBarPanel0";
            this.statusBarPanel0.Width = 298;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 400;
            this.statusBarPanel2.Alignment = HorizontalAlignment.Right;
            this.statusBarPanel2.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 279;
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 15000;
            this.timer_0.Tick += this.timer_0_Tick;
            this.timer_1.Interval = 1000;
            this.timer_1.Tick += this.timer_1_Tick;
            this.dosFilePanel.AllowDrop = true;
            this.dosFilePanel.Dock = DockStyle.Fill;
            this.dosFilePanel.IsLinux = false;
            this.dosFilePanel.Location = new Point(0, 0);
            this.dosFilePanel.Name = "dosFilePanel";
            this.dosFilePanel.Size = new Size(537, 567);
            this.dosFilePanel.TabIndex = 3;
            this.dosFilePanel.ViewListView = View.Details;
            this.dosFilePanel.Load += this.dosFilePanel_Load;
            this.linuxFilePanel.AllowDrop = true;
            this.linuxFilePanel.Dock = DockStyle.Fill;
            this.linuxFilePanel.IsLinux = false;
            this.linuxFilePanel.Location = new Point(0, 0);
            this.linuxFilePanel.Name = "linuxFilePanel";
            this.linuxFilePanel.Size = new Size(453, 567);
            this.linuxFilePanel.TabIndex = 4;
            this.linuxFilePanel.ViewListView = View.Details;
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.ClientSize = new Size(994, 600);
            base.Controls.Add(this.panelCenter);
            base.Controls.Add(this.panelToolbar);
            base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.Menu = this.mainMenu_0;
            this.MinimumSize = new Size(630, 638);
            base.Name = "LTOOLSnet";
            base.SizeGripStyle = SizeGripStyle.Show;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "USB - AT (Version 2.0)";
            base.Closing += this.LTOOLSnet_Closing;
            base.Resize += this.LTOOLSnet_Resize;
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((ISupportInitialize)this.picDOS).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((ISupportInitialize)this.statusBarPanel0).EndInit();
            ((ISupportInitialize)this.statusBarPanel1).EndInit();
            ((ISupportInitialize)this.statusBarPanel2).EndInit();
            base.ResumeLayout(false);
        }

        // Token: 0x06000181 RID: 385 RVA: 0x00002A98 File Offset: 0x00000C98
        private void menuItem_2_Select(object sender, EventArgs e)
        {
            if (LTOOLSnet.bool_5)
            {
                if (LTOOLSnet.debugDialog.Visible)
                {
                    this.menuItem_9.Checked = true;
                }
                else
                {
                    this.menuItem_9.Checked = false;
                }
            }
        }

        // Token: 0x06000182 RID: 386 RVA: 0x00002ACD File Offset: 0x00000CCD
        private void menuItem_0_Select(object sender, EventArgs e)
        {
            this.menuItem_15.Checked = LTOOLSnet.bool_1;
            this.menuItem_12.Checked = LTOOLSnet.bool_0;
        }

        // Token: 0x06000183 RID: 387 RVA: 0x00018F28 File Offset: 0x00017128
        private void menuItem_14_Click(object sender, EventArgs e)
        {
            if (LTOOLSnet.bool_4)
            {
                LTOOLSnet.smethod_2();
                if (!LTOOLSnet.bool_4)
                {
                    this.Text = "USB-AT (Version 2.0)";
                    this.menuItem_14.Text = "Remote Connect ...";
                    this.toolBarButtonConnect.Text = "Connect";
                    this.toolBarButtonConnect.ToolTipText = "Connect";
                    this.toolBarButtonConnect.ImageIndex--;
                    this.linuxFilePanel.FillLinuxDirectoryTree();
                    this.linuxFilePanel.SetBackground(this.dosFilePanel.GetBackColorTreeView());
                    this.string_0 = "";
                }
            }
            else
            {
                if (LTOOLSnet.remoteBoxDialog_0 == null)
                {
                    LTOOLSnet.remoteBoxDialog_0 = new RemoteBoxDialog(LTOOLSnet.remoteHost_0);
                }
                if (LTOOLSnet.remoteBoxDialog_0.ShowDialog() != DialogResult.Cancel)
                {
                    LTOOLSnet.remoteHost_0 = LTOOLSnet.remoteBoxDialog_0.RemoteServer;
                    LTOOLSnet.smethod_1();
                    LTOOLSnet.bool_4 = LTOOLSnet.socket_0.Connected;
                    LTOOLSnet.smethod_0("connected: " + LTOOLSnet.bool_4.ToString());
                    if (LTOOLSnet.bool_4)
                    {
                        this.Text = "USB-AT (Version 2.0) connected to " + LTOOLSnet.remoteHost_0.Host;
                        this.menuItem_14.Text = "Remote disconnect";
                        this.toolBarButtonConnect.Text = "Disconnect";
                        this.toolBarButtonConnect.ToolTipText = "Disconnect";
                        this.toolBarButtonConnect.ImageIndex++;
                        this.linuxFilePanel.FillLinuxDirectoryTree();
                        this.linuxFilePanel.SetBackground(LTOOLSnet.color_0);
                        this.string_0 = "";
                    }
                }
            }
        }

        // Token: 0x06000184 RID: 388 RVA: 0x00002AEF File Offset: 0x00000CEF
        private void menuItem_15_Click(object sender, EventArgs e)
        {
            this.menuItem_15.Checked = !this.menuItem_15.Checked;
            LTOOLSnet.IsLinuxReadOnly = this.menuItem_15.Checked;
        }

        // Token: 0x06000185 RID: 389 RVA: 0x00002B1A File Offset: 0x00000D1A
        private void menuItem_12_Click(object sender, EventArgs e)
        {
            this.menuItem_12.Checked = !this.menuItem_12.Checked;
            LTOOLSnet.bool_0 = this.menuItem_12.Checked;
        }

        // Token: 0x06000186 RID: 390 RVA: 0x000190D0 File Offset: 0x000172D0
        private void menuItem_16_Click(object sender, EventArgs e)
        {
            FilePatternDialog filePatternDialog = new FilePatternDialog(LTOOLSnet.DOSFilePattern, false);
            if (filePatternDialog.ShowDialog() == DialogResult.OK)
            {
                LTOOLSnet.string_4 = filePatternDialog.FilePattern;
                this.dosFilePanel.UpdateDosListView(this.dosFilePanel.GetSelectedDirectoryNode());
            }
        }

        // Token: 0x06000187 RID: 391 RVA: 0x00019118 File Offset: 0x00017318
        private void menuItem_17_Click(object sender, EventArgs e)
        {
            FilePatternDialog filePatternDialog = new FilePatternDialog(LTOOLSnet.LinuxFilePattern, true);
            if (filePatternDialog.ShowDialog() == DialogResult.OK)
            {
                LTOOLSnet.string_5 = filePatternDialog.FilePattern;
                DirectoryNode selectedDirectoryNode = this.linuxFilePanel.GetSelectedDirectoryNode();
                if (selectedDirectoryNode != null)
                {
                    this.linuxFilePanel.UpdateLinuxListView(selectedDirectoryNode);
                }
            }
        }

        // Token: 0x06000188 RID: 392 RVA: 0x00002B45 File Offset: 0x00000D45
        private void menuItem_18_Click(object sender, EventArgs e)
        {
            this.dosFilePanel.MenuItemTreeViewAddDrive_Click(sender, e);
        }

        // Token: 0x06000189 RID: 393 RVA: 0x00002B54 File Offset: 0x00000D54
        private void menuItem_19_Click(object sender, EventArgs e)
        {
            this.linuxFilePanel.MenuItemTreeViewAddDrive_Click(sender, e);
        }

        // Token: 0x0600018A RID: 394 RVA: 0x00019168 File Offset: 0x00017368
        private void menuItem_13_Click(object sender, EventArgs e)
        {
            if (this.wWfFmYuNew.Visible)
            {
                MessageBox.Show("Chương trình đang xử lý dữ liệu, vui lòng chờ.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = "zzz.tmp";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (LTOOLSnet.bool_2)
                {
                    this.linuxFilePanel.UpdateOpenedFiles(this.linuxFilePanel.m_OpenedFiles);
                }
                if (LTOOLSnet.bool_4)
                {
                    LTOOLSnet.smethod_2();
                }
                if (Directory.Exists(DirFilePanel.tempPathLinuxFiles))
                {
                    try
                    {
                        Directory.Delete(DirFilePanel.tempPathLinuxFiles, true);
                    }
                    catch
                    {
                    }
                }
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
                base.Dispose();
            }
        }

        // Token: 0x0600018B RID: 395 RVA: 0x0001927C File Offset: 0x0001747C
        private void menuItem_3_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "Chọn thư mục chứa đối tượng tạo mới.";
                string caption = "UTools";
                if (this.splitContainer1.ActiveControl == this.dosFilePanel)
                {
                    DirectoryNode selectedDirectoryNode;
                    if ((selectedDirectoryNode = this.dosFilePanel.GetSelectedDirectoryNode()) != null)
                    {
                        this.dosFilePanel.NewDosDirectory(selectedDirectoryNode);
                    }
                    else
                    {
                        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
                {
                    DirectoryNode selectedDirectoryNode;
                    if ((selectedDirectoryNode = this.linuxFilePanel.GetSelectedDirectoryNode()) != null)
                    {
                        this.linuxFilePanel.NewLinuxDirectory(selectedDirectoryNode);
                    }
                    else
                    {
                        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                LTOOLSnet.smethod_0(ex.Message);
            }
        }

        // Token: 0x0600018C RID: 396 RVA: 0x00002B63 File Offset: 0x00000D63
        private void menuItem_4_Click(object sender, EventArgs e)
        {
            this.ListViewItemFilesModify();
        }

        // Token: 0x0600018D RID: 397 RVA: 0x00002B6B File Offset: 0x00000D6B
        private void menuItem_5_Click(object sender, EventArgs e)
        {
            this.ListViewItemFilesDelete();
        }

        // Token: 0x0600018E RID: 398 RVA: 0x00002B73 File Offset: 0x00000D73
        private void menuItem_6_Click(object sender, EventArgs e)
        {
            this.ListViewItemFilesCopy();
        }

        // Token: 0x0600018F RID: 399 RVA: 0x00002B7B File Offset: 0x00000D7B
        private void menuItem_7_Click(object sender, EventArgs e)
        {
            this.ListViewItemFilesPaste();
            LTOOLSnet.bool_6 = false;
        }

        // Token: 0x06000190 RID: 400 RVA: 0x0001934C File Offset: 0x0001754C
        private void menuItem_8_Click(object sender, EventArgs e)
        {
            if (this.Partitions.Equals(""))
            {
                if (LTOOLSnet.bool_4)
                {
                    ULDir uldir = new ULDir("ucom", "-x -part", LTOOLSnet.NetSocket);
                    this.string_0 = uldir.GetPartitions();
                }
                else
                {
                    ULDir uldir = new ULDir("ucom", "-part");
                    this.string_0 = uldir.GetPartitions();
                }
            }
            StringBuilder stringBuilder = new StringBuilder("USBTOOLS Partitions");
            if (LTOOLSnet.bool_4)
            {
                stringBuilder.Append(" - " + LTOOLSnet.remoteHost_0.Host);
            }
            else
            {
                stringBuilder.Append(" - " + Environment.MachineName);
            }
            PartitionsDialog partitionsDialog = new PartitionsDialog(LTOOLSnet.USBInfo, stringBuilder.ToString());
            partitionsDialog.ShowDialog();
        }

        // Token: 0x06000191 RID: 401 RVA: 0x00002B89 File Offset: 0x00000D89
        private void menuItem_10_Click(object sender, EventArgs e)
        {
            if (LTOOLSnet.helpBox_0 == null)
            {
                LTOOLSnet.helpBox_0 = new HelpBox(false, LTOOLSnet.string_3);
            }
            else
            {
                LTOOLSnet.helpBox_0.Visible = true;
            }
        }

        // Token: 0x06000192 RID: 402 RVA: 0x00019418 File Offset: 0x00017618
        private void menuItem_11_Click(object sender, EventArgs e)
        {
            string text = "USB an toàn - Phiên bản 2.0";
            MessageBox.Show(text, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Token: 0x06000193 RID: 403 RVA: 0x00002BB5 File Offset: 0x00000DB5
        private void menuItem_9_Click(object sender, EventArgs e)
        {
            LTOOLSnet.debugDialog.Visible = !LTOOLSnet.debugDialog.Visible;
            this.menuItem_9.Checked = !this.menuItem_9.Checked;
        }

        // Token: 0x06000194 RID: 404 RVA: 0x0001943C File Offset: 0x0001763C
        private string method_1(string string_7)
        {
            StreamReader streamReader = new StreamReader(string_7);
            string result = streamReader.ReadToEnd();
            streamReader.Close();
            return result;
        }

        // Token: 0x06000195 RID: 405 RVA: 0x00019468 File Offset: 0x00017668
        private void menuItem_26_Click(object sender, EventArgs e)
        {
            string this_U = usbpublic.THIS_U;
            int num = 0;
            int num2 = 0;
            string text = Application.StartupPath.ToString() + "\\conf.ini";
            if (File.Exists(text))
            {
                this.method_1(text);
                string[] array = this.method_1(text).Split(new char[]
                {
                    ','
                });
                num = Convert.ToInt32(array[1].ToString());
                num2 = Convert.ToInt32(array[3].ToString());
            }
            if (MessageBox.Show("Format USB sẽ mất hết dữ liệu trong USB.\nBạn có chắc chắn không?", "UTools", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.timer_0.Enabled = false;
                string path = "zzz.tmp";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                if (Directory.Exists(DirFilePanel.tempPathLinuxFiles))
                {
                    string[] files = Directory.GetFiles(DirFilePanel.tempPathLinuxFiles);
                    foreach (string text2 in files)
                    {
                        LTOOLSnet.smethod_0("delete file: " + text2);
                        File.Delete(text2);
                    }
                }
                try
                {
                    byte[] array3 = new byte[5120];
                    for (int j = 0; j < array3.Length; j++)
                    {
                        array3[j] = 0;
                    }
                    int num3 = 10000;
                    this.wWfFmYuNew.Visible = true;
                    DISK.streamer iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                    int num4;
                    for (int j = 0; j < num3 / 10; j++)
                    {
                        num4 = DISK.smethod_0((long)(j * 10 + 10), 5120, array3, iface);
                    }
                    DISK.DropStream(iface);
                    string fileName = Application.StartupPath + "\\raw0.bin";
                    byte[] data = UMD5.ReadFileToByteArray(fileName);
                    iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                    num4 = DISK.smethod_0(0L, 102400, data, iface);
                    DISK.DropStream(iface);
                    fileName = Application.StartupPath + "\\raw1.bin";
                    byte[] data2 = UMD5.ReadFileToByteArray(fileName);
                    iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                    num4 = DISK.smethod_0((long)num2, 76800, data2, iface);
                    DISK.DropStream(iface);
                    byte[] array4 = new byte[4608000];
                    for (int j = 0; j < array4.Length; j++)
                    {
                        array4[j] = 0;
                    }
                    fileName = Application.StartupPath + "\\raw2.bin";
                    byte[] data3 = UMD5.ReadFileToByteArray(fileName);
                    iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                    this.wWfFmYuNew.Maximum = num;
                    this.wWfFmYuNew.Step = 1;
                    this.wWfFmYuNew.Value = 1;
                    this.statusBarPanel1.Text = "Formatting...";
                    for (int k = 1; k <= num; k++)
                    {
                        Application.DoEvents();
                        num4 = DISK.smethod_0((long)(63 + k * 262144), 4608000, array4, iface);
                        num4 = DISK.smethod_0((long)(63 + k * 262144), 51200, data3, iface);
                        this.wWfFmYuNew.PerformStep();
                    }
                    DISK.DropStream(iface);
                    byte[] u_HEADER = UMD5.U_HEADER;
                    string strPassword = UMD5.GenerateID();
                    byte[] array5 = UMD5.smethod_2(strPassword);
                    byte[] array6 = new byte[512];
                    for (int j = 0; j <= u_HEADER.Length - 1; j++)
                    {
                        array6[j] = u_HEADER[j];
                    }
                    for (int j = 0; j <= array5.Length - 1; j++)
                    {
                        array6[j + u_HEADER.Length] = array5[j];
                    }
                    byte[] bytes = Encoding.ASCII.GetBytes(UMD5.RandomString(512 - u_HEADER.Length - array5.Length));
                    for (int j = 0; j <= bytes.Length - 1; j++)
                    {
                        array6[j + u_HEADER.Length + array5.Length] = bytes[j];
                    }
                    iface = DISK.CreateStream(this_U, FileAccess.ReadWrite);
                    num4 = DISK.smethod_0(11L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num4 = DISK.smethod_0(12L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num4 = DISK.smethod_0(13L, 512, array6, iface);
                    num4 = DISK.smethod_0(14L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    num4 = DISK.smethod_0(15L, 512, Encoding.ASCII.GetBytes(UMD5.RandomString(512)), iface);
                    byte[] bytes2 = Encoding.ASCII.GetBytes(UMD5.RandomString(512));
                    for (int j = 0; j <= u_HEADER.Length - 1; j++)
                    {
                        bytes2[j] = u_HEADER[j];
                    }
                    bytes2[u_HEADER.Length + 1] = Convert.ToByte(55);
                    num4 = DISK.smethod_0(16L, 512, bytes2, iface);
                    num4 = DISK.smethod_0(17L, 512, bytes2, iface);
                    num4 = DISK.smethod_0(18L, 512, bytes2, iface);
                    num4 = DISK.smethod_0(19L, 512, bytes2, iface);
                    num4 = DISK.smethod_0(20L, 512, bytes2, iface);
                    if (num4 == -1)
                    {
                        MessageBox.Show("Format USB không thành công!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    DISK.DropStream(iface);
                    usbpublic.KEY_FORMAT = DISK.READ_FKEY_FromUSB();
                    this.method_2("Data");
                    this.method_3("Data");
                    this.linuxFilePanel.FillLinuxDirectoryTree();
                    this.timer_0.Enabled = true;
                    if (num4 == 0)
                    {
                        MessageBox.Show("Format USB thành công!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.linuxFilePanel.FillLinuxDirectoryTree();
                        this.wWfFmYuNew.Visible = false;
                        return;
                    }
                    MessageBox.Show("Lỗi format USB!", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.wWfFmYuNew.Visible = false;
                    return;
                }
                catch
                {
                    this.wWfFmYuNew.Visible = false;
                    return;
                }
            }
            this.wWfFmYuNew.Visible = false;
        }

        // Token: 0x06000196 RID: 406 RVA: 0x00019AA0 File Offset: 0x00017CA0
        private void method_2(string string_7)
        {
            try
            {
                string text = "/" + UMD5.ConvertStringToHex(string_7, Encoding.Unicode);
                string command = "ucom";
                string args = string.Concat(new string[]
                {
                    "-WRITE -del -q -s",
                    LTOOLSnet.HDB_No,
                    " \"",
                    text,
                    "\""
                });
                new ULDir(command, args);
            }
            catch
            {
            }
        }

        // Token: 0x06000197 RID: 407 RVA: 0x00019B1C File Offset: 0x00017D1C
        private void method_3(string string_7)
        {
            try
            {
                string str = "/" + UMD5.ConvertStringToHex(string_7, Encoding.Unicode);
                string text = "-WRITE -mkdir -q -s/dev/hdb1 -f777 -g0 -u0 ldirtmpl \"" + str + "\"";
                string text2 = "ucom";
                LTOOLSnet.smethod_0(text2 + " " + text);
                ULDir uldir = new ULDir(text2, text);
                LTOOLSnet.smethod_0("NewUSBDirectory:" + uldir.Response + "<<<\n");
                if (uldir.Response.Length > 0)
                {
                    MessageBox.Show("Lỗi khởi tạo dữ liệu.", "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000198 RID: 408 RVA: 0x00019BC8 File Offset: 0x00017DC8
        private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Equals(this.toolBarButtonNew))
            {
                this.menuItem_3_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonModify))
            {
                this.menuItem_4_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonDelete))
            {
                this.menuItem_5_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonCopy))
            {
                this.menuItem_6_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonPaste))
            {
                this.menuItem_7_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonPartitions))
            {
                this.menuItem_8_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonHelp))
            {
                this.menuItem_10_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonAbout))
            {
                this.menuItem_11_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonConnect))
            {
                this.menuItem_14_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonExit))
            {
                this.menuItem_13_Click(sender, e);
            }
            else if (e.Button.Equals(this.toolBarButtonConfirmDelete))
            {
                LTOOLSnet.bool_0 = !LTOOLSnet.bool_0;
            }
            else if (e.Button.Equals(this.toolBarButtonReadOnly))
            {
                LTOOLSnet.bool_1 = !LTOOLSnet.bool_1;
            }
            else if (e.Button.Equals(this.toolBarButtonEncrypt))
            {
                LTOOLSnet.bool_3 = !LTOOLSnet.bool_3;
                LTOOLSnet.UpdateStatusToolBar();
            }
        }

        // Token: 0x06000199 RID: 409 RVA: 0x00019DA4 File Offset: 0x00017FA4
        private static void smethod_1()
        {
            string caption = "UTools";
            try
            {
                string host = LTOOLSnet.remoteHost_0.Host;
                int port = LTOOLSnet.remoteHost_0.Port;
                LTOOLSnet.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (!LTOOLSnet.socket_0.Connected)
                {
                    string text = "Unable to connect to host: " + LTOOLSnet.remoteHost_0.Host;
                    MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    LTOOLSnet.smethod_0(string.Concat(new object[]
                    {
                        "Client connected to server: ",
                        LTOOLSnet.remoteHost_0.Host,
                        ":",
                        LTOOLSnet.remoteHost_0.Port
                    }));
                    LTOOLSnet.bool_4 = true;
                }
            }
            catch (Exception ex)
            {
                LTOOLSnet.bool_4 = false;
                string text = "Client connect to server failed:\n" + ex.Message;
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                LTOOLSnet.smethod_0(text);
            }
        }

        // Token: 0x0600019A RID: 410 RVA: 0x00019E8C File Offset: 0x0001808C
        private static void smethod_2()
        {
            try
            {
                Encoding ascii = Encoding.ASCII;
                string s = "ESC";
                byte[] bytes = ascii.GetBytes(s);
                LTOOLSnet.socket_0.Send(bytes, bytes.Length, SocketFlags.None);
                LTOOLSnet.socket_0.Close();
                LTOOLSnet.bool_4 = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UTools", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                LTOOLSnet.bool_4 = false;
            }
        }

        // Token: 0x0600019B RID: 411 RVA: 0x000022A9 File Offset: 0x000004A9
        public static void UpdateStatusToolBar()
        {
        }

        // Token: 0x0600019C RID: 412 RVA: 0x00002BE7 File Offset: 0x00000DE7
        public static void UpdateStatusBarPanel_Size(string StrSize)
        {
            LTOOLSnet.ltoolsnet_0.statusBarPanel1.Text = StrSize;
        }

        // Token: 0x0600019D RID: 413 RVA: 0x00002BE7 File Offset: 0x00000DE7
        public static void UpdateStatusBarPanel_Copyfile(string sFile)
        {
            LTOOLSnet.ltoolsnet_0.statusBarPanel1.Text = sFile;
        }

        // Token: 0x0600019E RID: 414 RVA: 0x00002BF9 File Offset: 0x00000DF9
        public static void UpdateStatusBarPanel_CopyfileSize(string sFileSize, string sCopySize)
        {
            LTOOLSnet.ltoolsnet_0.statusBarPanel1.Text = "Size=" + sFileSize + ";(%)= " + sCopySize;
        }

        // Token: 0x0600019F RID: 415 RVA: 0x000022A9 File Offset: 0x000004A9
        private void statusBar_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
        }

        // Token: 0x060001A0 RID: 416 RVA: 0x00019F00 File Offset: 0x00018100
        public static void ShowSplashScreen(int duration)
        {
            try
            {
                int num = 320;
                int num2 = 240;
                int num3 = 2;
                string text = LTOOLSnet.string_3 + "SplashScreen.bmp";
                Form form = new Form();
                form.AutoScaleBaseSize = new Size(5, 13);
                form.ClientSize = new Size(320, 240);
                form.FormBorderStyle = FormBorderStyle.None;
                form.BackColor = Color.Black;
                form.Name = "SplashScreen";
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Text = "SplashScreen";
                form.TopMost = true;
                form.SuspendLayout();
                Label label = new Label();
                label.Font = new Font(FontFamily.GenericSansSerif.ToString(), 10f);
                label.Text = "USBTOOL Version 2.0 © 2011-2012";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(316, 20);
                label.Location = new Point(2, 218);
                label.BackColor = Color.Transparent;
                Panel panel = new Panel();
                panel.Size = new Size(316, 236);
                panel.Location = new Point(2, 2);
                if (File.Exists(text))
                {
                    panel.BackgroundImage = new Bitmap(text);
                }
                else
                {
                    Label label2 = new Label();
                    label2.Font = new Font(FontFamily.GenericSansSerif.ToString(), 48f);
                    label2.Text = "UTools";
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                    label2.Size = new Size(num - 2 * num3, 60);
                    label2.Location = new Point(num3, num2 - num3 - 160);
                    label2.ForeColor = Color.White;
                    panel.BackColor = Color.CornflowerBlue;
                    panel.Controls.Add(label2);
                    label.ForeColor = Color.White;
                }
                panel.Controls.Add(label);
                form.Controls.Add(panel);
                form.ResumeLayout(false);
                form.Update();
                form.Show();
                form.Update();
                Thread.Sleep(duration);
                form.Visible = false;
            }
            catch (Exception ex)
            {
                LTOOLSnet.smethod_0(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        // Token: 0x060001A1 RID: 417 RVA: 0x00002C1B File Offset: 0x00000E1B
        private static void smethod_3(Form form_0, object object_0)
        {
            ((Form)form_0).Dispose();
        }

        // Token: 0x060001A2 RID: 418 RVA: 0x0001A16C File Offset: 0x0001836C
        public static void USB_enableWriteProtect()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
            if (registryKey == null)
            {
                Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", RegistryKeyPermissionCheck.ReadWriteSubTree);
                registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                registryKey.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
            }
            else if (Convert.ToInt32(registryKey.GetValue("WriteProtect")) != 1)
            {
                registryKey.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
            }
        }

        // Token: 0x060001A3 RID: 419 RVA: 0x0001A1F0 File Offset: 0x000183F0
        public static void USB_disableWriteProtect()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
            if (registryKey != null)
            {
                registryKey.SetValue("WriteProtect", 0, RegistryValueKind.DWord);
            }
            registryKey.Close();
        }

        // Token: 0x060001A4 RID: 420 RVA: 0x00002C28 File Offset: 0x00000E28
        public static void ShowProgessBar(bool show1)
        {
            LTOOLSnet.ltoolsnet_0.dosFilePanel.lblCopy.Visible = show1;
        }

        // Token: 0x060001A5 RID: 421 RVA: 0x0001A22C File Offset: 0x0001842C
        public static void ShowStatusBar(bool show1, long iFileSize)
        {
            if (show1)
            {
                if ((int)iFileSize / 1500000 >= 2)
                {
                    LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Minimum = 0;
                    LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Maximum = (int)iFileSize / 1700000;
                    LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Step = 1;
                    LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Value = 1;
                    LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Visible = true;
                    LTOOLSnet.ltoolsnet_0.int_0 = 0;
                    LTOOLSnet.ltoolsnet_0.timer_1.Enabled = true;
                }
            }
            else
            {
                LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Value = 0;
                LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Visible = false;
                LTOOLSnet.ltoolsnet_0.timer_1.Enabled = false;
            }
        }

        // Token: 0x060001A6 RID: 422 RVA: 0x0001A2FC File Offset: 0x000184FC
        //[STAThread]
        //private static void Main(string[] args)
        //{
        //    int num = args.Length;
        //    for (int i = 0; i < num; i++)
        //    {
        //        if (args[i].Substring(0, 2).ToLower() == "-d")
        //        {
        //            LTOOLSnet.Debug = true;
        //        }
        //    }
        //    LTOOLSnet.fLogin = new frmLogins();
        //    LTOOLSnet.fLogin.ShowDialog();
        //    LTOOLSnet.IsLogined = LTOOLSnet.fLogin.IsLoginOK;
        //    if (LTOOLSnet.bool_7)
        //    {
        //        Application.Run(new LTOOLSnet());
        //    }
        //}

        // Token: 0x060001A7 RID: 423 RVA: 0x00002C3F File Offset: 0x00000E3F
        private void timer_0_Tick(object sender, EventArgs e)
        {
            if (LTOOLSnet.bool_2)
            {
                this.linuxFilePanel.UpdateOpenedFiles(this.linuxFilePanel.m_OpenedFiles);
            }
        }

        // Token: 0x060001A8 RID: 424 RVA: 0x0001A378 File Offset: 0x00018578
        public static byte[] ReadFileToByteArray(string fileName)
        {
            byte[] result = null;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    result = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }
            return result;
        }

        // Token: 0x060001A9 RID: 425 RVA: 0x0001A3E4 File Offset: 0x000185E4
        private void menuItem_27_Click(object sender, EventArgs e)
        {
            if (this.splitContainer1.ActiveControl == this.dosFilePanel)
            {
                LTOOLSnet.smethod_0("The DOSPanel is active.");
                DirectoryNode selectedDirectoryNode = this.dosFilePanel.GetSelectedDirectoryNode();
                this.dosFilePanel.UpdateNode(selectedDirectoryNode);
            }
            else if (this.splitContainer1.ActiveControl == this.linuxFilePanel)
            {
                LTOOLSnet.smethod_0("The USBPanel is active.");
                LTOOLSnet.smethod_0("The DOSPanel is active.");
                DirectoryNode selectedDirectoryNode = this.linuxFilePanel.GetSelectedDirectoryNode();
                this.linuxFilePanel.UpdateNode(selectedDirectoryNode);
            }
        }

        // Token: 0x060001AA RID: 426 RVA: 0x00002C61 File Offset: 0x00000E61
        private void menuItem_28_Click(object sender, EventArgs e)
        {
            this.menuItem_28.Checked = !this.menuItem_28.Checked;
            LTOOLSnet.IsEncryptFile = this.menuItem_28.Checked;
            LTOOLSnet.UpdateStatusToolBar();
        }

        // Token: 0x060001AB RID: 427 RVA: 0x000022A9 File Offset: 0x000004A9
        private void dosFilePanel_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x060001AC RID: 428 RVA: 0x0001A474 File Offset: 0x00018674
        private void timer_1_Tick(object sender, EventArgs e)
        {
            if (this.int_0 < (int)usbpublic.FILE_SIZE / 1700000)
            {
                this.wWfFmYuNew.PerformStep();
            }
            this.int_0++;
            if (this.int_0 > 2 * (int)usbpublic.FILE_SIZE / 1700000)
            {
                LTOOLSnet.ltoolsnet_0.wWfFmYuNew.Visible = false;
                LTOOLSnet.ltoolsnet_0.timer_1.Enabled = false;
            }
        }

        // Token: 0x060001AD RID: 429 RVA: 0x00002C91 File Offset: 0x00000E91
        private void menuItem_30_Click(object sender, EventArgs e)
        {
            LTOOLSnet.CutSelected = false;
            this.ListViewItemFilesCopy();
        }

        // Token: 0x060001AE RID: 430 RVA: 0x0001A4F0 File Offset: 0x000186F0
        static LTOOLSnet()
        {
            Class3.vd4OXo2zYFEgU();
            LTOOLSnet.ltoolsnet_0 = null;
            LTOOLSnet.string_1 = "";
            LTOOLSnet.string_2 = "";
            LTOOLSnet.string_3 = Path.GetTempPath();
            LTOOLSnet.bool_0 = true;
            LTOOLSnet.bool_1 = false;
            LTOOLSnet.bool_2 = false;
            LTOOLSnet.bool_3 = true;
            LTOOLSnet.BUFSIZE = 32768;
            LTOOLSnet.socket_0 = null;
            LTOOLSnet.bool_4 = false;
            LTOOLSnet.remoteHost_0 = new RemoteHost("localhost", 1605);
            LTOOLSnet.bool_5 = false;
            LTOOLSnet.string_4 = "*";
            LTOOLSnet.string_5 = "*";
            LTOOLSnet.arrayList_0 = null;
            LTOOLSnet.arrayList_1 = null;
            LTOOLSnet.arrayList_2 = null;
            LTOOLSnet.arrayList_3 = null;
            LTOOLSnet.arrayList_4 = null;
            LTOOLSnet.bool_6 = false;
            LTOOLSnet.bool_7 = false;
            LTOOLSnet.string_6 = "";
            LTOOLSnet.bool_8 = false;
            LTOOLSnet.bool_9 = false;
            LTOOLSnet.helpBox_0 = null;
            LTOOLSnet.remoteBoxDialog_0 = null;
            LTOOLSnet.color_0 = Color.AliceBlue;
        }

        // Token: 0x040000FB RID: 251
        private MainMenu mainMenu_0;

        // Token: 0x040000FC RID: 252
        private MenuItem menuItem_0;

        // Token: 0x040000FD RID: 253
        private MenuItem menuItem_1;

        // Token: 0x040000FE RID: 254
        private MenuItem menuItem_2;

        // Token: 0x040000FF RID: 255
        private MenuItem menuItem_3;

        // Token: 0x04000100 RID: 256
        private MenuItem menuItem_4;

        // Token: 0x04000101 RID: 257
        private MenuItem menuItem_5;

        // Token: 0x04000102 RID: 258
        private MenuItem menuItem_6;

        // Token: 0x04000103 RID: 259
        private MenuItem menuItem_7;

        // Token: 0x04000104 RID: 260
        private MenuItem menuItem_8;

        // Token: 0x04000105 RID: 261
        private MenuItem menuItem_9;

        // Token: 0x04000106 RID: 262
        private MenuItem menuItem_10;

        // Token: 0x04000107 RID: 263
        private MenuItem menuItem_11;

        // Token: 0x04000108 RID: 264
        private MenuItem menuItem_12;

        // Token: 0x04000109 RID: 265
        private MenuItem menuItem_13;

        // Token: 0x0400010A RID: 266
        private MenuItem menuItem_14;

        // Token: 0x0400010B RID: 267
        private MenuItem menuItem_15;

        // Token: 0x0400010C RID: 268
        private MenuItem menuItem_16;

        // Token: 0x0400010D RID: 269
        private MenuItem menuItem_17;

        // Token: 0x0400010E RID: 270
        private MenuItem menuItem_18;

        // Token: 0x0400010F RID: 271
        private MenuItem menuItem_19;

        // Token: 0x04000110 RID: 272
        private MenuItem menuItem_20;

        // Token: 0x04000111 RID: 273
        private MenuItem menuItem_21;

        // Token: 0x04000112 RID: 274
        private MenuItem menuItem_22;

        // Token: 0x04000113 RID: 275
        private MenuItem menuItem_23;

        // Token: 0x04000114 RID: 276
        private MenuItem menuItem_24;

        // Token: 0x04000115 RID: 277
        private MenuItem menuItem_25;

        // Token: 0x04000116 RID: 278
        private Panel panelCenter;

        // Token: 0x04000117 RID: 279
        private Panel panelButtons;

        // Token: 0x04000118 RID: 280
        private Panel panelToolbar;

        // Token: 0x04000119 RID: 281
        private ImageList imageList_0;

        // Token: 0x0400011A RID: 282
        private ToolBar toolBar;

        // Token: 0x0400011B RID: 283
        private ToolBarButton toolBarButtonNew;

        // Token: 0x0400011C RID: 284
        private ToolBarButton toolBarButtonModify;

        // Token: 0x0400011D RID: 285
        private ToolBarButton toolBarButtonDelete;

        // Token: 0x0400011E RID: 286
        private ToolBarButton toolBarButtonCopy;

        // Token: 0x0400011F RID: 287
        private ToolBarButton toolBarButtonPaste;

        // Token: 0x04000120 RID: 288
        private ToolBarButton toolBarButtonSeparator1;

        // Token: 0x04000121 RID: 289
        private ToolBarButton toolBarButtonPartitions;

        // Token: 0x04000122 RID: 290
        private ToolBarButton toolBarButtonConnect;

        // Token: 0x04000123 RID: 291
        private ToolBarButton toolBarButtonSeparator2;

        // Token: 0x04000124 RID: 292
        private ToolBarButton toolBarButtonHelp;

        // Token: 0x04000125 RID: 293
        private ToolBarButton toolBarButtonAbout;

        // Token: 0x04000126 RID: 294
        private ToolBarButton toolBarButtonExit;

        // Token: 0x04000127 RID: 295
        private ToolBarButton toolBarButtonReadOnly;

        // Token: 0x04000128 RID: 296
        private ToolBarButton toolBarButtonConfirmDelete;

        // Token: 0x04000129 RID: 297
        private ToolBarButton toolBarButtonSeparator3;

        // Token: 0x0400012A RID: 298
        private StatusBar statusBar;

        // Token: 0x0400012B RID: 299
        private DirFilePanel linuxFilePanel;

        // Token: 0x0400012C RID: 300
        private DirFilePanel dosFilePanel;

        // Token: 0x0400012D RID: 301
        private IContainer icontainer_0;

        // Token: 0x0400012E RID: 302
        private static LTOOLSnet ltoolsnet_0;

        // Token: 0x0400012F RID: 303
        private string string_0;

        // Token: 0x04000130 RID: 304
        private static string string_1;

        // Token: 0x04000131 RID: 305
        private static string string_2;

        // Token: 0x04000132 RID: 306
        private static string string_3;

        // Token: 0x04000133 RID: 307
        private static bool bool_0;

        // Token: 0x04000134 RID: 308
        private static bool bool_1;

        // Token: 0x04000135 RID: 309
        private static bool bool_2;

        // Token: 0x04000136 RID: 310
        private static bool bool_3;

        // Token: 0x04000137 RID: 311
        public static int BUFSIZE;

        // Token: 0x04000138 RID: 312
        private static Socket socket_0;

        // Token: 0x04000139 RID: 313
        private static bool bool_4;

        // Token: 0x0400013A RID: 314
        private static RemoteHost remoteHost_0;

        // Token: 0x0400013B RID: 315
        public static MyDebug debugDialog;

        // Token: 0x0400013C RID: 316
        public static frmProperties fProperties;

        // Token: 0x0400013D RID: 317
        private static bool bool_5;

        // Token: 0x0400013E RID: 318
        private static string string_4;

        // Token: 0x0400013F RID: 319
        private static string string_5;

        // Token: 0x04000140 RID: 320
        private static ArrayList arrayList_0;

        // Token: 0x04000141 RID: 321
        private static ArrayList arrayList_1;

        // Token: 0x04000142 RID: 322
        private static ArrayList arrayList_2;

        // Token: 0x04000143 RID: 323
        private static ArrayList arrayList_3;

        // Token: 0x04000144 RID: 324
        private static ArrayList arrayList_4;

        // Token: 0x04000145 RID: 325
        private static bool bool_6;

        // Token: 0x04000146 RID: 326
        private static bool bool_7;

        // Token: 0x04000147 RID: 327
        private static string string_6;

        // Token: 0x04000148 RID: 328
        private static bool bool_8;

        // Token: 0x04000149 RID: 329
        private static bool bool_9;

        // Token: 0x0400014A RID: 330
        private static HelpBox helpBox_0;

        // Token: 0x0400014B RID: 331
        private static RemoteBoxDialog remoteBoxDialog_0;

        // Token: 0x0400014C RID: 332
        private static Color color_0;

        // Token: 0x0400014D RID: 333
        private System.Windows.Forms.Timer timer_0;

        // Token: 0x0400014E RID: 334
        private ImageList imageList_1;

        // Token: 0x0400014F RID: 335
        private StatusBarPanel statusBarPanel1;

        // Token: 0x04000150 RID: 336
        private StatusBarPanel statusBarPanel2;

        // Token: 0x04000151 RID: 337
        private MenuItem menuItem_26;

        // Token: 0x04000152 RID: 338
        private MenuItem menuItem_27;

        // Token: 0x04000153 RID: 339
        private System.Windows.Forms.Timer timer_1;

        // Token: 0x04000154 RID: 340
        private ProgressBar wWfFmYuNew;

        // Token: 0x04000155 RID: 341
        private ToolBarButton toolBarButtonEncrypt;

        // Token: 0x04000156 RID: 342
        private MenuItem menuItem_28;

        // Token: 0x04000157 RID: 343
        private MenuItem menuItem_29;

        // Token: 0x04000158 RID: 344
        private StatusBarPanel statusBarPanel0;

        // Token: 0x04000159 RID: 345
        public static frmLogins fLogin;

        // Token: 0x0400015A RID: 346
        public static frmCopying fCopying;

        // Token: 0x0400015B RID: 347
        private Label lblCopy;

        // Token: 0x0400015C RID: 348
        private SplitContainer splitContainer1;

        // Token: 0x0400015D RID: 349
        private PictureBox picDOS;

        // Token: 0x0400015E RID: 350
        private MenuItem menuItem_30;

        // Token: 0x0400015F RID: 351
        private int int_0;

        // Token: 0x04000160 RID: 352
        public static DirectoryNode curDosNode;

        // Token: 0x04000161 RID: 353
        public static DirectoryNode curLinuxNode;
    }
}