using System;
using System.Collections;
using CoreBaseUsb.Utilities;
namespace CoreBaseUsb.RAW
{
    public class ObjCompare
    {
        public ObjCompare.ComparisonType ComparisonMethod
        {
            get
            {
                return this.comparisonType_0;
            }
            set
            {
                this.comparisonType_0 = value;
            }
        }

        // Token: 0x0600001B RID: 27 RVA: 0x00003AA4 File Offset: 0x00001CA4
        public int Compare(object x, object y)
        {
            myDir psn = (myDir)x;
            myDir myDir = (myDir)y;
            return myDir.CompareTo(psn, this.ComparisonMethod, myDir);
        }

        // Token: 0x0600001C RID: 28 RVA: 0x000022AB File Offset: 0x000004AB
        public ObjCompare()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x04000011 RID: 17
        private ObjCompare.ComparisonType comparisonType_0;

        // Token: 0x02000009 RID: 9
        public enum ComparisonType
        {
            // Token: 0x04000013 RID: 19
            ID,
            // Token: 0x04000014 RID: 20
            Name
        }
    }
}
