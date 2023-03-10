namespace ListaEx01.Exercicio23
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
                    Console.WriteLine("\nExercício27: Fibonacci.\n");
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

                    #region Entrada de valor e controle da fórmula de Fibonacci;

                    Console.Write("\nEntre com o valor do número que deseja:\n> ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    double n = 0;
                    double fib = 1;
                    while (fib <= n1)
                    {
                         Console.Write("\n");
                         Console.Write($"\n\t = {n} \t+\t{fib}\n");
                         
                         n += fib;
                         fib += n;
                    }
                    Console.ReadLine();

                    #endregion

               } while (true);
          }
     }
}