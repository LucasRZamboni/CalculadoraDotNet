internal class Program
{
    private static void Main(string[] args)
    {
        //variaveis
        decimal valor1, valor2, total;
        int Opcao, Tipo;
        string sair;
        //variaveis
        do
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Simples");
            Console.WriteLine("2 - Intermediária");
            Console.WriteLine("3 - Avançada");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("-------------------------------");
            Tipo = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Tipo)
            {
                case 1:
                    //------ CALCULADORA SIMPLES-------------------------------
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" ------ CALCULADORA SIMPLES 2 NÚMEROS ------");
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
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero");
                                    valor2 = decimal.Parse(Console.ReadLine());

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
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero");
                                    valor2 = decimal.Parse(Console.ReadLine());

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
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero");
                                    valor2 = (decimal)double.Parse(Console.ReadLine());

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
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero");
                                    valor2 = decimal.Parse(Console.ReadLine());

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
                    //------ CALCULADORA SIMPLES-------------------------------
                    break;
                case 2:
                    //------ CALCULADORA INTERMEDIÁRIA-------------------------------
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" ------ CALCULADORA INTERMEDIÁRIA ------");
                        Console.WriteLine("Escolha a opção desejada abaixo: ");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("1 - Fatorial");
                        Console.WriteLine("2 - Número Elevado à Outro Número");
                        Console.WriteLine("3 - Raiz Quadrada");
                        Console.WriteLine("4 - Número Elevado ao Quadrado");
                        Console.WriteLine("5 - Pi");
                        Console.WriteLine("6 - Log");
                        Console.WriteLine("7 - Sair");
                        Console.WriteLine("-------------------------------");
                        Opcao = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (Opcao)
                        {
                            case 1:
                                try
                                {
                                    Console.WriteLine("Opção escolhida -- > 1 - Fatorial (n!)");
                                    Console.WriteLine("Digite o número:");
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    total=0;
                                    for (decimal i = valor1 - 1 ; i >= 1; i--)
                                    {
                                        valor1 = valor1 * i;
                                    }
                                    total = valor1;
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
                                    Console.WriteLine("Opção escolhida -- > 2 - Número Elevado à Outro Número");
                                    Console.WriteLine("Digite o primeiro numero");
                                    valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo numero");
                                    valor2 = decimal.Parse(Console.ReadLine());

                                    total = (decimal)Math.Pow((double)valor1, (double)valor2);
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
                                    Console.WriteLine("Opção escolhida -- > 3 - Raiz Quadrada");
                                    Console.WriteLine("Digite o primeiro numero");
                                    valor1 = decimal.Parse(Console.ReadLine());

                                    total = (decimal)Math.Sqrt((double)valor1);
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
                                    Console.WriteLine("Opção escolhida -- > 4 - Número Elevado ao Quadrado");
                                    Console.WriteLine("Digite o primeiro numero");
                                    valor1 = decimal.Parse(Console.ReadLine());

                                    total = (decimal)Math.Pow((double)valor1,2);
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
                                    Console.WriteLine("Opção escolhida -- > 5 - Pi");                                  
                                    total = (decimal)Math.PI;
                                    Console.WriteLine($"Seu valor é: {total}");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Erro", ex);
                                }
                                break;
                            case 6:
                                try
                                {
                                    Console.WriteLine("Opção escolhida -- > 6 - Log");
                                    Console.WriteLine("Digite o primeiro numero");
                                    valor1 = decimal.Parse(Console.ReadLine());

                                    total = (decimal)Math.Log((double)valor1,10);
                                    Console.WriteLine($"Seu valor é: {total}");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Erro", ex);
                                }
                                break;
                            case 7:
                                try
                                {
                                    Console.WriteLine("Opção escolhida -- > 7 - Sair");
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
                    break;
                //------ CALCULADORA INTERMEDIÁRIA-------------------------------

                default:
                    Console.WriteLine("Tipo de calculadora não existente!");
                    break;
            }
        } while (Tipo != 4);
    }
}