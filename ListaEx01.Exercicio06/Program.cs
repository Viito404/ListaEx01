using System.Security.Cryptography.X509Certificates;

namespace ListaEx01.Exercicio06; 

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            #region Título e opção sair;

            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("\nExercício07: Salário de funcionário.\n");
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

            #region Entrada valores salário, vendas e comissão;

            Console.Write("\nEntre com o valor do salário: \n> ");
            double salb = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEntre com o valor das vendas: \n> ");
            double ven = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEntre com o percentual da comissão: \n> ");
            double com = Convert.ToDouble(Console.ReadLine());

            #endregion

            #region Cálculo salário e formatação Double;

            double salt = salb + ven * (com / 100);
            double saltr = Math.Round(salt, 2);

            #endregion

            #region Impressão resultados;

            Console.WriteLine("===============================");
            Console.Write($"\nSalário base: R$ {salb}\nValor das Vendas: R$ {ven}\nPercentual da comissão: {com}%\nSalário final: R$ {salt}\n> ");
            Console.ReadLine();

            #endregion

        } while (true);  
    }
}