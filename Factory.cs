using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Factory: FactoryIF
    {
        OperationIF op;
        public OperationIF CreateOp(String discriminator)
        {
            string disc = "Lab5." + discriminator;
            Type t = Type.GetType(disc);
            Object o = Activator.CreateInstance(t);
            op = (OperationIF) o;
            return op;
        }

    }
}
