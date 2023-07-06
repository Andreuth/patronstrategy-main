using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron
{
    interface IOperacion
    {
        //Creamos un metodo para heredarla a las demás clases:
        double Operacion(double A, double B);
    }
}
