using System.Runtime.InteropServices;

namespace ListaEx01.Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Menu e opção de sair;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício26: Fatorial.\n");
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

                #region Entrada de valores;

                Console.Write("\nEntre com o número:\n> ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write($"{n1}");

                int result = 1;

                #endregion

                #region Repetição do fatorial; 

                for (int i = n1; i > 1; i--)
                {
                    Console.Write($" x ");
                    Console.Write($"{i - 1}");
                    result *= i;
                }

                Console.Write(" = ");

                Console.Write($"{result}");

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}