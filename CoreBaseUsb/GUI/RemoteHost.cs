using System;

namespace CoreBaseUsb.GUI
{
    public class RemoteHost
    {
        public string Host
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

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x060001F5 RID: 501 RVA: 0x0001D818 File Offset: 0x0001BA18
        // (set) Token: 0x060001F6 RID: 502 RVA: 0x00002E51 File Offset: 0x00001051
        public int Port
        {
            get
            {
                return this.BsMrqdibbm;
            }
            set
            {
                this.BsMrqdibbm = value;
            }
        }

        // Token: 0x060001F7 RID: 503 RVA: 0x00002E5A File Offset: 0x0000105A
        public RemoteHost(string host, int port)
        {
            Class3.vd4OXo2zYFEgU();
            base..ctor();
            this.Host = host;
            this.Port = port;
        }

        // Token: 0x040001B4 RID: 436
        private string string_0;

        // Token: 0x040001B5 RID: 437
        private int BsMrqdibbm;
    }
}
