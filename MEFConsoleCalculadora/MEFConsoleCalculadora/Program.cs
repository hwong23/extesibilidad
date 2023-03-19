using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace SimpleCalculator
{
    class Program
    {
        private CompositionContainer _container;

        [Import(typeof(ICalculator))]
        public ICalculator calculator;

        private Program()
        {
            try
            {
                // An aggregate catalog that combines multiple catalogs.
                var catalog = new AggregateCatalog();
                
                // Adds all the parts found in the same assembly as 
                // the Program class.
                catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
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
            // Composition is performed in the constructor.
            var p = new Program();

            Console.WriteLine("Enter Command:");
            while (true)
            {
                string s = Console.ReadLine();
                Console.WriteLine(p.calculator.Calculate(s));
            }
        }
    }
}

    
