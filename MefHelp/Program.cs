namespace MefHelp
{
    using System;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.IO;
    using System.Reflection;
    using Infrastructure;

    class Program
    {
        private CompositionContainer container;

        [Import(typeof(IPlugin))]
        public IPlugin Plugin;

        private Program()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Directory.GetCurrentDirectory() + "\\Plugins"));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

            container = new CompositionContainer(catalog);

            try
            {
                container.ComposeParts(this);
            }
            catch (CompositionException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.Plugin.Work("Foo"));

            Console.ReadKey();
        }
    }
}
