namespace MefHelp.Plugin
{
    using System;
    using System.ComponentModel.Composition;
    using Infrastructure;

    [Export]
    public class ImBadAtComingUpWithNamesForThings : IPlugin
    {
        [Import(typeof(IHost))]
        public IHost Host;

        public string Work(string input)
        {
            return string.Format("Plugin called: {0} is your input string." + Environment.NewLine + "Host application version: {1}", input, Host.Version);
        }
    }
}
