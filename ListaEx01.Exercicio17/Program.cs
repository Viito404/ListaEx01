namespace ListaEx01.Exercicio17
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
                Console.WriteLine("\nExercício20: Ímpares e pares.\n");
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

                #region Entrada valor do número;

                Console.Write("\nEntre com o valor do número:\n> ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Verifica se o valor é par ou ímpar;

                Console.WriteLine("===============================");
                if (n1 % 2 == 0)
                {
                    Console.Write("\nSeu número é par");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("\nSeu número é ímpar");
                    Console.ReadLine();
                }

                #endregion

            } while (true);
        }
    }
}