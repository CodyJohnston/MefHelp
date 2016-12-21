namespace MefHelp.Infrastructure
{
    using System.ComponentModel.Composition;

    [InheritedExport]
    public interface IHost
    {
        string Version { get; }
    }

    [InheritedExport]
    public interface IPlugin
    {
        string Work(string input);
    }
}
