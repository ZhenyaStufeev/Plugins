using IPluginLibrary;
using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using IPluginLibrary.Service;
using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPluginService loader = new PluginService();

            int counter = 1;
            foreach (PluginInfo PI in loader.GetExtensionInfo())
            {
                Console.WriteLine(counter + ". " + PI.PluginName + "\n");
                foreach (string a in PI.ActionsName)
                {
                    Console.WriteLine("     - " + a + "\n");
                }
            }
            

            Console.WriteLine("Write extension name: ");
            string ExtensionName = Console.ReadLine();

            IFileContext ct = new Context();


            IPlugin pl = loader.FindExtension(ExtensionName);
            if (pl == null)
            {
                Console.WriteLine("NULL PLUGIN");
            }

            pl.SetDataTransport(ct);

            Console.WriteLine("Write extension action name: ");
            string actionName = Console.ReadLine();

            Console.WriteLine("Enter text to exequte: ");
            string text = Console.ReadLine(); 

            pl.Exequte(new ExtensionRequest() { ActionName = actionName, Data = text });
        }
    }
}
