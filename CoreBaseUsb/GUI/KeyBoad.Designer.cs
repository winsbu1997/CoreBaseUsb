using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KeyboardClassLibrary;

namespace CoreBaseUsb.GUI
{
    partial class KeyBoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        // Token: 0x060000FC RID: 252 RVA: 0x00002767 File Offset: 0x00000967
        private void xwgnajsMnA_Click(object sender, EventArgs e)
        {
            this.keyboardcontrol1.KeyboardType = BoW.Standard;
        }

        // Token: 0x060000FD RID: 253 RVA: 0x00002775 File Offset: 0x00000975
        private void button2_Click(object sender, EventArgs e)
        {
            this.keyboardcontrol1.KeyboardType = BoW.Alphabetical;
        }

        // Token: 0x060000FE RID: 254 RVA: 0x00002783 File Offset: 0x00000983
        private void button3_Click(object sender, EventArgs e)
        {
            this.keyboardcontrol1.KeyboardType = BoW.Kids;
        }

        // Token: 0x060000FF RID: 255 RVA: 0x00002791 File Offset: 0x00000991
        private void method_0(object sender, KeyboardEventArgs e)
        {
            this.richTextBox1.Focus();
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        // Token: 0x06000100 RID: 256 RVA: 0x000022A9 File Offset: 0x000004A9
        private void keyboardcontrol1_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x06000101 RID: 257 RVA: 0x000027AA File Offset: 0x000009AA
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000102 RID: 258 RVA: 0x000126B0 File Offset: 0x000108B0
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.xwgnajsMnA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.keyboardcontrol1 = new KeyboardClassLibrary.Keyboardcontrol();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 442);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1412, 493);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // xwgnajsMnA
            // 
            this.xwgnajsMnA.Location = new System.Drawing.Point(24, 1128);
            this.xwgnajsMnA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.xwgnajsMnA.Name = "xwgnajsMnA";
            this.xwgnajsMnA.Size = new System.Drawing.Size(150, 44);
            this.xwgnajsMnA.TabIndex = 2;
            this.xwgnajsMnA.Text = "Standard";
            this.xwgnajsMnA.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 1128);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Alphabetical";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 1128);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kids";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // keyboardcontrol1
            // 
            this.keyboardcontrol1.KeyboardType = KeyboardClassLibrary.BoW.Standard;
            this.keyboardcontrol1.Location = new System.Drawing.Point(2, 2);
            this.keyboardcontrol1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.keyboardcontrol1.Name = "keyboardcontrol1";
            this.keyboardcontrol1.Size = new System.Drawing.Size(1416, 409);
            this.keyboardcontrol1.TabIndex = 0;
            // 
            // KeyBoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.xwgnajsMnA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.keyboardcontrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyBoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Keyboard";
            this.ResumeLayout(false);

        }

        // Token: 0x040000B9 RID: 185
        public KeyBoad.SEND sender;

        // Token: 0x040000BA RID: 186
        private IContainer icontainer_0;

        // Token: 0x040000BB RID: 187
        private Keyboardcontrol keyboardcontrol1;

        // Token: 0x040000BC RID: 188
        private RichTextBox richTextBox1;

        // Token: 0x040000BD RID: 189
        private Button xwgnajsMnA;

        // Token: 0x040000BE RID: 190
        private Button button2;

        // Token: 0x040000BF RID: 191
        private Button button3;

        // Token: 0x02000019 RID: 25
        // (Invoke) Token: 0x06000104 RID: 260
        public delegate void SEND(string s);
    }
}