using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el angulo B ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado z ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado y ");
            double y = double.Parse(Console.ReadLine());

            double a = Math.Atan(y / z);
            double ab = a + (b * (Math.PI / 180.0));
            double x = (Math.Tan(ab) * z) - y;

            Console.WriteLine("La longitud del lado x es " + x);
        }
    }
}
