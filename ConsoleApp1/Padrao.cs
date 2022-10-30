namespace Calculadora
{
    internal class Padrao
    {
        public static void CalcSimples()
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ------ CALCULADORA PADRÃO 2 NÚMEROS ------");
                    Console.WriteLine("Escolha a opção desejada abaixo: ");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Multiplicar");
                    Console.WriteLine("3 - Dividir");
                    Console.WriteLine("4 - Subtrair");
                    Console.WriteLine("5 - Fração");
                    Console.WriteLine("6 - Raiz Quadrada");
                    Console.WriteLine("7 - Número Elevado ao Quadrado");
                    Console.WriteLine("8 - Porcentagem");
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 1 - Somar");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Digite o primeiro número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo número");
                                    Global.valor2 = decimal.Parse(Console.ReadLine());

                                    Global.total = Global.valor1 + Global.valor2;
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 2 - Multiplicar");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Digite o primeiro número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo número");
                                    Global.valor2 = decimal.Parse(Console.ReadLine());

                                    Global.total = Global.valor1 * Global.valor2;
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 3 - Dividir");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Digite o primeiro número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo número");
                                    Global.valor2 = (decimal)double.Parse(Console.ReadLine());

                                    Global.total = Global.valor1 / Global.valor2;
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 4 - Subtrair");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Digite o primeiro número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o segundo número");
                                    Global.valor2 = decimal.Parse(Console.ReadLine());

                                    Global.total = Global.valor1 - Global.valor2;
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 5 - Fração");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Digite um número");
                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                    Global.total = 1 / Global.valor1;
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
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 6 - Raiz Quadrada");
                                    Console.WriteLine("-------------------------------");
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
                        case 7:
                            try
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 7 - Número Elevado ao Quadrado");
                                    Console.WriteLine("-------------------------------");
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
                        case 8:
                            try
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Opção escolhida -- > 8 - Porcentagem");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Qual tipo de conta deseja fazer?");
                                    Console.WriteLine("1 - Somar");
                                    Console.WriteLine("2 - Multiplicar");
                                    Console.WriteLine("3 - Dividir");
                                    Console.WriteLine("4 - Subtrair");
                                    Console.WriteLine("5 - Apenas resultado");
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine("Opção: "); Global.Tipo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("-------------------------------");
                                    if(Global.Tipo != 5)
                                    {
                                        Console.WriteLine("Digite o primeiro número");
                                        Global.valor1 = decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("Número porcento");
                                        Global.valor2 = decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Digite o primeiro número");
                                        Global.valor1 = decimal.Parse(Console.ReadLine());
                                        Console.WriteLine("-------------------------------");
                                    }
                                    
                                    switch (Global.Tipo)
                                    {

                                        case 1:
                                            Global.total = Global.valor1 + (Global.valor1 * (Global.valor2 / 100));
                                            Console.WriteLine($"Seu valor é: {Math.Round(Global.total,2)}");
                                            Console.WriteLine("-------------------------------");
                                            break;
                                        case 2:
                                            Global.total = Global.valor1 * (Global.valor2 / 100);
                                            Console.WriteLine($"Seu valor é: {Math.Round(Global.total, 2)}");
                                            Console.WriteLine("-------------------------------");
                                            break;
                                        case 3:
                                            Global.total = Global.valor1 / (Global.valor2 / 100);
                                            Console.WriteLine($"Seu valor é: {Math.Round(Global.total, 2)}");
                                            Console.WriteLine("-------------------------------");
                                            break;
                                        case 4:
                                            Global.total = Global.valor1 - (Global.valor1 * (Global.valor2 / 100));
                                            Console.WriteLine($"Seu valor é: {Math.Round(Global.total, 2)}");
                                            Console.WriteLine("-------------------------------");
                                            break;
                                        case 5:
                                            Global.total = Global.valor1 / 100;
                                            Console.WriteLine($"Seu valor é: {Math.Round(Global.total, 2)}");
                                            Console.WriteLine("-------------------------------");
                                            break;
                                        default:
                                            Console.Clear();

                                            Console.WriteLine("-------------------------------");
                                            Console.WriteLine("Tipo de cálculo não existente!");
                                            break;
                                    }
                                    
                                    //Console.WriteLine($"Seu valor é: {Global.total}");
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
                        case 9:
                            return;
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
