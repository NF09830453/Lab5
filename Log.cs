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


        public override void PerformOp()
        {
            double result = -1;
            if (CurrVal > 0)
            {
                result = Math.Log(CurrVal); //computation for the natural log of the current value
            }
            Form2 f = new Form2(CurrVal, result);
            f.Visible = true;

        }
    }
}
