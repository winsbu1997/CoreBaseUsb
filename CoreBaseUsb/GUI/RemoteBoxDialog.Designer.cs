using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoreBaseUsb.GUI
{
    partial class RemoteBoxDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public string HostName
        {
            get
            {
                return this.comboBoxHostName.Text;
            }
        }

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x060001E4 RID: 484 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
        public int PortNumber
        {
            get
            {
                return int.Parse(this.textBoxPortNumber.Text);
            }
        }

        // Token: 0x17000048 RID: 72
        // (get) Token: 0x060001E5 RID: 485 RVA: 0x0001CFD4 File Offset: 0x0001B1D4
        public RemoteHost RemoteServer
        {
            get
            {
                return (RemoteHost)this.arrayList_0[this.comboBoxHostName.SelectedIndex];
            }
        }

        // Token: 0x060001E7 RID: 487 RVA: 0x00002DF7 File Offset: 0x00000FF7
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.container_0 != null)
            {
                this.container_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060001E8 RID: 488 RVA: 0x0001D078 File Offset: 0x0001B278
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxHostName.SelectedIndex;
            if (selectedIndex == -1)
            {
                RemoteHost value = new RemoteHost(this.comboBoxHostName.Text, this.PortNumber);
                int selectedIndex2 = this.arrayList_0.Add(value);
                this.method_0();
                this.comboBoxHostName.SelectedIndex = selectedIndex2;
                this.method_2();
            }
            else if (this.PortNumber != ((RemoteHost)this.arrayList_0[selectedIndex]).Port)
            {
                ((RemoteHost)this.arrayList_0[selectedIndex]).Port = this.PortNumber;
            }
        }

        // Token: 0x060001E9 RID: 489 RVA: 0x0001D114 File Offset: 0x0001B314
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RemoteBoxDialog));
            this.labelHostName = new Label();
            this.labelPortNumber = new Label();
            this.textBoxPortNumber = new TextBox();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.comboBoxHostName = new ComboBox();
            base.SuspendLayout();
            this.labelHostName.Location = new Point(19, 17);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new Size(85, 21);
            this.labelHostName.TabIndex = 0;
            this.labelHostName.Text = "Remote host:";
            this.labelHostName.TextAlign = ContentAlignment.MiddleLeft;
            this.labelPortNumber.Location = new Point(19, 51);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new Size(85, 22);
            this.labelPortNumber.TabIndex = 2;
            this.labelPortNumber.Text = "Port number:";
            this.labelPortNumber.TextAlign = ContentAlignment.MiddleLeft;
            this.textBoxPortNumber.Location = new Point(122, 51);
            this.textBoxPortNumber.Name = "textBoxPortNumber";
            this.textBoxPortNumber.Size = new Size(170, 20);
            this.textBoxPortNumber.TabIndex = 3;
            this.textBoxPortNumber.Text = "port";
            this.textBoxPortNumber.TextChanged += this.textBoxPortNumber_TextChanged;
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.Location = new Point(38, 86);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(107, 27);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.Click += this.buttonOk_Click;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(167, 86);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(106, 27);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.comboBoxHostName.Location = new Point(122, 17);
            this.comboBoxHostName.Name = "comboBoxHostName";
            this.comboBoxHostName.Size = new Size(170, 21);
            this.comboBoxHostName.TabIndex = 6;
            this.comboBoxHostName.Text = "remotehost";
            this.comboBoxHostName.SelectedIndexChanged += this.comboBoxHostName_SelectedIndexChanged;
            base.AcceptButton = this.buttonOk;
            this.AutoScaleBaseSize = new Size(5, 13);
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(392, 152);
            base.Controls.Add(this.comboBoxHostName);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonOk);
            base.Controls.Add(this.textBoxPortNumber);
            base.Controls.Add(this.labelPortNumber);
            base.Controls.Add(this.labelHostName);
            base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            this.MaximumSize = new Size(417, 260);
            base.MinimizeBox = false;
            this.MinimumSize = new Size(250, 130);
            base.Name = "RemoteBoxDialog";
            base.ShowInTaskbar = false;
            base.SizeGripStyle = SizeGripStyle.Hide;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "USBTOOLS Connect to remote host";
            base.Load += this.RemoteBoxDialog_Load;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x060001EA RID: 490 RVA: 0x0001D52C File Offset: 0x0001B72C
        private void comboBoxHostName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBoxHostName.SelectedIndex;
            this.textBoxPortNumber.Text = ((RemoteHost)this.arrayList_0[selectedIndex]).Port.ToString();
        }

        // Token: 0x060001EB RID: 491 RVA: 0x0001D570 File Offset: 0x0001B770
        private void method_0()
        {
            this.comboBoxHostName.Items.Clear();
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                this.comboBoxHostName.Items.Add(((RemoteHost)this.arrayList_0[i]).Host);
            }
        }

        // Token: 0x060001EC RID: 492 RVA: 0x0001D5CC File Offset: 0x0001B7CC
        public void GetHostsFromFile()
        {
            if (File.Exists(this.string_0))
            {
                FileStream fileStream = new FileStream(this.string_0, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    if (!text.StartsWith("#") && !text.StartsWith("[") && !text.Equals(""))
                    {
                        try
                        {
                            int num = text.IndexOf(" ");
                            string host = text.Substring(0, num);
                            string s = text.Substring(num + 1).Trim();
                            RemoteHost value = new RemoteHost(host, int.Parse(s));
                            this.arrayList_0.Add(value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n---" + text + "---");
                        }
                    }
                }
                streamReader.Close();
                fileStream.Close();
            }
        }

        // Token: 0x060001ED RID: 493 RVA: 0x00002E1C File Offset: 0x0000101C
        public void SetDebugDialog(MyDebug dDialog)
        {
            this.myDebug_0 = dDialog;
        }

        // Token: 0x060001EE RID: 494 RVA: 0x00002E25 File Offset: 0x00001025
        private void method_1(string string_1)
        {
            if (this.myDebug_0 != null)
            {
                this.myDebug_0.AppendText(string_1 + "\r\n");
            }
        }

        // Token: 0x060001EF RID: 495 RVA: 0x0001D6CC File Offset: 0x0001B8CC
        private void method_2()
        {
            this.method_1("remoteHostsList:");
            for (int i = 0; i < this.arrayList_0.Count; i++)
            {
                this.method_1(string.Concat(new object[]
                {
                    i,
                    ": ",
                    ((RemoteHost)this.arrayList_0[i]).Host,
                    " --- ",
                    ((RemoteHost)this.arrayList_0[i]).Port
                }));
            }
        }

        // Token: 0x060001F0 RID: 496 RVA: 0x0001D760 File Offset: 0x0001B960
        [STAThread]
        private static void smethod_0()
        {
            Form form = new Form();
            form.Text = "RemoteBoxDialog Test";
            form.Size = new Size(600, 400);
            form.Visible = true;
            RemoteBoxDialog remoteBoxDialog = new RemoteBoxDialog(new RemoteHost("localhost", 1605));
            remoteBoxDialog.ShowDialog();
            MessageBox.Show(string.Concat(new object[]
            {
                "HostName: ",
                remoteBoxDialog.HostName,
                "\nPortNumber: ",
                remoteBoxDialog.PortNumber,
                "\n"
            }), "RemoteBoxDialog");
        }

        // Token: 0x060001F1 RID: 497 RVA: 0x000022A9 File Offset: 0x000004A9
        private void textBoxPortNumber_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x060001F2 RID: 498 RVA: 0x000022A9 File Offset: 0x000004A9
        private void RemoteBoxDialog_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x040001AA RID: 426
        private ComboBox comboBoxHostName;

        // Token: 0x040001AB RID: 427
        private TextBox textBoxPortNumber;

        // Token: 0x040001AC RID: 428
        private Label labelHostName;

        // Token: 0x040001AD RID: 429
        private Label labelPortNumber;

        // Token: 0x040001AE RID: 430
        private Button buttonOk;

        // Token: 0x040001AF RID: 431
        private Button buttonCancel;

        // Token: 0x040001B0 RID: 432
        private Container container_0;

        // Token: 0x040001B1 RID: 433
        private ArrayList arrayList_0;

        // Token: 0x040001B2 RID: 434
        private MyDebug myDebug_0;

        // Token: 0x040001B3 RID: 435
        private string string_0;
    }
}