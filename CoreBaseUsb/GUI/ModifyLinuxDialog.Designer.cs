using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class ModifyLinuxDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string FileName
        {
            get
            {
                return this.fileNameTextBox.Text;
            }
        }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x060001BC RID: 444 RVA: 0x0001AEF8 File Offset: 0x000190F8
        public string UID
        {
            get
            {
                return this.uidTextBox.Text;
            }
        }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x060001BD RID: 445 RVA: 0x0001AF14 File Offset: 0x00019114
        public string GID
        {
            get
            {
                return this.gidTextBox.Text;
            }
        }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060001BE RID: 446 RVA: 0x0001AF30 File Offset: 0x00019130
        public string Access
        {
            get
            {
                int num = 0;
                int num2 = 0;
                int num3 = 0;
                if (this.rUserCheckBox.Checked)
                {
                    num += 4;
                }
                if (this.wUserCheckBox.Checked)
                {
                    num += 2;
                }
                if (this.xUserCheckBox.Checked)
                {
                    num++;
                }
                if (this.rGroupCheckBox.Checked)
                {
                    num2 += 4;
                }
                if (this.wGroupCheckBox.Checked)
                {
                    num2 += 2;
                }
                if (this.YcrienTerZ.Checked)
                {
                    num2++;
                }
                if (this.rWorldCheckBox.Checked)
                {
                    num3 += 4;
                }
                if (this.yAoijawLxy.Checked)
                {
                    num3 += 2;
                }
                if (this.xWorldCheckBox.Checked)
                {
                    num3++;
                }
                return num.ToString() + num2.ToString() + num3.ToString();
            }
        }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060001BF RID: 447 RVA: 0x00002CF8 File Offset: 0x00000EF8
        public bool IsDirectory
        {
            get
            {
                return this.dirCheckBox.Checked;
            }
        }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060001C0 RID: 448 RVA: 0x00002D05 File Offset: 0x00000F05
        public bool IsLink
        {
            get
            {
                return this.linkCheckBox.Checked;
            }
        }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060001C1 RID: 449 RVA: 0x0001B014 File Offset: 0x00019214
        public string TargetName
        {
            get
            {
                return this.fileDateTextBox.Text;
            }
        }

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060001C2 RID: 450 RVA: 0x00002D12 File Offset: 0x00000F12
        public bool IsAccessChanged
        {
            get
            {
                return ModifyLinuxDialog.bool_0;
            }
        }

        // Token: 0x060001C3 RID: 451 RVA: 0x0001B030 File Offset: 0x00019230
    

        // Token: 0x060001C4 RID: 452 RVA: 0x00002D19 File Offset: 0x00000F19
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.container_0 != null)
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060001C5 RID: 453 RVA: 0x0001B2A0 File Offset: 0x000194A0
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.modificationDateLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.gidLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileDateTextBox = new System.Windows.Forms.TextBox();
            this.fileLengthLabel = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.gidTextBox = new System.Windows.Forms.TextBox();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dirCheckBox = new System.Windows.Forms.CheckBox();
            this.linkCheckBox = new System.Windows.Forms.CheckBox();
            this.devCheckBox = new System.Windows.Forms.CheckBox();
            this.userAccessLabel = new System.Windows.Forms.Label();
            this.rUserCheckBox = new System.Windows.Forms.CheckBox();
            this.wUserCheckBox = new System.Windows.Forms.CheckBox();
            this.xUserCheckBox = new System.Windows.Forms.CheckBox();
            this.YcrienTerZ = new System.Windows.Forms.CheckBox();
            this.wGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.rGroupCheckBox = new System.Windows.Forms.CheckBox();
            this.groupAccessLabel = new System.Windows.Forms.Label();
            this.xWorldCheckBox = new System.Windows.Forms.CheckBox();
            this.yAoijawLxy = new System.Windows.Forms.CheckBox();
            this.rWorldCheckBox = new System.Windows.Forms.CheckBox();
            this.worldAccessLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(5, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(205, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Tên thư mục";
            // 
            // modificationDateLabel
            // 
            this.modificationDateLabel.Location = new System.Drawing.Point(33, 419);
            this.modificationDateLabel.Name = "modificationDateLabel";
            this.modificationDateLabel.Size = new System.Drawing.Size(205, 32);
            this.modificationDateLabel.TabIndex = 1;
            this.modificationDateLabel.Text = "Ngày:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Location = new System.Drawing.Point(33, 482);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(205, 32);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Kích thước:";
            // 
            // gidLabel
            // 
            this.gidLabel.Location = new System.Drawing.Point(68, 741);
            this.gidLabel.Name = "gidLabel";
            this.gidLabel.Size = new System.Drawing.Size(102, 48);
            this.gidLabel.TabIndex = 3;
            this.gidLabel.Text = "GID";
            this.gidLabel.Visible = false;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(200, 54);
            this.fileNameTextBox.MaxLength = 255;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(448, 31);
            this.fileNameTextBox.TabIndex = 4;
            this.fileNameTextBox.Text = "fileName";
            // 
            // fileDateTextBox
            // 
            this.fileDateTextBox.Enabled = false;
            this.fileDateTextBox.Location = new System.Drawing.Point(257, 419);
            this.fileDateTextBox.Name = "fileDateTextBox";
            this.fileDateTextBox.Size = new System.Drawing.Size(391, 31);
            this.fileDateTextBox.TabIndex = 5;
            this.fileDateTextBox.Text = "fileDate";
            // 
            // fileLengthLabel
            // 
            this.fileLengthLabel.Location = new System.Drawing.Point(257, 482);
            this.fileLengthLabel.Name = "fileLengthLabel";
            this.fileLengthLabel.Size = new System.Drawing.Size(391, 32);
            this.fileLengthLabel.TabIndex = 6;
            this.fileLengthLabel.Text = "fileLength";
            // 
            // uidLabel
            // 
            this.uidLabel.Location = new System.Drawing.Point(290, 741);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(68, 43);
            this.uidLabel.TabIndex = 7;
            this.uidLabel.Text = "UID";
            this.uidLabel.Visible = false;
            // 
            // gidTextBox
            // 
            this.gidTextBox.Location = new System.Drawing.Point(153, 741);
            this.gidTextBox.MaxLength = 4;
            this.gidTextBox.Name = "gidTextBox";
            this.gidTextBox.Size = new System.Drawing.Size(104, 31);
            this.gidTextBox.TabIndex = 8;
            this.gidTextBox.Text = "GID";
            this.gidTextBox.Visible = false;
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(377, 741);
            this.uidTextBox.MaxLength = 4;
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(101, 31);
            this.uidTextBox.TabIndex = 9;
            this.uidTextBox.Text = "UID";
            this.uidTextBox.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(33, 565);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(104, 48);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Kiểu:";
            // 
            // dirCheckBox
            // 
            this.dirCheckBox.Checked = true;
            this.dirCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dirCheckBox.Enabled = false;
            this.dirCheckBox.Location = new System.Drawing.Point(262, 554);
            this.dirCheckBox.Name = "dirCheckBox";
            this.dirCheckBox.Size = new System.Drawing.Size(160, 48);
            this.dirCheckBox.TabIndex = 11;
            this.dirCheckBox.Text = "Thư mục";
            // 
            // linkCheckBox
            // 
            this.linkCheckBox.Enabled = false;
            this.linkCheckBox.Location = new System.Drawing.Point(487, 734);
            this.linkCheckBox.Name = "linkCheckBox";
            this.linkCheckBox.Size = new System.Drawing.Size(135, 48);
            this.linkCheckBox.TabIndex = 12;
            this.linkCheckBox.Text = "Link";
            this.linkCheckBox.Visible = false;
            // 
            // devCheckBox
            // 
            this.devCheckBox.Enabled = false;
            this.devCheckBox.Location = new System.Drawing.Point(657, 734);
            this.devCheckBox.Name = "devCheckBox";
            this.devCheckBox.Size = new System.Drawing.Size(135, 48);
            this.devCheckBox.TabIndex = 13;
            this.devCheckBox.Text = "Dev";
            this.devCheckBox.Visible = false;
            // 
            // userAccessLabel
            // 
            this.userAccessLabel.Location = new System.Drawing.Point(7, 613);
            this.userAccessLabel.Name = "userAccessLabel";
            this.userAccessLabel.Size = new System.Drawing.Size(221, 46);
            this.userAccessLabel.TabIndex = 14;
            this.userAccessLabel.Text = "User access rights:";
            this.userAccessLabel.Visible = false;
            // 
            // rUserCheckBox
            // 
            this.rUserCheckBox.Checked = true;
            this.rUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rUserCheckBox.Location = new System.Drawing.Point(313, 613);
            this.rUserCheckBox.Name = "rUserCheckBox";
            this.rUserCheckBox.Size = new System.Drawing.Size(69, 46);
            this.rUserCheckBox.TabIndex = 15;
            this.rUserCheckBox.Text = "r";
            this.rUserCheckBox.Visible = false;
            // 
            // wUserCheckBox
            // 
            this.wUserCheckBox.Checked = true;
            this.wUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wUserCheckBox.Location = new System.Drawing.Point(417, 613);
            this.wUserCheckBox.Name = "wUserCheckBox";
            this.wUserCheckBox.Size = new System.Drawing.Size(66, 46);
            this.wUserCheckBox.TabIndex = 16;
            this.wUserCheckBox.Text = "w";
            this.wUserCheckBox.Visible = false;
            // 
            // xUserCheckBox
            // 
            this.xUserCheckBox.Checked = true;
            this.xUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xUserCheckBox.Location = new System.Drawing.Point(518, 613);
            this.xUserCheckBox.Name = "xUserCheckBox";
            this.xUserCheckBox.Size = new System.Drawing.Size(69, 46);
            this.xUserCheckBox.TabIndex = 17;
            this.xUserCheckBox.Text = "x";
            this.xUserCheckBox.Visible = false;
            // 
            // YcrienTerZ
            // 
            this.YcrienTerZ.Checked = true;
            this.YcrienTerZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.YcrienTerZ.Location = new System.Drawing.Point(518, 691);
            this.YcrienTerZ.Name = "YcrienTerZ";
            this.YcrienTerZ.Size = new System.Drawing.Size(69, 48);
            this.YcrienTerZ.TabIndex = 21;
            this.YcrienTerZ.Text = "x";
            this.YcrienTerZ.Visible = false;
            // 
            // wGroupCheckBox
            // 
            this.wGroupCheckBox.Checked = true;
            this.wGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wGroupCheckBox.Location = new System.Drawing.Point(417, 691);
            this.wGroupCheckBox.Name = "wGroupCheckBox";
            this.wGroupCheckBox.Size = new System.Drawing.Size(66, 48);
            this.wGroupCheckBox.TabIndex = 20;
            this.wGroupCheckBox.Text = "w";
            this.wGroupCheckBox.Visible = false;
            // 
            // rGroupCheckBox
            // 
            this.rGroupCheckBox.Checked = true;
            this.rGroupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rGroupCheckBox.Location = new System.Drawing.Point(313, 691);
            this.rGroupCheckBox.Name = "rGroupCheckBox";
            this.rGroupCheckBox.Size = new System.Drawing.Size(69, 48);
            this.rGroupCheckBox.TabIndex = 19;
            this.rGroupCheckBox.Text = "r";
            this.rGroupCheckBox.Visible = false;
            // 
            // groupAccessLabel
            // 
            this.groupAccessLabel.Location = new System.Drawing.Point(7, 691);
            this.groupAccessLabel.Name = "groupAccessLabel";
            this.groupAccessLabel.Size = new System.Drawing.Size(240, 48);
            this.groupAccessLabel.TabIndex = 18;
            this.groupAccessLabel.Text = "Group access rights:";
            this.groupAccessLabel.Visible = false;
            // 
            // xWorldCheckBox
            // 
            this.xWorldCheckBox.Checked = true;
            this.xWorldCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xWorldCheckBox.Location = new System.Drawing.Point(518, 770);
            this.xWorldCheckBox.Name = "xWorldCheckBox";
            this.xWorldCheckBox.Size = new System.Drawing.Size(69, 48);
            this.xWorldCheckBox.TabIndex = 25;
            this.xWorldCheckBox.Text = "x";
            this.xWorldCheckBox.Visible = false;
            // 
            // yAoijawLxy
            // 
            this.yAoijawLxy.Checked = true;
            this.yAoijawLxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yAoijawLxy.Location = new System.Drawing.Point(417, 770);
            this.yAoijawLxy.Name = "yAoijawLxy";
            this.yAoijawLxy.Size = new System.Drawing.Size(66, 48);
            this.yAoijawLxy.TabIndex = 24;
            this.yAoijawLxy.Text = "w";
            this.yAoijawLxy.Visible = false;
            // 
            // rWorldCheckBox
            // 
            this.rWorldCheckBox.Checked = true;
            this.rWorldCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rWorldCheckBox.Location = new System.Drawing.Point(313, 770);
            this.rWorldCheckBox.Name = "rWorldCheckBox";
            this.rWorldCheckBox.Size = new System.Drawing.Size(69, 48);
            this.rWorldCheckBox.TabIndex = 23;
            this.rWorldCheckBox.Text = "r";
            this.rWorldCheckBox.Visible = false;
            // 
            // worldAccessLabel
            // 
            this.worldAccessLabel.Location = new System.Drawing.Point(7, 770);
            this.worldAccessLabel.Name = "worldAccessLabel";
            this.worldAccessLabel.Size = new System.Drawing.Size(240, 48);
            this.worldAccessLabel.TabIndex = 22;
            this.worldAccessLabel.Text = "World access rights:";
            this.worldAccessLabel.Visible = false;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(217, 154);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(185, 57);
            this.okButton.TabIndex = 26;
            this.okButton.Text = "OK";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(467, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(181, 57);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            // 
            // ModifyLinuxDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(807, 375);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.xWorldCheckBox);
            this.Controls.Add(this.yAoijawLxy);
            this.Controls.Add(this.rWorldCheckBox);
            this.Controls.Add(this.worldAccessLabel);
            this.Controls.Add(this.YcrienTerZ);
            this.Controls.Add(this.wGroupCheckBox);
            this.Controls.Add(this.rGroupCheckBox);
            this.Controls.Add(this.groupAccessLabel);
            this.Controls.Add(this.xUserCheckBox);
            this.Controls.Add(this.wUserCheckBox);
            this.Controls.Add(this.rUserCheckBox);
            this.Controls.Add(this.userAccessLabel);
            this.Controls.Add(this.devCheckBox);
            this.Controls.Add(this.linkCheckBox);
            this.Controls.Add(this.dirCheckBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.gidTextBox);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.fileLengthLabel);
            this.Controls.Add(this.fileDateTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.gidLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.modificationDateLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(833, 960);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 370);
            this.Name = "ModifyLinuxDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo thư mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x060001C6 RID: 454 RVA: 0x0001C30C File Offset: 0x0001A50C
        [STAThread]
        private static void smethod_0()
        {
            Form form = new Form();
            form.Text = "ModifyLinuxDialog Test";
            form.Size = new Size(600, 400);
            form.Visible = true;
            ModifyLinuxDialog modifyLinuxDialog = new ModifyLinuxDialog(true, "testFileName", "testFileDate", "testFileLength", "uid", "gid", "-r---w---x");
            modifyLinuxDialog.ShowDialog();
        }

        // Token: 0x060001C7 RID: 455 RVA: 0x00002D3E File Offset: 0x00000F3E
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!this.string_0.Equals(this.Access))
            {
                ModifyLinuxDialog.bool_0 = true;
            }
        }

        // Token: 0x060001C8 RID: 456 RVA: 0x0001C374 File Offset: 0x0001A574
        private void dirCheckBox_Click(object sender, EventArgs e)
        {
            this.linkCheckBox.Checked = !this.dirCheckBox.Checked;
            if (this.linkCheckBox.Checked)
            {
                this.modificationDateLabel.Text = "Symlink target:";
                this.fileDateTextBox.Enabled = true;
                this.fileDateTextBox.Text = "";
                this.fileDateTextBox.Visible = true;
                this.fileDateTextBox.Focus();
            }
            else
            {
                this.modificationDateLabel.Text = "Modification date:";
                this.fileDateTextBox.Enabled = false;
                this.fileDateTextBox.Text = "";
                this.fileNameTextBox.Focus();
            }
        }

        // Token: 0x060001C9 RID: 457 RVA: 0x0001C428 File Offset: 0x0001A628
        private void linkCheckBox_Click(object sender, EventArgs e)
        {
            this.dirCheckBox.Checked = !this.linkCheckBox.Checked;
            if (this.linkCheckBox.Checked)
            {
                this.modificationDateLabel.Text = "Symlink target:";
                this.fileDateTextBox.Enabled = true;
                this.fileDateTextBox.Text = "";
                this.fileDateTextBox.Focus();
            }
            else
            {
                this.modificationDateLabel.Text = "Modification date:";
                this.fileDateTextBox.Enabled = false;
                this.fileDateTextBox.Text = "";
                this.fileDateTextBox.Visible = true;
                this.fileNameTextBox.Focus();
            }
        }

        // Token: 0x060001CA RID: 458 RVA: 0x000022A9 File Offset: 0x000004A9
        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060001CB RID: 459 RVA: 0x000022A9 File Offset: 0x000004A9
        private void ModifyLinuxDialog_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x060001CC RID: 460 RVA: 0x00002D59 File Offset: 0x00000F59
      

        // Token: 0x04000170 RID: 368
        private Label nameLabel;

        // Token: 0x04000171 RID: 369
        private Label modificationDateLabel;

        // Token: 0x04000172 RID: 370
        private Label lengthLabel;

        // Token: 0x04000173 RID: 371
        private Label gidLabel;

        // Token: 0x04000174 RID: 372
        private TextBox fileNameTextBox;

        // Token: 0x04000175 RID: 373
        private TextBox fileDateTextBox;

        // Token: 0x04000176 RID: 374
        private Label fileLengthLabel;

        // Token: 0x04000177 RID: 375
        private Label uidLabel;

        // Token: 0x04000178 RID: 376
        private TextBox gidTextBox;

        // Token: 0x04000179 RID: 377
        private TextBox uidTextBox;

        // Token: 0x0400017A RID: 378
        private Label typeLabel;

        // Token: 0x0400017B RID: 379
        private CheckBox dirCheckBox;

        // Token: 0x0400017C RID: 380
        private CheckBox linkCheckBox;

        // Token: 0x0400017D RID: 381
        private CheckBox devCheckBox;

        // Token: 0x0400017E RID: 382
        private Label userAccessLabel;

        // Token: 0x0400017F RID: 383
        private CheckBox rUserCheckBox;

        // Token: 0x04000180 RID: 384
        private CheckBox wUserCheckBox;

        // Token: 0x04000181 RID: 385
        private CheckBox xUserCheckBox;

        // Token: 0x04000182 RID: 386
        private CheckBox YcrienTerZ;

        // Token: 0x04000183 RID: 387
        private CheckBox wGroupCheckBox;

        // Token: 0x04000184 RID: 388
        private CheckBox rGroupCheckBox;

        // Token: 0x04000185 RID: 389
        private Label groupAccessLabel;

        // Token: 0x04000186 RID: 390
        private CheckBox xWorldCheckBox;

        // Token: 0x04000187 RID: 391
        private CheckBox yAoijawLxy;

        // Token: 0x04000188 RID: 392
        private CheckBox rWorldCheckBox;

        // Token: 0x04000189 RID: 393
        private Label worldAccessLabel;

        // Token: 0x0400018A RID: 394
        private Button okButton;

        // Token: 0x0400018B RID: 395
        private Button cancelButton;

        // Token: 0x0400018C RID: 396
        private Container container_0;

        // Token: 0x0400018D RID: 397
        private static bool bool_0;

        // Token: 0x0400018E RID: 398
        private string string_0;
    }
}