namespace ListaEx01.Exercicio15
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
                Console.WriteLine("\nExercício18: Ordem decrescente.\n");
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

                #region Criação de uma Array e atribuição de valores em suas posições;

                int[] od = new int[3];

                for(int i=0;i<od.Length;i++)
                {
                    Console.Write($"\nEntre com o valor do número inteiro {i+1}:\n> ");
                    od[i] = Convert.ToInt32(Console.ReadLine());
                }

                #endregion

                #region Ordenação decrescente;

                Console.WriteLine("===============================");
                Console.Write("\nOrdem decrescente:\n");

                for (int i=0;i<od.Length; i++)
                {
                    Array.Reverse(od);
                    Console.Write($"\n{od[i]}\n");
                }

                #endregion

                #region Ordenação crescente;

                Console.WriteLine("\n--------------------------");

                Console.Write("\nOrdem Crescente:\n");

                for (int i = 0; i < od.Length; i++)
                {
                    Array.Sort(od);
                    Console.Write($"\n{od[i]}\n");
                }

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}