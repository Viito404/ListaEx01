namespace ListaEx01.Exercicio11
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
                Console.WriteLine("\nExercício13: Pães e Broas.\n");
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

                #region Valor constante dos produtos e entrada de valores da quantidade de vendas;

                double po = 0.12;
                double br = 1.50;

                Console.Write("\nQuantidade de pães vendidos:\n> ");
                int qvp = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nQuantidade de broas vendidas:\n> ");
                int qvb = Convert.ToInt32(Console.ReadLine());

                #endregion

                #region Cálculo Vendas totais e arrecadção poupança;

                double vvbp = (qvp * po) + (qvb * br);
                double ap = vvbp * 0.1;

                #endregion

                #region Impressão de dados;

                Console.WriteLine("===============================");
                Console.WriteLine($"Preço Pão: R$0,12\nPreço Broa: R$1,50\n\nPães vendidos: {qvp}\nBroas Vendidas: {qvb}\n\nPreço total das vendas: R${vvbp}\n\nArrecadação para poupança: R${ap}");
                Console.ReadLine();

                #endregion

            } while (true);
        }
    }
}