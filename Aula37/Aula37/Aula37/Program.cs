using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1)
            {
                dia = "domingo";
            }
            else if (x == 2)
            {
                dia = "segunda";
            }
            else if (x == 3)
            {
                dia = "terça";
            }
            else if (x == 4)
            {
                dia = "quarta";
            }
            else if (x == 5)
            {
                dia = "quinta";
            }
            else if (x == 6)
            {
                dia = "sexta";
            }
            else if (x == 7)
            {
                dia = "sábado";
            }
            else
            {
                dia = "valor inválido";
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}