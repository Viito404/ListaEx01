namespace ListaEx01.Exercicio09
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
                Console.WriteLine("\nExercício11: Número Primo.\n");
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

                #region Entrada do número e controlador de divisões;

                Console.Write("\nEntre com o valor do número:\n> ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                int dv = 0;

                #endregion

                #region Estrutura para identificar se o número é divisível por 1 ou ele mesmo;

                for (int i = 1; i <= n1; i++)
                {
                    if(n1 % i == 0)
                    {
                        dv++;
                    }
                }

                #endregion

                #region Verifica a quantidade de divisões que o número faz;

                if (dv == 2)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine($"\nO número {n1} é primo!");
                    Console.ReadKey();
                    continue;
                }
                else
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine($"\nO número {n1} não é primo!");
                    Console.ReadKey();
                    continue;
                }

                #endregion

            } while (true);
            
        }
    }
}