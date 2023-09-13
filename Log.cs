using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class Log: AbsOp
    {
        public void PerformOp()
        {
            double result = Math.Log(CurrVal);
        }

    }
}
