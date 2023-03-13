using System;
using System.ComponentModel;
using System.Drawing;
using CoreBaseUsb.Utilities;
using System.Windows.Forms;
namespace CoreBaseUsb.GUI
{
    partial class ModifyDosDialog
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

        // Token: 0x17000036 RID: 54
        // (get) Token: 0x060001B0 RID: 432 RVA: 0x00002C9F File Offset: 0x00000E9F
        public bool IsReadOnly
        {
            get
            {
                return this.readOnlyCheckBox.Checked;
            }
        }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x060001B1 RID: 433 RVA: 0x00002CAC File Offset: 0x00000EAC
        public bool IsHidden
        {
            get
            {
                return this.hiddenCheckBox.Checked;
            }
        }

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x060001B2 RID: 434 RVA: 0x00002CB9 File Offset: 0x00000EB9
        public bool IsSystem
        {
            get
            {
                return this.systemCheckBox.Checked;
            }
        }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x060001B3 RID: 435 RVA: 0x00002CC6 File Offset: 0x00000EC6
        public bool IsDirectory
        {
            get
            {
                return this.directoryCheckBox.Checked;
            }
        }

        // Token: 0x060001B4 RID: 436 RVA: 0x0001A5F4 File Offset: 0x000187F4
       

        // Token: 0x060001B5 RID: 437 RVA: 0x00002CD3 File Offset: 0x00000ED3
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.container_0 != null)
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060001B6 RID: 438 RVA: 0x0001A69C File Offset: 0x0001889C
        [STAThread]
        private static void smethod_0()
        {
            Form form = new Form();
            form.Text = "ModifyDosDialog Test";
            form.Size = new Size(600, 400);
            form.Visible = true;
            ModifyDosDialog modifyDosDialog = new ModifyDosDialog(false, "testFileName", "testFileDate", "testFileLength", false, true, true, true);
            modifyDosDialog.ShowDialog();
            MessageBox.Show(string.Concat(new object[]
            {
                "fileName: ",
                modifyDosDialog.FileName,
                "\nisDirectory: ",
                modifyDosDialog.IsDirectory,
                "\nisReadOnly: ",
                modifyDosDialog.IsReadOnly,
                "\nisHidden: ",
                modifyDosDialog.IsHidden,
                "\nisSystem: ",
                modifyDosDialog.IsSystem
            }));
        }

        // Token: 0x060001B7 RID: 439 RVA: 0x0001A778 File Offset: 0x00018978
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.modificationDateLabel = new System.Windows.Forms.Label();
            this.AdfFhqOixE = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.fileLengthLabel = new System.Windows.Forms.Label();
            this.directoryCheckBox = new System.Windows.Forms.CheckBox();
            this.readOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.systemCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(28, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(225, 30);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Tên thư mục";
            // 
            // modificationDateLabel
            // 
            this.modificationDateLabel.Location = new System.Drawing.Point(32, 336);
            this.modificationDateLabel.Name = "modificationDateLabel";
            this.modificationDateLabel.Size = new System.Drawing.Size(225, 30);
            this.modificationDateLabel.TabIndex = 1;
            this.modificationDateLabel.Text = "Ngày:";
            // 
            // AdfFhqOixE
            // 
            this.AdfFhqOixE.Location = new System.Drawing.Point(32, 395);
            this.AdfFhqOixE.Name = "AdfFhqOixE";
            this.AdfFhqOixE.Size = new System.Drawing.Size(225, 31);
            this.AdfFhqOixE.TabIndex = 2;
            this.AdfFhqOixE.Text = "Kích thước (B):";
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(478, 461);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(225, 30);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Kiểu:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(182, 56);
            this.fileNameTextBox.MaxLength = 255;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(431, 31);
            this.fileNameTextBox.TabIndex = 4;
            this.fileNameTextBox.Text = "fileName";
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.Location = new System.Drawing.Point(272, 336);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(431, 45);
            this.fileDateLabel.TabIndex = 5;
            this.fileDateLabel.Text = "fileDate";
            // 
            // fileLengthLabel
            // 
            this.fileLengthLabel.Location = new System.Drawing.Point(272, 395);
            this.fileLengthLabel.Name = "fileLengthLabel";
            this.fileLengthLabel.Size = new System.Drawing.Size(431, 45);
            this.fileLengthLabel.TabIndex = 6;
            this.fileLengthLabel.Text = "fileLength";
            // 
            // directoryCheckBox
            // 
            this.directoryCheckBox.Enabled = false;
            this.directoryCheckBox.Location = new System.Drawing.Point(292, 446);
            this.directoryCheckBox.Name = "directoryCheckBox";
            this.directoryCheckBox.Size = new System.Drawing.Size(176, 45);
            this.directoryCheckBox.TabIndex = 7;
            this.directoryCheckBox.Text = "Thư mục";
            // 
            // readOnlyCheckBox
            // 
            this.readOnlyCheckBox.Location = new System.Drawing.Point(85, 483);
            this.readOnlyCheckBox.Name = "readOnlyCheckBox";
            this.readOnlyCheckBox.Size = new System.Drawing.Size(208, 45);
            this.readOnlyCheckBox.TabIndex = 8;
            this.readOnlyCheckBox.Text = "Chỉ đọc";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(248, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(155, 56);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(458, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 56);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            // 
            // hiddenCheckBox
            // 
            this.hiddenCheckBox.Location = new System.Drawing.Point(292, 483);
            this.hiddenCheckBox.Name = "hiddenCheckBox";
            this.hiddenCheckBox.Size = new System.Drawing.Size(176, 45);
            this.hiddenCheckBox.TabIndex = 9;
            this.hiddenCheckBox.Text = "Ẩn";
            // 
            // systemCheckBox
            // 
            this.systemCheckBox.Location = new System.Drawing.Point(88, 426);
            this.systemCheckBox.Name = "systemCheckBox";
            this.systemCheckBox.Size = new System.Drawing.Size(194, 44);
            this.systemCheckBox.TabIndex = 10;
            this.systemCheckBox.Text = "System";
            this.systemCheckBox.Visible = false;
            // 
            // ModifyDosDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(747, 257);
            this.Controls.Add(this.systemCheckBox);
            this.Controls.Add(this.hiddenCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.readOnlyCheckBox);
            this.Controls.Add(this.directoryCheckBox);
            this.Controls.Add(this.fileLengthLabel);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.AdfFhqOixE);
            this.Controls.Add(this.modificationDateLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(833, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(167, 160);
            this.Name = "ModifyDosDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo thư mục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x060001B8 RID: 440 RVA: 0x000022A9 File Offset: 0x000004A9
        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060001B9 RID: 441 RVA: 0x000022A9 File Offset: 0x000004A9
        private void okButton_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x060001BA RID: 442 RVA: 0x000022A9 File Offset: 0x000004A9
        private void cancelButton_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x04000162 RID: 354
        private Label nameLabel;

        // Token: 0x04000163 RID: 355
        private Label modificationDateLabel;

        // Token: 0x04000164 RID: 356
        private Label AdfFhqOixE;

        // Token: 0x04000165 RID: 357
        private Label typeLabel;

        // Token: 0x04000166 RID: 358
        private Label fileDateLabel;

        // Token: 0x04000167 RID: 359
        private Label fileLengthLabel;

        // Token: 0x04000168 RID: 360
        private TextBox fileNameTextBox;

        // Token: 0x04000169 RID: 361
        private CheckBox directoryCheckBox;

        // Token: 0x0400016A RID: 362
        private CheckBox readOnlyCheckBox;

        // Token: 0x0400016B RID: 363
        private CheckBox hiddenCheckBox;

        // Token: 0x0400016C RID: 364
        private CheckBox systemCheckBox;

        // Token: 0x0400016D RID: 365
        private Button okButton;

        // Token: 0x0400016E RID: 366
        private Button cancelButton;

        // Token: 0x0400016F RID: 367
        private Container container_0;
    }
}