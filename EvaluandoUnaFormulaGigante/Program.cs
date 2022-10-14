using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluandoUnaFormulaGigante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.0,y =0.0,z=0.0;
            double[] arreglo = Console.ReadLine().Split().Select(double.Parse).ToArray();
            x = arreglo[0];
            y = arreglo[1];
            z = arreglo[2];
            double arriba = (((2*x)+y)/z) *(Math.Pow(y,3) - z);
            double abajo = ((x + (2*y) + (3*z))/(z - (2*y)-(3*x)))+(Math.Pow(x, 2) + Math.Pow(z, 2));
            if(abajo == 0)
            {
                Console.WriteLine("Error, no se puede dividir entre 0");
            }
            else {  Console.WriteLine(arriba/abajo); }
            Console.ReadKey();
        }
    }
}
