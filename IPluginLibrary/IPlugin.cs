using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace IPluginLibrary
{
    public interface IPlugin
    {
        //void Exequte(ExtensionRequest request);
        void SetDataTransport(IFileContext fileService);
        //bool Verify(string ExtensionName);
        PluginInfo GetInfo();
        IEnumerable<MethodInfo> InitializeMethods();
    }
}
