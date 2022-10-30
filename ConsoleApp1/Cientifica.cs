namespace Calculadora
{
    internal class Cientifica
    {
        public static void CalcIntermediaria()
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ------ CALCULADORA CIENTÍFICA ------");
                    Console.WriteLine("Escolha a opção desejada abaixo: ");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1 - Fatorial");
                    Console.WriteLine("2 - Número Elevado à Outro Número");
                    Console.WriteLine("3 - Raiz Quadrada");
                    Console.WriteLine("4 - Número Elevado ao Quadrado");
                    Console.WriteLine("5 - Pi");
                    Console.WriteLine("6 - Log");
                    Console.WriteLine("7 - Absoluto");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine("-------------------------------");
                    Global.Opcao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (Global.Opcao)
                    {
                        case 1:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 1 - Fatorial");
                                    Console.WriteLine("Digite o número:");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Global.total = 0;
                                    for (decimal i = Global.valor1 - 1; i >= 1; i--)
                                    {
                                        Global.valor1 = Global.valor1 * i;
                                    }
                                    Global.total = Global.valor1;
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)

                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 2:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 2 - Número Elevado à Outro Número");
                                    Console.WriteLine("Digite o primeiro número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo número");
                                    Global.valor2 = decimal.Parse(Console.ReadLine());

                                    Global.total = (decimal)Math.Pow((double)Global.valor1, (double)Global.valor2);
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 3:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 3 - Raiz Quadrada");
                                    Console.WriteLine("Digite um número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                    Global.total = (decimal)Math.Sqrt((double)Global.valor1);
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 4:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 4 - Número Elevado ao Quadrado");
                                    Console.WriteLine("Digite um número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                    Global.total = (decimal)Math.Pow((double)Global.valor1, 2);
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 5:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 5 - Pi");
                                    Global.total = (decimal)Math.PI;
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 6:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 6 - Log");
                                    Console.WriteLine("Digite o primeiro numero");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                    Global.total = (decimal)Math.Log((double)Global.valor1, 10);
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro", ex);
                            }
                            break;
                        case 7:
                            try
                            {
                                do
                                {
                                    Console.WriteLine("Opção escolhida -- > 7 - Absoluto");
                                    Console.WriteLine("Digite o primeiro numero");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                    Global.total = Math.Abs(Global.valor1);
                                    Console.WriteLine($"Seu valor é: {Global.total}");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Deseja calcular novamente? Digite s (SIM)  /  Digite n (NÃO)");
                                    Global.sair = char.Parse(Console.ReadLine());
                                } while (Global.sair != 'n');
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
                } while (Global.Opcao != 0);
            }
            catch (Exception ex)

            {
                Console.WriteLine("Erro", ex);
            }
        }
    }
}
