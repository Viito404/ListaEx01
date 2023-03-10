namespace ListaEx01.Exercicio10
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
                Console.WriteLine("\nExercício12: Terrenos retangulares.\n");
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

                Console.Write("\nEntre com o valor da base:\n> ");
                double vb = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor da altura:\n> ");
                double vh = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Calculo Área e formatação Double;

                double ar = vb * vh;
                double arr = Math.Round(ar, 2);
                double vbr = Math.Round(vb, 2);
                double vhr = Math.Round(vh, 2);

                #endregion

                #region Impressão;

                Console.WriteLine("===============================");
                Console.WriteLine($"\nBase: {vbr}m\nAltura: {vhr}m\nÁrea: {arr}m² ou {arr * 10000}cm²");

                #endregion

                Console.ReadLine();

            } while (true);
        }
    }
}