using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(String[] args)
        {
            double numero, horas, recebe, salario;

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            recebe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * recebe;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}