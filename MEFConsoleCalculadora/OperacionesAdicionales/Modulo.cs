using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace OperacionesAdicionales
{
    public class Modulo
    {
    }

    [Export(typeof(SimpleCalculator.IOperation))]
    [ExportMetadata("Symbol", '%')]
    public class Mod : SimpleCalculator.IOperation
    {
        public int Operate(int left, int right)
        {
            return left % right;
        }
    }
}
