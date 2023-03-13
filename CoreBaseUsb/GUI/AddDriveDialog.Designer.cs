using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class AddDriveDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        public string Device
        {
            get
            {
                return this.textBoxDevice.Text;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000002 RID: 2 RVA: 0x00002F08 File Offset: 0x00001108
        public string Directory
        {
            get
            {
                return this.textBoxDirectory.Text;
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.container_0 != null)
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000005 RID: 5 RVA: 0x00002F9C File Offset: 0x0000119C
        private void InitializeComponent()
        {
            this.kUlneJwup = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxDevice = new System.Windows.Forms.TextBox();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.cboUSB = new System.Windows.Forms.ComboBox();
            this.cboUSB1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // kUlneJwup
            // 
            this.kUlneJwup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kUlneJwup.Location = new System.Drawing.Point(54, 174);
            this.kUlneJwup.Name = "kUlneJwup";
            this.kUlneJwup.Size = new System.Drawing.Size(214, 48);
            this.kUlneJwup.TabIndex = 0;
            this.kUlneJwup.Text = "OK";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(344, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(214, 48);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            // 
            // labelDevice
            // 
            this.labelDevice.Location = new System.Drawing.Point(16, 31);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(138, 32);
            this.labelDevice.TabIndex = 2;
            this.labelDevice.Text = "Thiết bị:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.Location = new System.Drawing.Point(16, 94);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(120, 32);
            this.labelDirectory.TabIndex = 3;
            this.labelDirectory.Text = "Directory:";
            this.labelDirectory.Visible = false;
            // 
            // textBoxDevice
            // 
            this.textBoxDevice.Location = new System.Drawing.Point(154, 31);
            this.textBoxDevice.Name = "textBoxDevice";
            this.textBoxDevice.Size = new System.Drawing.Size(410, 31);
            this.textBoxDevice.TabIndex = 4;
            this.textBoxDevice.Text = "/dev/hdb1";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(154, 94);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(410, 31);
            this.textBoxDirectory.TabIndex = 5;
            this.textBoxDirectory.Text = "/";
            this.textBoxDirectory.Visible = false;
            // 
            // cboUSB
            // 
            this.cboUSB.FormattingEnabled = true;
            this.cboUSB.Items.AddRange(new object[] {
            "USB1",
            "USB2",
            "USB3",
            "USB4"});
            this.cboUSB.Location = new System.Drawing.Point(102, 231);
            this.cboUSB.Name = "cboUSB";
            this.cboUSB.Size = new System.Drawing.Size(432, 33);
            this.cboUSB.TabIndex = 6;
            this.cboUSB.Visible = false;
            // 
            // cboUSB1
            // 
            this.cboUSB1.FormattingEnabled = true;
            this.cboUSB1.Items.AddRange(new object[] {
            "/dev/hdb1",
            "/dev/hdc1",
            "/dev/hde1",
            "/dev/hdf1"});
            this.cboUSB1.Location = new System.Drawing.Point(132, 231);
            this.cboUSB1.Name = "cboUSB1";
            this.cboUSB1.Size = new System.Drawing.Size(432, 33);
            this.cboUSB1.TabIndex = 7;
            this.cboUSB1.Visible = false;
            // 
            // AddDriveDialog
            // 
            this.AcceptButton = this.kUlneJwup;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(640, 307);
            this.Controls.Add(this.cboUSB1);
            this.Controls.Add(this.cboUSB);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.textBoxDevice);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.kUlneJwup);
            this.MaximumSize = new System.Drawing.Size(666, 480);
            this.MinimumSize = new System.Drawing.Size(494, 244);
            this.Name = "AddDriveDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm USB bảo mật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x06000006 RID: 6 RVA: 0x000022A9 File Offset: 0x000004A9
        private void AddDriveDialog_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x04000001 RID: 1
        private Button kUlneJwup;

        // Token: 0x04000002 RID: 2
        private Button buttonCancel;

        // Token: 0x04000003 RID: 3
        private Label labelDevice;

        // Token: 0x04000004 RID: 4
        private Label labelDirectory;

        // Token: 0x04000005 RID: 5
        private TextBox textBoxDevice;

        // Token: 0x04000006 RID: 6
        private TextBox textBoxDirectory;

        // Token: 0x04000007 RID: 7
        private ComboBox cboUSB;

        // Token: 0x04000008 RID: 8
        private ComboBox cboUSB1;

        // Token: 0x04000009 RID: 9
        private Container container_0;
    }
}