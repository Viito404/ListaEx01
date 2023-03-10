namespace ListaEx01.Exercicio19
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
                Console.WriteLine("\nExercício23: Pares e ímpares, 100 e 200.\n");
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

                #region Condição para impressão dos números de 100 a 200;

                Console.WriteLine("===============================");

                Console.WriteLine("\nNúmeros ímpares de 100 a 200");

                for (int n1 = 100; n1 < 200; n1++)
                    {
                        if (n1 % 2 != 0)
                        {
                            Console.Write($"\n{n1}");                           
                        }                  
                }

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}