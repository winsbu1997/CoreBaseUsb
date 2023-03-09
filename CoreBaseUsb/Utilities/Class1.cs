using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBaseUsb.Utilities
{
    internal class Class1
    {
        //public Class1(string string_2) : base()
        //{
        //    Class3.vd4OXo2zYFEgU();
        //    this(string_2, " \t\n\r\f", false);
        //}

        //// Token: 0x060001F9 RID: 505 RVA: 0x00002E89 File Offset: 0x00001089
        //public Class1(string string_2, string string_3) : base()
        //{
        //    Class3.vd4OXo2zYFEgU();
        //    this(string_2, string_3, false);
        //}
        public Class1() { }
        // Token: 0x060001FA RID: 506 RVA: 0x0001D830 File Offset: 0x0001BA30
        public Class1(string string_2, string string_3 = " \t\n\r\f", bool bool_2 = false)
        {
            Class3.vd4OXo2zYFEgU();
            this.int_0 = 0;
            this.int_1 = -1;
            this.bool_1 = false;
            this.string_0 = string_2;
            this.int_2 = string_2.Length;
            this.string_1 = string_3;
            this.bool_0 = bool_2;
            this.method_0();
        }

        // Token: 0x060001FB RID: 507 RVA: 0x0001D884 File Offset: 0x0001BA84
        private void method_0()
        {
            if (this.string_1 == null)
            {
                this.char_0 = '\0';
            }
            else
            {
                char c = '\0';
                for (int i = 0; i < this.string_1.Length; i++)
                {
                    char[] array = this.string_1.ToCharArray(i, 1);
                    if (c < array[0])
                    {
                        c = array[0];
                    }
                }
                this.char_0 = c;
            }
        }

        // Token: 0x060001FC RID: 508 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
        private int method_1(int int_3)
        {
            if (this.string_1 != null)
            {
            }
            int num = int_3;
            while (!this.bool_0 && num < this.int_2)
            {
                char[] array = this.string_0.ToCharArray(num, 1);
                if (array[0] > this.char_0 || this.string_1.IndexOf(array[0]) < 0)
                {
                    break;
                }
                num++;
            }
            return num;
        }

        // Token: 0x060001FD RID: 509 RVA: 0x0001D95C File Offset: 0x0001BB5C
        private int method_2(int int_3)
        {
            int i;
            for (i = int_3; i < this.int_2; i++)
            {
                char[] array = this.string_0.ToCharArray(i, 1);
                if (array[0] <= this.char_0 && this.string_1.IndexOf(array[0]) >= 0)
                {
                    break;
                }
            }
            if (this.bool_0 && int_3 == i)
            {
                char[] array = this.string_0.ToCharArray(i, 1);
                if (array[0] <= this.char_0 && this.string_1.IndexOf(array[0]) >= 0)
                {
                    i++;
                }
            }
            return i;
        }

        // Token: 0x060001FE RID: 510 RVA: 0x00002E99 File Offset: 0x00001099
        public bool method_3()
        {
            this.int_1 = this.method_1(this.int_0);
            return this.int_1 < this.int_2;
        }

        // Token: 0x060001FF RID: 511 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
        public string method_4()
        {
            this.int_0 = ((this.int_1 < 0 || this.bool_1) ? this.method_1(this.int_0) : this.int_1);
            this.bool_1 = false;
            this.int_1 = -1;
            if (this.int_0 < this.int_2)
            {
            }
            int num = this.int_0;
            this.int_0 = this.method_2(this.int_0);
            return this.string_0.Substring(num, this.int_0 - num);
        }

        // Token: 0x06000200 RID: 512 RVA: 0x0001DA80 File Offset: 0x0001BC80
        public string method_5(string string_2)
        {
            this.string_1 = string_2;
            this.bool_1 = true;
            this.method_0();
            return this.method_4();
        }

        // Token: 0x06000201 RID: 513 RVA: 0x00002EBB File Offset: 0x000010BB
        public bool method_6()
        {
            return this.method_3();
        }

        // Token: 0x06000202 RID: 514 RVA: 0x0001DAAC File Offset: 0x0001BCAC
        public object dMwruToiy6()
        {
            return this.method_4();
        }

        // Token: 0x06000203 RID: 515 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
        public int method_7()
        {
            int num = 0;
            int i = this.int_0;
            while (i < this.int_2)
            {
                i = this.method_1(i);
                if (i >= this.int_2)
                {
                    break;
                }
                i = this.method_2(i);
                num++;
            }
            return num;
        }

        // Token: 0x06000204 RID: 516 RVA: 0x0001DB0C File Offset: 0x0001BD0C
        [STAThread]
        private static void smethod_0(object object_0)
        {
            string string_ = "drwxr-xr-x    0    0      4096 Wed Mar 12 04:11:23 2003 joerg";
            Class1 @class = new Class1(string_, " ");
            int num = 0;
            while (@class.method_3())
            {
                Console.WriteLine(num++ + ": " + @class.method_4());
            }
            Console.ReadLine();
        }

        // Token: 0x040001B6 RID: 438
        private int int_0;

        // Token: 0x040001B7 RID: 439
        private int int_1;

        // Token: 0x040001B8 RID: 440
        private int int_2;

        // Token: 0x040001B9 RID: 441
        private string string_0;

        // Token: 0x040001BA RID: 442
        private string string_1;

        // Token: 0x040001BB RID: 443
        private bool bool_0;

        // Token: 0x040001BC RID: 444
        private bool bool_1;

        // Token: 0x040001BD RID: 445
        private char char_0;
    }
}
