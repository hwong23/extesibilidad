using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Flujo.Contratos;

namespace MEFFlujoAccionesConsola
{
    class Program
    {
        private CompositionContainer _container;

        [ImportMany]
        public IEnumerable<IFlujo> flujos;

        private Program()
        {
            try
            {
                // An aggregate catalog that combines multiple catalogs.
                var catalog = new AggregateCatalog();

                // Adds all the parts found in the same assembly as 
                // the Program class.
                catalog.Catalogs.Add(
                    new DirectoryCatalog(
                    "..\\..\\extensiones"
                    ));

                // Create the CompositionContainer with the parts 
                // in the catalog.
                _container = new CompositionContainer(catalog);
                _container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.run();
        }

        private string run()
        {
            foreach (IFlujo i in flujos)
            {
                // if (i.Metadata.Symbol.Equals(operation))
                {
                    Console.WriteLine (i.Ejecutar("paso"));
                }
            }

            return "Fin del flujo.";
        }
    }
}
