using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.LTOOLSnet.Properties
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060001E0 RID: 480 RVA: 0x0001CF84 File Offset: 0x0001B184
        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }

        // Token: 0x060001E1 RID: 481 RVA: 0x00002DCF File Offset: 0x00000FCF
        public Settings()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x060001E2 RID: 482 RVA: 0x00002DDC File Offset: 0x00000FDC
        static Settings()
        {
            Class3.vd4OXo2zYFEgU();
            Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
        }

        // Token: 0x040001A9 RID: 425
        private static Settings defaultInstance;
    }
}
