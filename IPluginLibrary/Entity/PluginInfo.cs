using System;
using System.Collections.Generic;
using System.Text;

namespace IPluginLibrary.Entity
{
    public class PluginInfo
    {
        public string PluginName { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string[] ActionsName { get; set; }
    }
}
