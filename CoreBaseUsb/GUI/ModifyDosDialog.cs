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
    public partial class ModifyDosDialog : Form
    {
        public ModifyDosDialog(bool isNew, string fileName, string fileLength, string fileDate, bool isDirectory, bool isReadOnly, bool isHidden, bool isSystem)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            this.InitializeComponent();
            if (isNew)
            {
                this.Text = "New Directory";
            }
            this.fileNameTextBox.Text = fileName;
            this.fileDateLabel.Text = fileDate;
            this.fileLengthLabel.Text = fileLength;
            if (isDirectory)
            {
                this.directoryCheckBox.Checked = true;
            }
            if (isReadOnly)
            {
                this.readOnlyCheckBox.Checked = true;
            }
            if (isHidden)
            {
                this.hiddenCheckBox.Checked = true;
            }
            if (isSystem)
            {
                this.systemCheckBox.Checked = true;
            }
        }
    }
}
