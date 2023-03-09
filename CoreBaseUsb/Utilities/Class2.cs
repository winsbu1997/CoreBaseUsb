using System;
using System.Reflection;

namespace CoreBaseUsb.Utilities
{
    internal class Class2
    {
        internal static void j0jOXo22dpyJY(int typemdt)
        {
            Type type = Class2.module_0.ResolveType(33554432 + typemdt);
            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                MethodInfo method = (MethodInfo)Class2.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
                fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
            }
        }

        // Token: 0x06000206 RID: 518 RVA: 0x000022AB File Offset: 0x000004AB
        public Class2()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x06000207 RID: 519 RVA: 0x00002EC3 File Offset: 0x000010C3
        static Class2()
        {
            Class3.vd4OXo2zYFEgU();
            Class2.module_0 = typeof(Class2).Assembly.ManifestModule;
        }

        // Token: 0x040001C0 RID: 448
        internal static Module module_0;

        // Token: 0x0200002E RID: 46
        // (Invoke) Token: 0x06000209 RID: 521
        internal delegate void Delegate0(object o);
    }
}
