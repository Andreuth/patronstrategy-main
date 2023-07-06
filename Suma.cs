using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron
{
    public class Suma : IOperacion
    {
        public double Operacion(double A, double B)
        {
            return A + B;
        }
    }
}
