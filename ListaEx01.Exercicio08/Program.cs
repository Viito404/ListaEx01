using System.ComponentModel.DataAnnotations;

namespace ListaEx01.Exercicio08
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
                Console.WriteLine("\nExercício10: Média ponderada de notas.\n");
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

                #region Entrada das notas e seus pesos;

                Console.Write("\nEntre com o valor da primeira nota:\n> ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o peso da primeira nota:\n> ");
                double p1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor da segunda nota:\n> ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o peso da segunda nota:\n> ");
                double p2 = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Calculo média ponderada e formatação Double;

                double mdp = (n1 * p1 + n2 * p2) / (p1 + p2);
                double mdpr = Math.Round(mdp, 2);

                #endregion

                #region Impressão notas, pesos e média ponderada;

                Console.WriteLine("===============================");
                Console.WriteLine($"\nPrimeira nota: {n1}\nSeu peso: {p1}");
                Console.WriteLine($"\nSegunda nota {n2}\nSeu peso: {p2}");

                Console.WriteLine($"\nMédia ponderada das notas: {mdpr}");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}