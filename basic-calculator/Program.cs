using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            decimal valor1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            decimal result = valor1 + valor2;

            Console.WriteLine($"\nO resultado da soma é {result}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            decimal valor1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            decimal result = valor1 - valor2;

            Console.WriteLine($"\nO resultado da subtração é {result}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            decimal valor1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nO resultado da divisão é " + (valor1 / valor2));
            Console.ReadKey();
        }
    }
}
