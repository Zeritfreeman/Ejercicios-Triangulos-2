using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el angulo D ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el angulo B ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado y ");
            double y = double.Parse(Console.ReadLine());

            double e = 180.0 - (d + b);
            double c = 180.0 - e;
            double z = Math.Tan(c * (Math.PI / 180.0)) * y;

            Console.WriteLine("La longitud del lado z es " + z);
        }
    }
}
