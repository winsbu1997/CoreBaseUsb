using System;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;
namespace CoreBaseUsb.GUI
{
    public class DirectoryNode : TreeNode
    {
        public bool IsRemovableDrive
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

        public bool SubDirectoriesAdded
        {
            get
            {
                return this.bool_0;
            }
            set
            {
                this.bool_0 = value;
            }
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x0600005F RID: 95 RVA: 0x0000561C File Offset: 0x0000381C
        // (set) Token: 0x0600005E RID: 94 RVA: 0x00002352 File Offset: 0x00000552
        public string Path
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

        // Token: 0x06000060 RID: 96 RVA: 0x0000235B File Offset: 0x0000055B
        public DirectoryNode(string text)
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor(text);
            this.string_0 = text;
        }

        // Token: 0x04000029 RID: 41
        private string string_0;

        // Token: 0x0400002A RID: 42
        private bool bool_0;

        // Token: 0x0400002B RID: 43
        private bool bool_1;
    }
}
