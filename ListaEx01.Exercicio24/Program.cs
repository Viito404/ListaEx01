namespace ListaEx01.Exercicio24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n1 = 100;
			do
			{
				#region Menu e opção de sair;

				Console.Clear();
				Console.WriteLine("===============================");
				Console.WriteLine("\nExercício28: Fizz, Buzz, FizzBuzz.\n");
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

				#region Verifica se o número é múltiplo de 3 e 5, 3 ou 5;

				for (int i = 1; i <= n1; i++)
				{

					if (i % 5 == 0 && i % 3 == 0)
					{
						Console.WriteLine($"FizzBuzz");
					}

					else if (i % 3 == 0)
					{
						Console.WriteLine($"Fizz");
					}

					else if (i % 5 == 0)
					{
						Console.WriteLine($"Buzz");
					}
					else
					{
						Console.WriteLine($"{i}");
					}
				}

                    Console.ReadLine();

                    #endregion

               } while (true);
		}
	}
}