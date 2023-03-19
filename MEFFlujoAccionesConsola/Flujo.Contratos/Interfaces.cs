using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo.Contratos
{
    public interface IOperation
    {
        int Operate(int left, int right);
    }

    public interface IOperationData
    {
        char Symbol { get; }
    }

    public interface IFlujo
    {
        string Ejecutar(string input);
    }
}
