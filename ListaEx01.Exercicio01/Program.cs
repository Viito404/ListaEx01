namespace ListaEx01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                #region Definição título e variáveis;

                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("\nExercício01: Volume da caixa.\n");
                Console.WriteLine("===============================");

                decimal c, l, h, r = 0;
                string op;

                #endregion

                #region Condicional para sair ou prosseguir;

                Console.Write("\nDigite S para sair, ou qualquer outro botão para continuar:\n> ");
                op = Console.ReadLine();

                if(op == "s" || op == "S")
                {
                    Console.WriteLine("\nSaindo...");
                    break;
                }

                #endregion

                #region Entrada e multiplicação dos valores;

                Console.Write("\nEntre com o valor do comprimento:\n > ");
                c = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nEntre com o valor da largura:\n > ");
                l = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nEntre com o valor da altura:\n > ");
                h = Convert.ToDecimal(Console.ReadLine());

                r = c * l * h;

                #endregion

                #region Conversão para String Decimal;

                decimal cf = Math.Round(c, 2);
                decimal lf = Math.Round(l, 2);
                decimal hf = Math.Round(h, 2);
                decimal rf = Math.Round(r, 2);

                #endregion

                #region Impressão dos valores no console;

                Console.WriteLine("===============================");
                Console.WriteLine($"\nComprimento: {cf}m\n\nLargura: {cf}m\n\nAltura: {cf}m\n\nVolume: {rf}m³ ou {rf * 1000000}cm³");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}