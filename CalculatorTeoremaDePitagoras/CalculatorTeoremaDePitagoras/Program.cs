using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTeoremaDePitagoras
{
    public class Program 
    {
        static void Main(string[] args)
        {
            calculator();
        }
       
        public static double CalculadorParaElValorDeLaHipotenusa(double cateto2, double Cateto1)
        {
            return Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(cateto2, 2));
        }


        static void calculator()
        {
            
           
                double cateto2 = 0;
                double Cateto1 = 0;
               
                try
                {
                    Console.WriteLine("Hola,esta es una aplicacion que calcula la hipotenusa de un trinagulo rectangulo.");
                    Console.WriteLine("porfavor digite el valor de el primer lado de su triangulo rectangulo");

                    Cateto1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("porfavor dijite el valor del segundo lado de su triangulo rectangulo");

                    cateto2 = double.Parse(Console.ReadLine());

                    
                }
                catch (FormatException )
                {
                    Console.WriteLine("no ha intrudicido un valor valido , o la letra que dijito es erroenea");
                }
        }
    }
}
