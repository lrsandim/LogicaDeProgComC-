using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r, n = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = n * Math.Pow(r, 2.0);

            Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}