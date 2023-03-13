using CoreBaseUsb.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    public partial class AddDriveDialog : Form
    {
        public AddDriveDialog(bool isLinux)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            base..ctor();
            this.InitializeComponent();
            if (isLinux)
            {
                this.textBoxDevice.Text = "/dev/fd0";
                this.textBoxDirectory.Text = "/";
            }
            else
            {
                this.textBoxDevice.Text = "C:";
                this.textBoxDirectory.Text = Path.DirectorySeparatorChar.ToString();
            }
        }
    }
}
