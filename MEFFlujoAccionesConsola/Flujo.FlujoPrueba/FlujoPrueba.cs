using Flujo.Contratos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo.FlujoPrueba
{
    [Export(typeof(IFlujo))]
    public class FlujoPrueba : IFlujo
    {
        public string Ejecutar(string input)
        {
            return "Flujo de Prueba. " + input;
        }
    }
}
