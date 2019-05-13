using System;
using System.Collections.Generic;
using System.Text;

namespace IPluginLibrary.Context
{
    public interface IFileContext
    {
        void WriteAllText(string FileName, string data);
        string ReadAllText(string FileName);
    }
}
