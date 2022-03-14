using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora");
            Console.WriteLine("Selecione uma opção:");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma das opções:");
            short recebe = short.Parse(Console.ReadLine());

            switch (recebe)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

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
            Menu();
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
            Menu();
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
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor:");
            decimal valor1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            decimal valor2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\nO resulta da multiplicação é {valor1 * valor2}");
            Console.ReadKey();
            Menu();
        }
    }
}
