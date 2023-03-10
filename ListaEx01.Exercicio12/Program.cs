using System.IO.Pipes;

namespace ListaEx01.Exercicio12
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
                Console.WriteLine("\nExercício14: Nome e dias.\n");
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

                #region Constante de dias em um ano, e entrada de valores

                int an = 365;

                Console.Write("\nEscreva o seu nome:\n> ");
                String na = Console.ReadLine();

                Console.Write("\nDigite a sua idade:\n> ");
                int id = int.Parse(Console.ReadLine());

                #endregion

                #region Cálculo e impressão;

                int dan = id * an;

                Console.WriteLine("===============================");
                Console.WriteLine($"\n{na}, você já viveu {dan} dias.");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}