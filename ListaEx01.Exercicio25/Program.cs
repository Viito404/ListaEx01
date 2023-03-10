namespace ListaEx01.Exercicio25
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
                    Console.WriteLine("\nExercício29: Tabuada Organizada.\n");
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

                    #region Tabuada;

                    for (int p = 1; p <= 10; p++)
                    {                                              
                         for (int i = 1; i <= 10; i++)
                         {
                              Console.WriteLine($"{p} x {i} = {p * i}");
                         }
                         Console.WriteLine("");
                    }
                    Console.ReadLine();

                    #endregion

               } while (true);
          }
     }
}
