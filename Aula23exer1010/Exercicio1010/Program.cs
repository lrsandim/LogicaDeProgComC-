using System;
using System.Globalization;

namespace Exercicio101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca = int.Parse(peca1[0]);
            int numeroDePecas = int.Parse(peca1[1]);
            double valorUnitario = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int numeroDePecas2 = int.Parse(peca2[1]);
            double valorUnitario2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorAPgar = (numeroDePecas * valorUnitario) + (numeroDePecas2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorAPgar.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}