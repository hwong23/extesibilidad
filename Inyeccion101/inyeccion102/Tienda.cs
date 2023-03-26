using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion101
{
    class Tienda
    {
        public string descripcion;
        public IProducto producto;

        public Tienda (string desc, IProducto prodc)
        {
            this.descripcion = desc;
            this.producto = prodc;
        }
    }
}
