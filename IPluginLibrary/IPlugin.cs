using IPluginLibrary.Context;
using IPluginLibrary.Entity;
using System;

namespace IPluginLibrary
{
    public interface IPlugin
    {
        void Exequte(ExtensionRequest request);
        void SetDataTransport(IFileContext fileService);
        bool Verify(string ExtensionName);
        PluginInfo GetInfo();
    }
}
