using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    public partial class RemoteBoxDialog : Form
    {
        public RemoteBoxDialog(RemoteHost host)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            this.arrayList_0 = new ArrayList();
            this.string_0 = LTOOLSnet.GUIDirectory + "properties.ini";
            this.InitializeComponent();
            this.SetDebugDialog(LTOOLSnet.debugDialog);
            this.arrayList_0.Add(host);
            this.GetHostsFromFile();
            this.method_0();
            this.comboBoxHostName.SelectedIndex = 0;
        }
    }
}
