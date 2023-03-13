using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class PartitionsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.container_0 != null)
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060001D8 RID: 472 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
        private void InitializeComponent()
        {
            this.labelPartitions = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelIconLabel = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelIconLabel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPartitions
            // 
            this.labelPartitions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartitions.Location = new System.Drawing.Point(134, 39);
            this.labelPartitions.Name = "labelPartitions";
            this.labelPartitions.Size = new System.Drawing.Size(670, 90);
            this.labelPartitions.TabIndex = 0;
            this.labelPartitions.Text = "label";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 90);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(302, 15);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(200, 46);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            // 
            // panelIconLabel
            // 
            this.panelIconLabel.Controls.Add(this.pictureBox);
            this.panelIconLabel.Controls.Add(this.labelPartitions);
            this.panelIconLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIconLabel.Location = new System.Drawing.Point(0, 0);
            this.panelIconLabel.Name = "panelIconLabel";
            this.panelIconLabel.Size = new System.Drawing.Size(870, 317);
            this.panelIconLabel.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Controls.Add(this.panelIconLabel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(870, 317);
            this.panelMain.TabIndex = 4;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.SystemColors.Control;
            this.panelButton.Controls.Add(this.buttonOK);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 240);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(870, 77);
            this.panelButton.TabIndex = 4;
            // 
            // PartitionsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(870, 317);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartitionsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "USB-BM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelIconLabel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Token: 0x04000199 RID: 409
        private Label labelPartitions;

        // Token: 0x0400019A RID: 410
        private Button buttonOK;

        // Token: 0x0400019B RID: 411
        private Panel panelIconLabel;

        // Token: 0x0400019C RID: 412
        private Panel panelMain;

        // Token: 0x0400019D RID: 413
        private Panel panelButton;

        // Token: 0x0400019E RID: 414
        private PictureBox pictureBox;

        // Token: 0x0400019F RID: 415
        private Container container_0;
    }
}