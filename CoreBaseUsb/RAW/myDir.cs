using System;
using CoreBaseUsb.Utilities;
namespace CoreBaseUsb.RAW
{
    public class myDir
    {
        public int ID
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000015 RID: 21 RVA: 0x000039E8 File Offset: 0x00001BE8
        // (set) Token: 0x06000016 RID: 22 RVA: 0x000022DF File Offset: 0x000004DF
        public string Name
        {
            get
            {
                return this.string_0;
            }
            set
            {
                this.string_0 = value;
            }
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00003A00 File Offset: 0x00001C00
        public int CompareTo(myDir psn2, ObjCompare.ComparisonType comparisonType, myDir psn1)
        {
            int result;
            if (comparisonType == ObjCompare.ComparisonType.ID)
            {
                if (psn1.ID == psn2.ID)
                {
                    result = this.Name.CompareTo(psn2.Name);
                }
                else
                {
                    result = this.ID.CompareTo(psn2.ID);
                }
            }
            else if (comparisonType == ObjCompare.ComparisonType.Name)
            {
                result = this.Name.CompareTo(psn2.Name);
            }
            else
            {
                result = this.ID.CompareTo(psn2.ID);
            }
            return result;
        }

        // Token: 0x06000018 RID: 24 RVA: 0x000022AB File Offset: 0x000004AB
        public myDir()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x0400000F RID: 15
        private int int_0;

        // Token: 0x04000010 RID: 16
        private string string_0;
    }
}
