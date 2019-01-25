using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del lado w ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el angulo D ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la longitud del lado x ");
            double x = double.Parse(Console.ReadLine());

            double xy = Math.Cos(d * (Math.PI / 180.0)) * w;
            double y = xy - x;

            Console.WriteLine("La longitud del lado y es " + y);
        }
    }
}
