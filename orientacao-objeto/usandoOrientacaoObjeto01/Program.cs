using System;
using System.Globalization;

namespace usandoOrientacaoObjeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizando conceito de programação O.O

            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Informe o valor do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de X = {areaX:f4}");
            Console.WriteLine($"Área de Y = {areaY:f4}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é do triângulo X");
            }
            else
            {
                Console.WriteLine("Maior área é do triângulo Y");
            }
        }
    }
}
