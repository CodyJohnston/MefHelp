namespace MefHelp
{
    using System.ComponentModel.Composition;
    using Infrastructure;


    [Export]
    public class PluginData : IHost
    {
        public string Version => "1.0.0";
    }
}
