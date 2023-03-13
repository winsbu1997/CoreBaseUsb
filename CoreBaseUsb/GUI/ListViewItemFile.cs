using CoreBaseUsb.Utilities;
using System;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    // Token: 0x0200001D RID: 29
    public class ListViewItemFile : ListViewItem, IComparable
    {
        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000138 RID: 312 RVA: 0x00002902 File Offset: 0x00000B02
        // (set) Token: 0x06000139 RID: 313 RVA: 0x0000290A File Offset: 0x00000B0A
        public bool IsError
        {
            get
            {
                return this.bool_2;
            }
            set
            {
                this.bool_2 = value;
                if (this.IsError)
                {
                    this.int_0 = DirFilePanel.IndexIconError;
                    base.ImageIndex = this.int_0;
                }
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x0600013A RID: 314 RVA: 0x00002935 File Offset: 0x00000B35
        public bool IsDirectory
        {
            get
            {
                return this.bool_0;
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x0600013B RID: 315 RVA: 0x00015F7C File Offset: 0x0001417C
        public bool IsLink
        {
            get
            {
                return this.string_4 != null && this.string_4[0].ToString().Equals("l");
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x0600013C RID: 316 RVA: 0x0000293D File Offset: 0x00000B3D
        // (set) Token: 0x0600013D RID: 317 RVA: 0x00002945 File Offset: 0x00000B45
        public bool IsReadOnly
        {
            get
            {
                return this.bool_1;
            }
            set
            {
                this.bool_1 = value;
            }
        }

        // Token: 0x17000014 RID: 20
        // (get) Token: 0x0600013E RID: 318 RVA: 0x00015FC0 File Offset: 0x000141C0
        // (set) Token: 0x0600013F RID: 319 RVA: 0x0000294E File Offset: 0x00000B4E
        public int FileSymbol
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x06000140 RID: 320 RVA: 0x00015FD8 File Offset: 0x000141D8
        // (set) Token: 0x06000141 RID: 321 RVA: 0x00002957 File Offset: 0x00000B57
        public string Directory
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000142 RID: 322 RVA: 0x00015FF0 File Offset: 0x000141F0
        // (set) Token: 0x06000143 RID: 323 RVA: 0x00016008 File Offset: 0x00014208
        public string FileName
        {
            get
            {
                return this.dqVfexkLi8;
            }
            set
            {
                this.dqVfexkLi8 = value;
                if (!this.IsDirectory)
                {
                    if (this.dqVfexkLi8.ToLower().EndsWith(".bmp") || this.dqVfexkLi8.ToLower().EndsWith(".gif") || this.dqVfexkLi8.ToLower().EndsWith(".jpg") || this.dqVfexkLi8.ToLower().EndsWith(".png"))
                    {
                        this.int_0 = DirFilePanel.IndexIconBitmap;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".pdf"))
                    {
                        this.int_0 = DirFilePanel.IndexIconPdf;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".html") || this.dqVfexkLi8.ToLower().EndsWith(".htm"))
                    {
                        this.int_0 = DirFilePanel.IndexIconHtml;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".avi") || this.dqVfexkLi8.ToLower().EndsWith(".mp4") || this.dqVfexkLi8.ToLower().EndsWith(".wmv") || this.dqVfexkLi8.ToLower().EndsWith(".mpg"))
                    {
                        this.int_0 = DirFilePanel.IndexIconAvi;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".mp3") || this.dqVfexkLi8.ToLower().EndsWith(".wav"))
                    {
                        this.int_0 = DirFilePanel.IndexIconMp3;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".doc") || this.dqVfexkLi8.ToLower().EndsWith(".docx"))
                    {
                        this.int_0 = DirFilePanel.IndexIconWord;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".xls") || this.dqVfexkLi8.ToLower().EndsWith(".xlsx"))
                    {
                        this.int_0 = DirFilePanel.IndexIconExcel;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".mdb"))
                    {
                        this.int_0 = DirFilePanel.IndexIconAccess;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".ppt") || this.dqVfexkLi8.ToLower().EndsWith(".pptx"))
                    {
                        this.int_0 = DirFilePanel.IndexIconPowerPoint;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".exe") || this.dqVfexkLi8.ToLower().EndsWith(".com"))
                    {
                        this.int_0 = DirFilePanel.IndexIconExe;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".java"))
                    {
                        this.int_0 = DirFilePanel.IndexIconJava;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".zip") || this.dqVfexkLi8.ToLower().EndsWith(".rar"))
                    {
                        this.int_0 = DirFilePanel.IndexIconZip;
                    }
                    else if (this.dqVfexkLi8.ToLower().EndsWith(".xyz"))
                    {
                        this.int_0 = DirFilePanel.IndexIconEncrypt;
                    }
                    else
                    {
                        this.int_0 = DirFilePanel.IndexIconFile;
                    }
                    if (this.IsLink)
                    {
                        this.int_0 = DirFilePanel.IndexIconLink;
                    }
                    base.ImageIndex = this.int_0;
                }
            }
        }

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x06000144 RID: 324 RVA: 0x000163B4 File Offset: 0x000145B4
        // (set) Token: 0x06000145 RID: 325 RVA: 0x00002960 File Offset: 0x00000B60
        public string FullFilePath
        {
            get
            {
                return this.string_1;
            }
            set
            {
                this.string_1 = value;
            }
        }

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000146 RID: 326 RVA: 0x000163CC File Offset: 0x000145CC
        // (set) Token: 0x06000147 RID: 327 RVA: 0x00002969 File Offset: 0x00000B69
        public string FileSize
        {
            get
            {
                return this.string_2;
            }
            set
            {
                this.string_2 = value;
            }
        }

        // Token: 0x17000019 RID: 25
        // (get) Token: 0x06000148 RID: 328 RVA: 0x000163E4 File Offset: 0x000145E4
        // (set) Token: 0x06000149 RID: 329 RVA: 0x00002972 File Offset: 0x00000B72
        public string FileLastModified
        {
            get
            {
                return this.string_3;
            }
            set
            {
                this.string_3 = value;
            }
        }

        // Token: 0x1700001A RID: 26
        // (get) Token: 0x0600014A RID: 330 RVA: 0x000163FC File Offset: 0x000145FC
        // (set) Token: 0x0600014B RID: 331 RVA: 0x0000297B File Offset: 0x00000B7B
        public string LinuxFileInfoString
        {
            get
            {
                return this.string_4;
            }
            set
            {
                this.string_4 = value;
            }
        }

        // Token: 0x1700001B RID: 27
        // (get) Token: 0x0600014C RID: 332 RVA: 0x00016414 File Offset: 0x00014614
        public string LinuxDrive
        {
            get
            {
                string result;
                if (this.FullFilePath != "" && this.LinuxFileInfoString != "")
                {
                    result = this.FullFilePath.Substring(0, this.FullFilePath.IndexOf(" "));
                }
                else
                {
                    result = "";
                }
                return result;
            }
        }

        // Token: 0x0600014D RID: 333 RVA: 0x00002984 File Offset: 0x00000B84
        public ListViewItemFile(string text, int imageIndex, bool isDirectory)
        {
            Class3.vd4OXo2zYFEgU();
            this.bool_2 = false;
            //base..ctor(text, imageIndex);
            this.bool_0 = isDirectory;
        }

        // Token: 0x0600014E RID: 334 RVA: 0x00016474 File Offset: 0x00014674
        public ListViewItemFile(string text, int imageIndex, bool isDirectory, string dir, string fSize, string fLastModified, string lxFileInfoString)
        {
            Class3.vd4OXo2zYFEgU();
            this.bool_2 = false;
            //ListViewItemFile(text, imageIndex);
            this.bool_0 = isDirectory;
            this.LinuxFileInfoString = lxFileInfoString;
            this.FileName = text;
            this.Directory = dir;
            this.FullFilePath = dir + text;
            this.FileSize = fSize;
            this.FileLastModified = fLastModified;
        }

        // Token: 0x0600014F RID: 335 RVA: 0x000164D4 File Offset: 0x000146D4
        public int CompareTo(object o)
        {
            int result;
            if (o == null)
            {
                result = 1;
            }
            else
            {
                if (o.GetType() != base.GetType())
                {
                    throw new ArgumentException();
                }
                ListViewItemFile listViewItemFile = (ListViewItemFile)o;
                result = this.FileName.CompareTo(listViewItemFile.FileName);
            }
            return result;
        }

        // Token: 0x06000150 RID: 336 RVA: 0x00016524 File Offset: 0x00014724
        public override string ToString()
        {
            return string.Concat(new string[]
            {
                "ListViewItemFile { isDirectory: ",
                this.bool_0.ToString(),
                ", isReadOnly: ",
                this.bool_1.ToString(),
                ", fileSymbol: ",
                this.int_0.ToString(),
                ", fileName: ",
                this.dqVfexkLi8,
                ", directory: ",
                this.string_0,
                ", fullFilePath: ",
                this.string_1,
                ", fileSize: ",
                this.string_2,
                ", fileLastModified: ",
                this.string_3,
                ", linuxFileInfoString: ",
                this.string_4,
                " }"
            });
        }

        // Token: 0x040000F0 RID: 240
        private bool bool_0;

        // Token: 0x040000F1 RID: 241
        private bool bool_1;

        // Token: 0x040000F2 RID: 242
        private bool bool_2;

        // Token: 0x040000F3 RID: 243
        private int int_0;

        // Token: 0x040000F4 RID: 244
        private string dqVfexkLi8;

        // Token: 0x040000F5 RID: 245
        private string string_0;

        // Token: 0x040000F6 RID: 246
        private string string_1;

        // Token: 0x040000F7 RID: 247
        private string string_2;

        // Token: 0x040000F8 RID: 248
        private string string_3;

        // Token: 0x040000F9 RID: 249
        private string string_4;

        // Token: 0x040000FA RID: 250
        public DateTime m_LastModified;
    }
}
