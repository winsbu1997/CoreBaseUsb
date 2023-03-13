using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class frmProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void cmdOK_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        // Token: 0x060000F1 RID: 241 RVA: 0x000022A9 File Offset: 0x000004A9
        private void frmProperties_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x060000F2 RID: 242 RVA: 0x00002675 File Offset: 0x00000875
        public void ShowInfor(string sName, string sSize, string sTime, string sFilesCount, string sDirCount)
        {
            this.textPath.Text = sName;
            this.geLnAwDsZp.Text = sSize;
            this.textTimeEdit.Text = sTime;
            this.textFiles.Text = sFilesCount;
            this.textDirs.Text = sDirCount;
        }

        // Token: 0x060000F3 RID: 243 RVA: 0x000022A9 File Offset: 0x000004A9
        private void textTimeEdit_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060000F4 RID: 244 RVA: 0x000026B5 File Offset: 0x000008B5
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060000F5 RID: 245 RVA: 0x00011D10 File Offset: 0x0000FF10
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmProperties));
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.yomnUfBymP = new Label();
            this.cmdOK = new Button();
            this.textPath = new TextBox();
            this.geLnAwDsZp = new TextBox();
            this.label5 = new Label();
            this.textFiles = new TextBox();
            this.textDirs = new TextBox();
            this.label6 = new Label();
            this.textTimeEdit = new TextBox();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(10, 13);
            this.label1.Margin = new Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(10, 45);
            this.label2.Margin = new Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kích thước:";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(10, 99);
            this.label3.Margin = new Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số file:";
            this.label3.Visible = false;
            this.yomnUfBymP.AutoSize = true;
            this.yomnUfBymP.Location = new Point(10, 127);
            this.yomnUfBymP.Margin = new Padding(2, 0, 2, 0);
            this.yomnUfBymP.Name = "label4";
            this.yomnUfBymP.Size = new Size(64, 13);
            this.yomnUfBymP.TabIndex = 3;
            this.yomnUfBymP.Text = "Số thư mục:";
            this.yomnUfBymP.Visible = false;
            this.cmdOK.Location = new Point(186, 123);
            this.cmdOK.Margin = new Padding(2);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new Size(76, 32);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += this.cmdOK_Click;
            this.textPath.Location = new Point(89, 13);
            this.textPath.Margin = new Padding(2);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new Size(337, 20);
            this.textPath.TabIndex = 5;
            this.geLnAwDsZp.Location = new Point(89, 45);
            this.geLnAwDsZp.Margin = new Padding(2);
            this.geLnAwDsZp.Name = "textSize";
            this.geLnAwDsZp.ReadOnly = true;
            this.geLnAwDsZp.Size = new Size(130, 20);
            this.geLnAwDsZp.TabIndex = 6;
            this.geLnAwDsZp.TextAlign = HorizontalAlignment.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(238, 47);
            this.label5.Margin = new Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(Bytes)";
            this.textFiles.Location = new Point(89, 99);
            this.textFiles.Margin = new Padding(2);
            this.textFiles.Name = "textFiles";
            this.textFiles.ReadOnly = true;
            this.textFiles.Size = new Size(130, 20);
            this.textFiles.TabIndex = 8;
            this.textFiles.TextAlign = HorizontalAlignment.Right;
            this.textFiles.Visible = false;
            this.textDirs.Location = new Point(89, 127);
            this.textDirs.Margin = new Padding(2);
            this.textDirs.Name = "textDirs";
            this.textDirs.ReadOnly = true;
            this.textDirs.Size = new Size(130, 20);
            this.textDirs.TabIndex = 9;
            this.textDirs.TextAlign = HorizontalAlignment.Right;
            this.textDirs.Visible = false;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(10, 72);
            this.label6.Margin = new Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian ghi:";
            this.textTimeEdit.Location = new Point(89, 72);
            this.textTimeEdit.Margin = new Padding(2);
            this.textTimeEdit.Name = "textTimeEdit";
            this.textTimeEdit.ReadOnly = true;
            this.textTimeEdit.Size = new Size(130, 20);
            this.textTimeEdit.TabIndex = 11;
            this.textTimeEdit.TextAlign = HorizontalAlignment.Right;
            this.textTimeEdit.TextChanged += this.textTimeEdit_TextChanged;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(430, 175);
            base.Controls.Add(this.cmdOK);
            base.Controls.Add(this.textTimeEdit);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.textDirs);
            base.Controls.Add(this.textFiles);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.geLnAwDsZp);
            base.Controls.Add(this.textPath);
            base.Controls.Add(this.yomnUfBymP);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.Margin = new Padding(2);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmProperties";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Properties";
            base.Load += this.frmProperties_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x040000A8 RID: 168
        private IContainer icontainer_0;

        // Token: 0x040000A9 RID: 169
        private Label label1;

        // Token: 0x040000AA RID: 170
        private Label label2;

        // Token: 0x040000AB RID: 171
        private Label label3;

        // Token: 0x040000AC RID: 172
        private Label yomnUfBymP;

        // Token: 0x040000AD RID: 173
        private Button cmdOK;

        // Token: 0x040000AE RID: 174
        private TextBox textPath;

        // Token: 0x040000AF RID: 175
        private TextBox geLnAwDsZp;

        // Token: 0x040000B0 RID: 176
        private Label label5;

        // Token: 0x040000B1 RID: 177
        private TextBox textFiles;

        // Token: 0x040000B2 RID: 178
        private TextBox textDirs;

        // Token: 0x040000B3 RID: 179
        private Label label6;

        // Token: 0x040000B4 RID: 180
        private TextBox textTimeEdit;
    }
}