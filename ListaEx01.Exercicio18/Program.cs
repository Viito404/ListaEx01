namespace ListaEx01.Exercicio18
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
                Console.WriteLine("\nExercício21 e 22: Somas ou multiplicações.\n");
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

                Console.Write("\nEntre com o valor do primeiro número inteiro:\n> ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEntre com o valor do segundo número inteiro:\n> ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                #endregion

                #region Impressão de valores e alternativas de resultado;

                Console.WriteLine("===============================");

                if (n1 == n2)
                {
                    Console.Write($"\nValor 1: {n1}");
                    Console.Write($"\nValor 2: {n2}");
                    int c = n1 + n2;
                    Console.Write($"\nA soma dos valores é: {c}");
                    Console.ReadLine();
                }

                else
                {
                    Console.Write($"\nValor 1: {n1}");
                    Console.Write($"\nValor 2: {n2}");
                    int c = n1 * n2;
                    Console.Write($"\nA multiplicação dos valores é: {c}");
                    Console.ReadLine();                   
                }

                #endregion

            } while (true);
        }
    }
}