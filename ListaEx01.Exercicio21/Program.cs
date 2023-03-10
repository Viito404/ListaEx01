namespace ListaEx01.Exercicio21
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
                Console.WriteLine("\nExercício25: Tabuada do N.\n");
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

                Console.Write("\nDigite o número que deseja:\n> ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                #endregion

                #region Impressão da tabuada do número desejado;

                Console.WriteLine("===============================");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"\n{n1} X {i} = {n1 * i}");
                }

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}