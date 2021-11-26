using System;

namespace Comparativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Informe um número inteiro: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
