using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CoreBaseUsb.RAW;

namespace CoreBaseUsb.GUI
{
    partial class frmStatusBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


    // Token: 0x060000F7 RID: 247 RVA: 0x000026F4 File Offset: 0x000008F4
    private void timer_0_Tick(object sender, EventArgs e)
    {
        if (this.int_0 < (int)usbpublic.FILE_SIZE / 1700000)
        {
            this.progressBar1.PerformStep();
            this.int_0++;
        }
    }

    // Token: 0x060000F8 RID: 248 RVA: 0x000124D8 File Offset: 0x000106D8
    private void frmStatusBar_Load(object sender, EventArgs e)
    {
        this.int_0 = 0;
        if (usbpublic.FILE_SIZE / 1700000L >= 2L)
        {
            this.progressBar1.Maximum = (int)usbpublic.FILE_SIZE / 1700000;
            this.progressBar1.Step = 1;
            this.progressBar1.Value = 1;
            this.timer_0.Interval = 1000;
            this.timer_0.Enabled = true;
            Application.DoEvents();
        }
    }

    // Token: 0x060000F9 RID: 249 RVA: 0x00002728 File Offset: 0x00000928
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    // Token: 0x060000FA RID: 250 RVA: 0x0001255C File Offset: 0x0001075C
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 1000;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(10, 85);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(574, 35);
            this.progressBar1.TabIndex = 4;
            // 
            // frmStatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 131);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmStatusBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

    }

    // Token: 0x040000B5 RID: 181
    private int int_0;

    // Token: 0x040000B6 RID: 182
    private IContainer icontainer_0;

    // Token: 0x040000B7 RID: 183
    private Timer timer_0;

    // Token: 0x040000B8 RID: 184
    private ProgressBar progressBar1;
    }
}