namespace ListaEx01.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           do
            {
                #region Título e opção de saída;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício05: Volume esférico.\n");
                Console.WriteLine("===============================");

                Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");

                string op;
                op = Console.ReadLine();

                if(op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }

                #endregion

                #region Entrada valor do raio da esfera;

                Console.Write("\nEntre com o valor do raio da esfera: \n> ");
                double r = Convert.ToDouble(Console.ReadLine());

                #endregion

                #region Cálculo Volume da esfera e impressão;

                double ve = (4 * Math.PI * Math.Pow(r,3))/ 3;
                double ver = Math.Round(ve,2);

                Console.WriteLine("===============================");
                Console.WriteLine($"\nO valor do raio é: {r}\nO volume da esfera é: {ver}m³ ou {ver * 1000000}cm³");
                Console.ReadLine();

                #endregion

            } while (true);   
        }
    }
}