using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    public partial class PartitionsDialog : Form
    {
        public PartitionsDialog(string partitions, string caption)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            this.InitializeComponent();
            Class1 @class = new Class1(partitions, "\r\n");
            int num = 0;
            while (@class.method_3())
            {
                num++;
                @class.method_4();
            }
            this.labelPartitions.Text = partitions;
            int num2 = num * this.labelPartitions.Font.Height + 50;
            if (num2 < 150)
            {
                num2 = 150;
            }
            this.panelIconLabel.Height = num2;
            this.labelPartitions.Height = num2;
            base.Height = num2 + this.panelButton.Height;
            this.Text = caption;
        }
    }
}
