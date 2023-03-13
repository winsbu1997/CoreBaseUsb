using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AxSHDocVw;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.GUI
{
    partial class HelpBox
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

        // Token: 0x0600012A RID: 298 RVA: 0x000151A4 File Offset: 0x000133A4
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpBox));
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.overviewToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.previousToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.nextToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.closeToolBarButton = new System.Windows.Forms.ToolBarButton();
            this.panelWebBrowser = new System.Windows.Forms.Panel();
            this.axWebBrowser_0 = new AxSHDocVw.AxWebBrowser();
            this.panelToolbar.SuspendLayout();
            this.panelWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser_0)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_0
            // 
            this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.toolBar);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(738, 101);
            this.panelToolbar.TabIndex = 1;
            // 
            // toolBar
            // 
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.overviewToolBarButton,
            this.previousToolBarButton,
            this.nextToolBarButton,
            this.closeToolBarButton});
            this.toolBar.ButtonSize = new System.Drawing.Size(60, 52);
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.imageList_0;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(738, 54);
            this.toolBar.TabIndex = 1;
            // 
            // overviewToolBarButton
            // 
            this.overviewToolBarButton.ImageIndex = 0;
            this.overviewToolBarButton.Name = "overviewToolBarButton";
            this.overviewToolBarButton.Text = "Overview";
            this.overviewToolBarButton.ToolTipText = "Overview";
            // 
            // previousToolBarButton
            // 
            this.previousToolBarButton.ImageIndex = 1;
            this.previousToolBarButton.Name = "previousToolBarButton";
            this.previousToolBarButton.Text = "Previous";
            this.previousToolBarButton.ToolTipText = "Previous";
            // 
            // nextToolBarButton
            // 
            this.nextToolBarButton.ImageIndex = 2;
            this.nextToolBarButton.Name = "nextToolBarButton";
            this.nextToolBarButton.Text = "Next";
            this.nextToolBarButton.ToolTipText = "Next";
            // 
            // closeToolBarButton
            // 
            this.closeToolBarButton.ImageIndex = 3;
            this.closeToolBarButton.Name = "closeToolBarButton";
            this.closeToolBarButton.Text = "Close";
            this.closeToolBarButton.ToolTipText = "Close";
            // 
            // panelWebBrowser
            // 
            this.panelWebBrowser.Controls.Add(this.axWebBrowser_0);
            this.panelWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebBrowser.Location = new System.Drawing.Point(0, 101);
            this.panelWebBrowser.Name = "panelWebBrowser";
            this.panelWebBrowser.Size = new System.Drawing.Size(738, 288);
            this.panelWebBrowser.TabIndex = 2;
            // 
            // axWebBrowser_0
            // 
            this.axWebBrowser_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWebBrowser_0.Enabled = true;
            this.axWebBrowser_0.Location = new System.Drawing.Point(0, 0);
            this.axWebBrowser_0.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser_0.OcxState")));
            this.axWebBrowser_0.Size = new System.Drawing.Size(738, 288);
            this.axWebBrowser_0.TabIndex = 1;
            // 
            // HelpBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(738, 389);
            this.Controls.Add(this.panelWebBrowser);
            this.Controls.Add(this.panelToolbar);
            this.Name = "HelpBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "USBTOOLS Help";
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelWebBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWebBrowser_0)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x0600012B RID: 299 RVA: 0x000156C0 File Offset: 0x000138C0
        private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Equals(this.previousToolBarButton))
            {
                this.int_1--;
                if (this.int_1 == 0)
                {
                    this.previousToolBarButton.Enabled = false;
                }
                this.JjcfnNebjy.Enabled = true;
                this.method_0();
            }
            else if (e.Button.Equals(this.JjcfnNebjy))
            {
                this.int_1++;
                if (this.int_1 == HelpBox.int_0 - 1)
                {
                    this.JjcfnNebjy.Enabled = false;
                }
                this.previousToolBarButton.Enabled = true;
                this.method_0();
            }
            else if (e.Button.Equals(this.overviewToolBarButton))
            {
                this.int_1 = 0;
                this.previousToolBarButton.Enabled = false;
                this.JjcfnNebjy.Enabled = true;
                this.method_0();
            }
            else if (e.Button.Equals(this.closeToolBarButton))
            {
                base.Visible = false;
            }
        }

        // Token: 0x0600012C RID: 300 RVA: 0x000157D4 File Offset: 0x000139D4
        private void axWebBrowser_0_DownloadComplete(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.axWebBrowser_0.LocationURL);
            if (uri.ToString() == this.uri_0[0].ToString())
            {
                this.previousToolBarButton.Enabled = false;
                this.JjcfnNebjy.Enabled = true;
                this.int_1 = 0;
            }
            if (uri.ToString() == this.uri_0[1].ToString())
            {
                this.previousToolBarButton.Enabled = true;
                this.JjcfnNebjy.Enabled = true;
                this.int_1 = 1;
            }
            if (uri.ToString() == this.uri_0[2].ToString())
            {
                this.previousToolBarButton.Enabled = true;
                this.JjcfnNebjy.Enabled = true;
                this.int_1 = 2;
            }
            if (uri.ToString() == this.uri_0[3].ToString())
            {
                this.previousToolBarButton.Enabled = true;
                this.JjcfnNebjy.Enabled = false;
                this.int_1 = 3;
            }
        }

        // Token: 0x0600012D RID: 301 RVA: 0x000158E4 File Offset: 0x00013AE4
        private void method_0()
        {
            object obj = 0;
            string text = "";
            object obj2 = text;
            this.axWebBrowser_0.Navigate(this.uri_0[this.int_1].ToString(), ref obj, ref obj2, ref obj2, ref obj2);
        }

        // Token: 0x0600012E RID: 302 RVA: 0x000028AF File Offset: 0x00000AAF
        private void HelpBox_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            base.Visible = false;
        }

        // Token: 0x0600012F RID: 303 RVA: 0x000028BF File Offset: 0x00000ABF
        static HelpBox()
        {
            Class3.vd4OXo2zYFEgU();
            HelpBox.int_0 = 4;
        }

        // Token: 0x040000E0 RID: 224
        private ImageList imageList_0;

        // Token: 0x040000E1 RID: 225
        private IContainer icontainer_0;

        // Token: 0x040000E2 RID: 226
        private Panel panelToolbar;

        // Token: 0x040000E3 RID: 227
        private ToolBar toolBar;

        // Token: 0x040000E4 RID: 228
        private ToolBarButton overviewToolBarButton;

        // Token: 0x040000E5 RID: 229
        private ToolBarButton previousToolBarButton;

        // Token: 0x040000E6 RID: 230
        private ToolBarButton JjcfnNebjy;

        // Token: 0x040000E7 RID: 231
        private ToolBarButton closeToolBarButton;

        // Token: 0x040000E8 RID: 232
        private Panel panelWebBrowser;

        // Token: 0x040000E9 RID: 233
        private AxWebBrowser axWebBrowser_0;

        // Token: 0x040000EA RID: 234
        private static int int_0;

        // Token: 0x040000EB RID: 235
        private Uri[] uri_0;

        // Token: 0x040000EC RID: 236
        private int int_1;
        private ToolBarButton nextToolBarButton;
    }
}