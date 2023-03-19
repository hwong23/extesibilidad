﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace SimpleCalculator
{
    [Export(typeof(IOperation))]
    [ExportMetadata("Symbol", '-')]
    class Resta : IOperation
    {
        public int Operate(int left, int right)
        {
            return left - right;
        }
    }
}
