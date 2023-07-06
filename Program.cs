using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variables que hacen referencia al algoritmo:
            string Dato = " ";
            double Num1 = 0;
            double Num2 = 0;
            double Resultado = 0;
            string opcion = " ";

            // Instanciamos con un Default para permitir compilacion correcta:
            IOperacion operacionn = new Suma();
            while (opcion!= "5")
            {
                Console.WriteLine("Seleccione la operacion que desea realizar");
                Console.WriteLine("Suma presionar:1\nResta presionar:2\nMultiplicacion presionar:3\nDivision presionar:4\nSalir presionar:5");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break; //Permite cerrar el bucle

                Console.WriteLine("Ingrese el primer valor ");
                Dato = Console.ReadLine();
                Num1 = Convert.ToDouble(Dato);

                Console.WriteLine("Ingrese el segundo valor ");
                Dato = Console.ReadLine();
                Num2 = Convert.ToDouble(Dato);

                //Aquí seleccionamos el algoritmo de acuerdo a la necesidad del usuario:
                if (opcion == "1")
                {
                    operacionn = new Suma();
                }
                else if (opcion == "2")
                {
                    operacionn = new Resta();
                }
                else if(opcion == "3")
                {
                    operacionn= new Multiplicacion();
                }
                else
                {
                    operacionn = new Division();
                }

                Resultado = operacionn.Operacion(Num1, Num2);
                Console.WriteLine("El resultado de la operación es: {0} ", Resultado);
            }
        }
    }
}
