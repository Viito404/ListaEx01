using System;

namespace ListaEx01.Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Título, Menu de Opções;
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício02: O Termômetro.\n");
                Console.WriteLine("===============================");

                Console.Write("\nDigite 1 para Celsius>Fahreinheit;\n\nDigite 2 para Fahreinheit>Celsius;\n\nDigite S para Sair do programa;\n> ");
                String op = Console.ReadLine();
                #endregion

                #region Opções condicionais Celsius e Fahreinheit, Saída e Feedback de entrada inválida;

                if (op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }
                if(op == "1")
                {
                    Console.Write("\nEntre com o valor em Celsius:\n > ");
                    double cs = Convert.ToDouble(Console.ReadLine());
                    double cc = (cs * 9 / 5) + 32;
                    Console.WriteLine($"\nO valor de Celsius: {cs}Cº\n\nConversão em Fahreinheit: {cc}Fº");
                    Console.ReadLine();
                    continue;
                }
                if(op == "2")
                {
                    Console.Write("\nEntre com o valor em Fahreinheit:\n > ");
                    double fh = Convert.ToDouble(Console.ReadLine());
                    double fc = (fh - 32) * 5/9;
                    Console.WriteLine($"\nO valor de Fahreinheit: {fh}Fº\n\nConversão em Celsius: {fc}Cº");
                    Console.ReadLine();
                    continue;
                }

                else
                {
                    Console.WriteLine("\nEntre com um valor válido!");
                    Console.ReadLine();
                    continue;
                }

                #endregion

            } while (true);

        }
    }
}