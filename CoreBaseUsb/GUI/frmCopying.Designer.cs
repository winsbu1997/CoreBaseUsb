using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class frmCopying
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060000EE RID: 238 RVA: 0x00011BC4 File Offset: 0x0000FDC4
        private void InitializeComponent()
        {
            this.lblCopy = new Label();
            base.SuspendLayout();
            this.lblCopy.BackColor = Color.FromArgb(255, 224, 192);
            this.lblCopy.FlatStyle = FlatStyle.Popup;
            this.lblCopy.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.lblCopy.ForeColor = Color.FromArgb(0, 0, 192);
            this.lblCopy.Location = new Point(120, 26);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new Size(213, 26);
            this.lblCopy.TabIndex = 44;
            this.lblCopy.Text = "Đang xử lý dữ liệu...";
            this.lblCopy.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(455, 196);
            base.ControlBox = false;
            base.Controls.Add(this.lblCopy);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "frmCopying";
            base.StartPosition = FormStartPosition.CenterParent;
            base.ResumeLayout(false);
        }

        // Token: 0x040000A6 RID: 166
        private IContainer icontainer_0;

        // Token: 0x040000A7 RID: 167
        public Label lblCopy;
    }
}