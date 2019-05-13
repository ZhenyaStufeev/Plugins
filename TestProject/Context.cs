using IPluginLibrary.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject
{
    public class Context : IFileContext
    {
        public string ReadAllText(string FileName)
        {
            throw new NotImplementedException();
        }

        public void WriteAllText(string FileName, string data)
        {
            FileStream temp = null;
            if (!File.Exists(FileName))
                temp = File.Create(FileName);

            temp.Close();

            File.WriteAllText(FileName, data);
        }
    }
}
