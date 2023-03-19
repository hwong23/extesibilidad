using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyeccion101
{
    class Tienda
    {
        private string descripcion { get; }
        public IProducto producto { get; }

        public Tienda (string desc, IProducto prodc)
        {
            this.descripcion = desc;
            this.producto = prodc;
        }
    }
}
