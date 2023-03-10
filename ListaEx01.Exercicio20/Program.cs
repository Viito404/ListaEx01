namespace ListaEx01.Exercicio20
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
                Console.WriteLine("\nExercício24: Números múltiplos de 3 e ímpares.\n");
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

                #region Array, estrutura condicional e verificação de números múltiplos de 3 e ímpares;

                int[] n1 = new int[500];

                Console.WriteLine("===============================");

                for (int i = 0; i < n1.Length; i++)
                {

                    n1[i] = i + 1;
                    if (n1[i] % 3 == 0 && n1[i] % 2 != 0)
                    {
                        Console.WriteLine($"\n{n1[i]}");
                        int ns = n1.Sum();
                        Console.WriteLine($"\nSoma: {ns}");
                    }

                }

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}