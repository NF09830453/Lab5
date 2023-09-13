using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class AbsOp: OperationIF
    {
        public double CurrVal { set; get; } = 0;

        public abstract void PerformOp();
    }
}
