using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.LTOOLSnet.Properties
{
    [CompilerGenerated]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal class Resources
    {
        internal Resources()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060001DC RID: 476 RVA: 0x0001CEFC File Offset: 0x0001B0FC
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager_0
        {
            get
            {
                if (object.ReferenceEquals(Resources.resourceManager_0, null))
                {
                    ResourceManager resourceManager = new ResourceManager("LTOOLSnet.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceManager_0 = resourceManager;
                }
                return Resources.resourceManager_0;
            }
        }

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060001DD RID: 477 RVA: 0x0001CF44 File Offset: 0x0001B144
        // (set) Token: 0x060001DE RID: 478 RVA: 0x00002DC7 File Offset: 0x00000FC7
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo CultureInfo_0
        {
            get
            {
                return Resources.cultureInfo_0;
            }
            set
            {
                Resources.cultureInfo_0 = value;
            }
        }

        // Token: 0x060001DF RID: 479 RVA: 0x0001CF58 File Offset: 0x0001B158
        internal static byte[] smethod_0()
        {
            object @object = Resources.ResourceManager_0.GetObject("init_boot", Resources.cultureInfo_0);
            return (byte[])@object;
        }

        // Token: 0x040001A7 RID: 423
        private static ResourceManager resourceManager_0;

        // Token: 0x040001A8 RID: 424
        private static CultureInfo cultureInfo_0;
    }
}
