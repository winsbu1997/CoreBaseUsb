using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CoreBaseUsb.Utilities;
namespace CoreBaseUsb.GUI
{
    partial class MyDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public static string SeparatorLine
        {
            get
            {
                return "\r\n##############################################################\r\n";
            }
        }

        // Token: 0x060001CF RID: 463 RVA: 0x00002D66 File Offset: 0x00000F66
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060001D0 RID: 464 RVA: 0x0001C53C File Offset: 0x0001A73C
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.debugOutput = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.IdMiSbnVpx = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu_0 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem_0 = new System.Windows.Forms.MenuItem();
            this.menuItem_1 = new System.Windows.Forms.MenuItem();
            this.menuItem_2 = new System.Windows.Forms.MenuItem();
            this.menuItem_3 = new System.Windows.Forms.MenuItem();
            this.panelMain.SuspendLayout();
            this.textBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugOutput
            // 
            this.debugOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugOutput.Location = new System.Drawing.Point(0, 0);
            this.debugOutput.Multiline = true;
            this.debugOutput.Name = "debugOutput";
            this.debugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugOutput.Size = new System.Drawing.Size(849, 401);
            this.debugOutput.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.textBoxPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(849, 401);
            this.panelMain.TabIndex = 1;
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.Controls.Add(this.debugOutput);
            this.textBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Size = new System.Drawing.Size(849, 401);
            this.textBoxPanel.TabIndex = 2;
            // 
            // IdMiSbnVpx
            // 
            this.IdMiSbnVpx.DefaultExt = "txt";
            this.IdMiSbnVpx.FileName = "debugOutput";
            this.IdMiSbnVpx.Filter = "Text files|*.txt|All files|*.*";
            this.IdMiSbnVpx.Title = "Save file to";
            // 
            // mainMenu_0
            // 
            this.mainMenu_0.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_0});
            // 
            // menuItem_0
            // 
            this.menuItem_0.Index = 0;
            this.menuItem_0.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_1,
            this.menuItem_2,
            this.menuItem_3});
            this.menuItem_0.Text = "File";
            // 
            // menuItem_1
            // 
            this.menuItem_1.Index = 0;
            this.menuItem_1.Text = "Save As ...";
            // 
            // menuItem_2
            // 
            this.menuItem_2.Index = 1;
            this.menuItem_2.Text = "Clear TextBox";
            // 
            // menuItem_3
            // 
            this.menuItem_3.Index = 2;
            this.menuItem_3.Text = "Close Debug Dialog";
            // 
            // MyDebug
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(849, 401);
            this.Controls.Add(this.panelMain);
            this.Location = new System.Drawing.Point(10, 10);
            this.Menu = this.mainMenu_0;
            this.Name = "MyDebug";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "USBTOOLS debug output";
            this.panelMain.ResumeLayout(false);
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x060001D1 RID: 465 RVA: 0x00002D8B File Offset: 0x00000F8B
        public void AppendText(string str)
        {
            this.debugOutput.AppendText(str);
        }

        // Token: 0x060001D2 RID: 466 RVA: 0x000028AF File Offset: 0x00000AAF
        private void MyDebug_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            base.Visible = false;
        }

        // Token: 0x060001D3 RID: 467 RVA: 0x0001C938 File Offset: 0x0001AB38
        private void menuItem_1_Click(object sender, EventArgs e)
        {
            try
            {
                Stream stream;
                if (this.IdMiSbnVpx.ShowDialog() == DialogResult.OK && (stream = this.IdMiSbnVpx.OpenFile()) != null)
                {
                    StreamWriter streamWriter = new StreamWriter(stream);
                    streamWriter.Write(this.debugOutput.Text);
                    streamWriter.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                this.debugOutput.AppendText(string.Concat(new string[]
                {
                    ex.Message,
                    MyDebug.SeparatorLine,
                    ex.Source,
                    MyDebug.SeparatorLine,
                    ex.StackTrace
                }));
            }
        }

        // Token: 0x060001D4 RID: 468 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
        private void menuItem_2_Click(object sender, EventArgs e)
        {
            this.debugOutput.Clear();
            this.debugOutput.Text = DateTime.Now.ToString() + MyDebug.SeparatorLine;
        }

        // Token: 0x060001D5 RID: 469 RVA: 0x00002D99 File Offset: 0x00000F99
        private void menuItem_3_Click(object sender, EventArgs e)
        {
            base.Visible = false;
        }

        // Token: 0x0400018F RID: 399
        private TextBox debugOutput;

        // Token: 0x04000190 RID: 400
        private Panel textBoxPanel;

        // Token: 0x04000191 RID: 401
        private SaveFileDialog IdMiSbnVpx;

        // Token: 0x04000192 RID: 402
        private Panel panelMain;

        // Token: 0x04000193 RID: 403
        private MainMenu mainMenu_0;

        // Token: 0x04000194 RID: 404
        private MenuItem menuItem_0;

        // Token: 0x04000195 RID: 405
        private MenuItem menuItem_1;

        // Token: 0x04000196 RID: 406
        private MenuItem menuItem_2;

        // Token: 0x04000197 RID: 407
        private MenuItem menuItem_3;

        // Token: 0x04000198 RID: 408
        private IContainer icontainer_0;
    }
}