using IPluginLibrary;
using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using IPluginLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPluginService loader = new PluginService(@"C:\Users\zhenyastufeev\source\repos\Plugins\TestProject\bin\Debug\netcoreapp2.2\plugins");

            int counter = 1;
            foreach (PluginInfo PI in loader.GetExtensionInfo())
            {
                Console.WriteLine(counter + ". " + PI.PluginName + "\n");
                foreach (string k in PI.ActionsName)
                {
                    Console.WriteLine("     - " + k + "\n");
                }
                counter++;
            }
            
            Console.WriteLine("Write extension name: ");
            string ExtensionName = Console.ReadLine();

            IFileContext ct = new Context();

            IPlugin pl = loader.FindExtension(ExtensionName);

            pl.SetDataTransport(ct);

            Console.WriteLine("Write extension action name: ");
            string actionName = Console.ReadLine();

            Console.WriteLine("Data writing...");

            int a = 10;
            int b = 24;
            object[] obj = { a, b };

            Console.WriteLine("In object wrote a and b. \nEnter some key to continue...");
            Console.ReadLine();

            List<MethodInfo> all_methods = pl.InitializeMethods().ToList();

            MethodInfo toExequte = all_methods.Find(x => x.Name == actionName);

            var inf_type = Activator.CreateInstance(toExequte.DeclaringType);

            Console.WriteLine(toExequte.Invoke(inf_type, obj));
        }
    }
}
