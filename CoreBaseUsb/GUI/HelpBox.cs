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
    public partial class HelpBox : Form
    {
        public HelpBox(bool modal, string baseDirectory)
        {
            Class3.vd4OXo2zYFEgU();
            this.uri_0 = new Uri[HelpBox.int_0];
            this.InitializeComponent();
            baseDirectory = baseDirectory.Replace('\\', '/');
            this.uri_0[0] = new Uri(baseDirectory + "/LTOOLSnet1.htm");
            this.uri_0[1] = new Uri(baseDirectory + "/LTOOLSnet2.htm");
            this.uri_0[2] = new Uri(baseDirectory + "/LTOOLSnet3.htm");
            this.uri_0[3] = new Uri(baseDirectory + "/LTOOLSnet4.htm");
            this.int_1 = 0;
            this.method_0();
            this.previousToolBarButton.Enabled = false;
            this.axWebBrowser_0.DownloadComplete += this.axWebBrowser_0_DownloadComplete;
            if (modal)
            {
                base.ShowDialog();
            }
            else
            {
                base.Visible = true;
            }
        }
    }
}
