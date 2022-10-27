using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] arms)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com preço do produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int age = int.Parse(vet[1]);
            double heigth = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullname);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(heigth.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
