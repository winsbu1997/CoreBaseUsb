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
    public partial class MyDebug : Form
    {
        public MyDebug()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
            this.InitializeComponent();
            base.Show();
            this.debugOutput.Text = DateTime.Now.ToString() + MyDebug.SeparatorLine;
        }
    }
}
