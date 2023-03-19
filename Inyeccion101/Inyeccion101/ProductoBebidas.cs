using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion101
{
    class ProductoBebidas : IProducto
    {
        public string descripcion = "Bebidas";

        string IProducto.getDescripcion()
        {
            return this.descripcion;
        }
    }
}
