namespace ListaEx01.Exercicio13
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
                Console.WriteLine("\nExercício16: Salários, descontos e aumentos.\n");
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

                #region Entrada de valores e cálculos salário inicial, aumento, salário com aumento, e salário final;

                Console.Write("\nEntre com o valor do salário inicial:\n> ");
                double sali = Convert.ToDouble(Console.ReadLine());

                double au = (sali * 0.15);
                double sala = au + sali;
                double salf = sala * 0.08;

                #endregion

                #region Formatação para Double;

                double aur = Math.Round(au, 2);
                double salar = Math.Round(sala, 2);
                double salfr = Math.Round(salf, 2);

                #endregion

                #region Impressão de dados;

                Console.WriteLine("===============================");
                Console.WriteLine($"\nValor do salário inicial: R${sali}\nValor do aumento: R${aur}\nValor do salário com aumento: R${salar}\nValor do salário final: R${salfr}");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}