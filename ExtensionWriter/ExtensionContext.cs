using IPluginLibrary;
using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExtensionWriter
{
    public class ExtensionContext : IPlugin
    {
        IFileContext fileContext;
        IEnumerable<MethodInfo> methods;
        public ExtensionContext()
        {
            methods = typeof(ExtensionContext).GetMethods().Where(x => x.IsPublic == true);
        }
        public void SetDataTransport(IFileContext fileService)
        {
            fileContext = fileService;
            //MethodInfo mi = typeof(Methods).GetMethod("Subscribe");
            //object[] a = { 10, 20 };
            //mi.Invoke(this, a);
        }

        public IEnumerable<MethodInfo> InitializeMethods()
        {
            methods = typeof(ExtensionContext).GetMethods();
            return methods;
        }

        public PluginInfo GetInfo()
        {

            List<string> methods_Name = new List<string>();
            foreach (MethodInfo info in methods)
                methods_Name.Add(info.Name);

            PluginInfo plInfo = new PluginInfo();
            plInfo.ActionsName = methods_Name.ToArray();
            plInfo.PluginName = "1";


            return plInfo;
        }

        public int Summ(int a, int b)
        {
            Console.WriteLine("Summ zahlo");

            return a+b;
        }
    }
}
