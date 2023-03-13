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
    public partial class ModifyLinuxDialog : Form
    {
        public ModifyLinuxDialog(bool isNew, string fileName, string fileDate, string fileLength, string uid, string gid, string access)
        {
            Class3.vd4OXo2zYFEgU();
            this.container_0 = null;
            this.InitializeComponent();
            if (isNew)
            {
                this.Text = "Tạo thư mục";
                this.dirCheckBox.Enabled = true;
                this.dirCheckBox.Checked = true;
                this.linkCheckBox.Enabled = true;
            }
            this.fileNameTextBox.Text = fileName;
            this.fileDateTextBox.Text = fileDate;
            this.fileLengthLabel.Text = fileLength;
            this.gidTextBox.Text = gid;
            this.uidTextBox.Text = uid;
            if (access.StartsWith("d"))
            {
                this.dirCheckBox.Checked = true;
            }
            if (access.StartsWith("l"))
            {
                this.linkCheckBox.Checked = true;
            }
            if (!access.StartsWith("-") && !access.StartsWith("d") && !access.StartsWith("l"))
            {
                this.devCheckBox.Checked = true;
            }
            if (access.Length >= 10)
            {
                if (access.Substring(1, 1).Equals("r"))
                {
                    this.rUserCheckBox.Checked = true;
                }
                if (access.Substring(2, 1).Equals("w"))
                {
                    this.wUserCheckBox.Checked = true;
                }
                if (access.Substring(3, 1).Equals("x"))
                {
                    this.xUserCheckBox.Checked = true;
                }
                if (access.Substring(4, 1).Equals("r"))
                {
                    this.rGroupCheckBox.Checked = true;
                }
                if (access.Substring(5, 1).Equals("w"))
                {
                    this.wGroupCheckBox.Checked = true;
                }
                if (access.Substring(6, 1).Equals("x"))
                {
                    this.YcrienTerZ.Checked = true;
                }
                if (access.Substring(7, 1).Equals("r"))
                {
                    this.rWorldCheckBox.Checked = true;
                }
                if (access.Substring(8, 1).Equals("w"))
                {
                    this.yAoijawLxy.Checked = true;
                }
                if (access.Substring(9, 1).Equals("x"))
                {
                    this.xWorldCheckBox.Checked = true;
                }
            }
            this.string_0 = this.Access;
        }
        static ModifyLinuxDialog()
        {
            Class3.vd4OXo2zYFEgU();
            ModifyLinuxDialog.bool_0 = false;
        }
    }
}
