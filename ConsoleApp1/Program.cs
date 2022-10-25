internal class Program
{
    private static void Main(string[] args)
    {
        //variaveis
        double valor1, valor2, total;
        int Opcao;
        string sair;
        //variaveis
        do
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA SIMPLES ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Multiplicar");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Subtrair");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------");
            Opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 1 - Somar");
                        Console.WriteLine("Digite o primeiro numero");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        valor2 = double.Parse(Console.ReadLine());

                        total = valor1 + valor2;
                        Console.WriteLine($"Seu valor é: {total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 2 - Multiplicar");
                        Console.WriteLine("Digite o primeiro numero");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        valor2 = double.Parse(Console.ReadLine());

                        total = valor1 * valor2;
                        Console.WriteLine($"Seu valor é: {total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 3 - Dividir");
                        Console.WriteLine("Digite o primeiro numero");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        valor2 = double.Parse(Console.ReadLine());

                        total = valor1 / valor2;
                        Console.WriteLine($"Seu valor é: {total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 4 - Subtrair");
                        Console.WriteLine("Digite o primeiro numero");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        valor2 = double.Parse(Console.ReadLine());

                        total = valor1 - valor2;
                        Console.WriteLine($"Seu valor é: {total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 5 - Sair");
                        Console.WriteLine("Até mais!");
                        Environment.Exit(1);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                default:
                    Console.WriteLine("Opção não existente!");
                    break;
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Deseja continuar? Digite s   /  Deseja sair? Digite n ");
            sair = Console.ReadLine().ToUpper();
            
        } while (sair == "S");
    }
}