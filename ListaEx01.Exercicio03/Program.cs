namespace ListaEx01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Título e opção de sair;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício03: Volume cilíndrico.\n");
                Console.WriteLine("===============================");

                string op;

                Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");
                op = Console.ReadLine();

                if(op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }

                #endregion

                #region Entrada valor raio e altura;

                Console.Write("\nEntre com o valor do raio:\n> ");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor da altura:\n> ");
                double h = Convert.ToDouble(Console.ReadLine());

                double ab = Math.PI * Math.Pow(r, 2);
                double vol = ab * h;

                #endregion

                #region Formatação para Double e impressão dos resultados;

                double volr = Math.Round(vol, 2);

                Console.WriteLine("===============================");
                Console.Write($"\nO valor do raio é: {r}\nO valor da altura é: {h}\nO volume do cilindro é: {volr}m³ ou {volr * 1000000}cm³");
                Console.ReadLine();

                #endregion

            } while (true);
    }
    }
}
