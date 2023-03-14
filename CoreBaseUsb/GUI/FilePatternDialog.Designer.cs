using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    partial class FilePatternDialog
    {
        public string FilePattern
        {
            get
            {
                return this.textBoxFilePattern.Text;
            }
        }

        // Token: 0x060000EA RID: 234 RVA: 0x00011B68 File Offset: 0x0000FD68
       

        // Token: 0x060000EB RID: 235 RVA: 0x000025FC File Offset: 0x000007FC
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxFilePattern.Text = "*";
        }

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFilePattern = new System.Windows.Forms.Label();
            this.textBoxFilePattern = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(64, 142);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(212, 46);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(320, 142);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(214, 46);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            // 
            // labelFilePattern
            // 
            this.labelFilePattern.Location = new System.Drawing.Point(38, 48);
            this.labelFilePattern.Name = "labelFilePattern";
            this.labelFilePattern.Size = new System.Drawing.Size(136, 39);
            this.labelFilePattern.TabIndex = 2;
            this.labelFilePattern.Text = "File pattern:";
            this.labelFilePattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFilePattern
            // 
            this.textBoxFilePattern.Location = new System.Drawing.Point(208, 48);
            this.textBoxFilePattern.Name = "textBoxFilePattern";
            this.textBoxFilePattern.Size = new System.Drawing.Size(196, 31);
            this.textBoxFilePattern.TabIndex = 3;
            this.textBoxFilePattern.Text = "*";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(440, 48);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(118, 39);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            // 
            // FilePatternDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(657, 224);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxFilePattern);
            this.Controls.Add(this.labelFilePattern);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(834, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 218);
            this.Name = "FilePatternDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "USBTOOLS - File Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        [STAThread]
        public static void Main(string[] args)
        {
            string text = "*.txt";
            FilePatternDialog filePatternDialog = new FilePatternDialog(text, false);
            if (filePatternDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("FilePattern:\n" + filePatternDialog.FilePattern + "\nOK clicked");
            }
            else
            {
                MessageBox.Show("FilePattern:\n" + text + "\nCancel clicked");
            }
        }
        // Token: 0x040000A0 RID: 160
        private Button buttonOk;

        // Token: 0x040000A1 RID: 161
        private Button buttonCancel;

        // Token: 0x040000A2 RID: 162
        private Label labelFilePattern;

        // Token: 0x040000A3 RID: 163
        private TextBox textBoxFilePattern;

        // Token: 0x040000A4 RID: 164
        private Button buttonReset;

        // Token: 0x040000A5 RID: 165
        private Container container_0;
    }
}