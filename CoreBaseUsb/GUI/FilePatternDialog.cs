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
    public partial class FilePatternDialog : Form
    {
        public FilePatternDialog(string pattern, bool isLinux)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            this.InitializeComponent();
            this.textBoxFilePattern.Text = pattern;
            if (isLinux)
            {
                this.Text = "LTOOLS - Linux FilePattern";
            }
            else
            {
                this.Text = "LTOOLS - DOS FilePattern";
            }
        }
    }
}
