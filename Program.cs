using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del lado w ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado t ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el angulo C ");
            double c = double.Parse(Console.ReadLine());

            double z = Math.Sin(c * (Math.PI / 180.0)) * t;
            double y = Math.Cos(c * (Math.PI / 180.0)) * t;
            double xy = Math.Sqrt((w * w) - (z * z));
            double x = xy - y;

            Console.WriteLine("La longitud del lado x es " + x);
        }
    }
}
