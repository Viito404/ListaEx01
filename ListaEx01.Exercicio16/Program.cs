namespace ListaEx01.Exercicio16
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
                Console.WriteLine("\nExercício19: Índice Massa Corporal.\n");
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

                #region Entrada dos valores e cálculo do IMC;

                Console.Write("\nEntre com o valor do seu peso:\n> ");
                double p1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEntre com o valor da sua altura:\n> ");
                double h1 = Convert.ToDouble(Console.ReadLine());

                double imc = p1 / Math.Pow(h1,2);
                double imcr = Math.Round(imc);

                #endregion

                #region Alternativas do IMC;

                Console.Write("\nCondições de IMC (Adultos)\n");

                Console.WriteLine("===============================");

                if(imc < 18.5)
                {
                    Console.WriteLine($"\nSeu IMC: {imcr}");
                    Console.WriteLine("\nVocê está abaixo do peso ideal.");
                    
                }

                else if (imc < 25 || 18.5 > imc)
                {
                    Console.WriteLine($"\nSeu IMC: {imcr}");
                    Console.WriteLine("\nVocê está no peso ideal.");
                    
                }
                else
                {
                    Console.WriteLine($"\nSeu IMC: {imcr}");
                    Console.WriteLine("\nVocê está acima do peso ideal.");
                    
                }

                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}