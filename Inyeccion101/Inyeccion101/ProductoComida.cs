
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion101
{
    class ProductoComida : IProducto
    {
        public string descripcion = "Comida";

        string IProducto.getDescripcion()
        {
            return this.descripcion;
        }
    }
}
