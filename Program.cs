using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtratao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            //Console.WriteLine($"O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine($"O resultado da soma é " + (v1 + v2));
            // Console.WriteLine($"O resultado da soma é " + v1 + v2);

            Console.ReadKey();
            Menu();
        }

        static void Subtratao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}