using System;

namespace Inyeccion101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explaining a little
            // we have a store that sells products but if we create a class product
            // we will need to create a different constructor and add a new or change
            // the type of the attribute product on Store class.
            // Creating an interface Product and implementing it on different product
            // classes will let our Store class untouched, and that is a big advantage
            // because it reduces refactors and their complexity.

            Tienda tienda1 = new Tienda("Tienda Comida", new ProductoComida());
            Console.WriteLine(tienda1.producto.getDescripcion());

            Tienda tienda2 = new Tienda("Tienda Bebidas", new ProductoBebidas());
            Console.WriteLine(tienda2.producto.getDescripcion());
        }
    }
}
