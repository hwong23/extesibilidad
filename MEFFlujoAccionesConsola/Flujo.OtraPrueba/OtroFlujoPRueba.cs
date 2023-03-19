using Flujo.Contratos;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo.OtraPrueba
{
    [Export(typeof(IFlujo))]
    public class OtroFlujoPrueba : IFlujo
    {
        public string Ejecutar(string input)
        {
            return "Otro Flujo de Prueba. " + input;
        }
    }
}
