using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ListaEx01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Menu e opção sair;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício09: Média harmônica de notas.\n");
                Console.WriteLine("===============================");

                Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

                string op;
                op = Console.ReadLine();

                if (op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }

                #endregion

                #region Controle quantidade de notas;

                Console.Write("\nEntre com a quantidade de notas:\n> ");
                int nn = Convert.ToInt32(Console.ReadLine());

                #endregion

                #region Criação de uma Array para armazenar as notas;

                Double[] na = new Double[nn];

                for (int i = 0; i < nn; i++)
                {
                    Console.Write($"\nEntre com a nota {i + 1}:\n> ");
                    na[i] = Convert.ToDouble(Console.ReadLine());
                }

                #endregion

                #region Soma termos da Array e formatação para Double;

                double som = na.Sum();
                double medh = som / nn;
                double medr = Math.Round(medh, 2);

                #endregion

                #region Impressão das notas e da média;

                Console.WriteLine("===============================");
                for (int i = 0; i < nn; i++)
                {
                    Console.WriteLine($"\nNota {i + 1}: {na[i]}");
                }

                Console.WriteLine($"\nA média das notas é: {medr}");

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}