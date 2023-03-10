using System.ComponentModel.Design;
using System.Text.Json.Serialization;

namespace ListaEx01.Exercicio14
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
                Console.WriteLine("\nExercício17: A, B e C.\n");
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

                Console.Write("\nEntre com o valor de A:\n> ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor de B:\n> ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor de C:\n> ");
                double c = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Declaração variável resultado e formatação Double;

                double r = 0;
                r = a + b;
                double rr = Math.Round(r, 2);

                #endregion

                #region Condicionais para relacionar a soma com a variável c, e impressão dos dados;

                if (a+b > c)
                {   
                    Console.WriteLine("===============================");
                    Console.WriteLine($"\nA soma de {a} + {b} é {rr}\nA soma de A + B é maior que C({c})");
                    Console.ReadLine();
                    continue;
                }
                else if(a+b == c)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine($"\nA soma de {a} + {b} é {rr}\nA soma de A + B é igual a {c}");
                    Console.ReadLine();
                    continue;
                }
                
                else
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine($"\nA soma de {a} + {b} é {rr}\nA soma de A + B é menor que {c}");
                    Console.ReadLine();
                    continue;
                }
                #endregion

            } while (true);
        }
    }
}