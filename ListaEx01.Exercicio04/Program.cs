using System.Security.Cryptography;

namespace ListaEx01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Título e Opção de Saída;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício04: Gasto de combustível.\n");
                Console.WriteLine("===============================");

                Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

                string op;
                op = Console.ReadLine();

                if(op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }

                #endregion

                #region Entrada dos valores de quilometragem e litros;

                Console.Write("\nInforme a quilometragem percorrida:\n> ");
                double km = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nInforme quantos litros foram necessários para encher o tanque:\n> ");
                double l = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Média de consumo e formatação para Double;

                double mg = km / l;
                double mgr = Math.Round(mg, 2);

                Console.WriteLine("===============================");
                Console.WriteLine($"\nQuilometragem percorrida: {km}Km\nLitros de combustível: {l}l\nMédia de Consumo: {mgr}Km/l");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}
