using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;
using System.Collections;

namespace CoreBaseUsb.GUI
{
    public partial class DirFilePanel : UserControl
    {
        public DirFilePanel()
        {
            Class3.vd4OXo2zYFEgU();
            this.m_OpenedFiles = new ArrayList();
            this.m_LinuxFiles = new ArrayList();
            this.bool_0 = false;
            this.directoryNode_1 = null;
            this.sortOrder_0 = SortOrder.Ascending;
            this.InitializeComponent();
            this.ViewListView = View.Details;
            this.labelDirectory.Text = "My Computer";
            this.labelDirectory.ForeColor = Color.Blue;
        }
    }
}
