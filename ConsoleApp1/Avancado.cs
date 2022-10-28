namespace Calculadora
{
    internal class Avancado
    {
        public static void CalcAvancada()
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA AVANÇADA ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Programador");
            Console.WriteLine("2 - Cálculo de Data");
            Console.WriteLine("3 - Conversor");
            Console.WriteLine("4 - ");
            Console.WriteLine("5 - ");
            Console.WriteLine("6 - ");
            Console.WriteLine("7 - ");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("-------------------------------");
            Global.Opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 1 - Programador");
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 2 - Cálculo de Data");
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
                            Console.WriteLine("Opção escolhida -- > 3 - Conversor");
                            Console.WriteLine("O que deseja converter?");
                            Console.WriteLine("1 - Moeda");
                            Console.WriteLine("2 - Volume");
                            Console.WriteLine("3 - Comprimento");
                            Console.WriteLine("4 - Peso e massa");
                            Console.WriteLine("5 - Temperatura");
                            Console.WriteLine("6 - Energia");
                            Console.WriteLine("7 - Área");
                            Console.WriteLine("8 - Velocidade");
                            Console.WriteLine("9 - Potência");
                            Console.WriteLine("10 - Dados");
                            Console.WriteLine("11 - Pressão");
                            Console.WriteLine("12 - Ângulo");
                            Console.WriteLine("13 - Sair");
                            Global.Opcao = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (Global.Opcao == 1)
                            {
                                do
                                {

                                    //Process.Start("python", @"C:\Users\Usuario\Desktop\Pasta\ConsoleApp1\ConsoleApp1\moedas.py");
                                    //até aqui  está ok, mas ele nao executa corretamente o arquivo .py
                                    Console.Clear();
                                    Console.WriteLine("----- MOEDA -----");
                                    Console.WriteLine("1 - Real");
                                    Console.WriteLine("2 - Dolar(EUA)");
                                    Console.WriteLine("3 - Euro(Europa)");
                                    Console.WriteLine("4 - Peso(Argentina)");
                                    Console.WriteLine("5 - Yuan(China)");
                                    Console.WriteLine("6 - Sair");
                                    Global.Tipo = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch (Global.Tipo)
                                    {
                                        case 1:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Real para qual moeda?");
                                                Console.WriteLine("1 - Para Dolar(EUA)");
                                                Console.WriteLine("2 - Para Euro(Europa)");
                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                Console.WriteLine("4 - Para Yuan(China)");
                                                Console.WriteLine("5 - Voltar");
                                                Global.subtipo = int.Parse(Console.ReadLine());
                                                Console.Clear();
                                                switch (Global.subtipo)
                                                {
                                                    case 1:
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRDolar();

                                                                Global.total = Global.moeda;
                                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }
                                                        }
                                                        break;
                                                    case 2:
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BREuro();

                                                                Global.total = Global.moeda;
                                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }

                                                        }
                                                        break;
                                                    case 3:
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRPeso();

                                                                Global.total = Global.moeda;
                                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }

                                                        }
                                                        break;
                                                    case 4:
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRYuan();

                                                                Global.total = Global.moeda;
                                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }

                                                        }
                                                        break;
                                                    case 5:
                                                        return;
                                                    default:
                                                        Console.WriteLine("Tipo de conversão não existente!");
                                                        break;
                                                }

                                            }
                                            break;
                                        case 2:
                                            {
                                                Console.WriteLine("Conversão escolhida: 2 - Real para Euro(Europa)");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.BREuro();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                            }
                                            break;
                                        case 3:
                                            {
                                                Console.WriteLine("Conversão escolhida: 3 - Real para Peso(Argentina)");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.BRPeso();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                            }
                                            break;
                                        case 4:
                                            {
                                                Console.WriteLine("Conversão escolhida: 4 - Real para Yuan(China)");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.BRYuan();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                            }
                                            break;
                                        case 5:
                                            {
                                                Console.WriteLine("Conversão escolhida: 4 - Real para Yuan(China)");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.BRYuan();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                            }
                                            break;
                                        case 6:
                                            return;
                                        default:
                                            Console.WriteLine("Tipo de conversão não existente!");
                                            break;
                                    }
                                } while (Global.Tipo != 9);
                            }
                            else if (Global.Opcao == 2)
                            {
                                Console.WriteLine("----- VOLUME -----");
                            }
                            else if (Global.Opcao == 3)
                            {
                                Console.WriteLine("----- COMPRIMENTO -----");
                            }
                            else if (Global.Opcao == 4)
                            {
                                Console.WriteLine("----- PESO E MASSA -----");
                            }
                            else if (Global.Opcao == 5)
                            {
                                Console.WriteLine("----- TEMPERATURA -----");

                                Console.WriteLine("1 - Celcius");
                                {
                                    Console.WriteLine("1.1 - Para Fhrenheit");
                                    Console.WriteLine("1.2 - Para Kelvin");
                                }
                                Console.WriteLine("2 - Fahrenheit");
                                {
                                    Console.WriteLine("2.1 - Para Celcius");
                                    Console.WriteLine("2.2 - Para Kelvin");
                                }
                                Console.WriteLine("3 - Kelvin");
                                {
                                    Console.WriteLine("3.1 - Para Celcius");
                                    Console.WriteLine("3.2 - Para Fhrenheit");
                                }
                            }
                            else if (Global.Opcao == 6)
                            {
                                Console.WriteLine("----- ENERGIA -----");
                            }
                            else if (Global.Opcao == 7)
                            {
                                Console.WriteLine("----- ÁREA -----");
                            }
                            else if (Global.Opcao == 8)
                            {
                                Console.WriteLine("----- VELOCIDADE -----");
                            }
                            else if (Global.Opcao == 9)
                            {
                                Console.WriteLine("----- POTÊNCIA -----");
                            }
                            else if (Global.Opcao == 10)
                            {
                                Console.WriteLine("----- DADOS -----");
                            }
                            else if (Global.Opcao == 11)
                            {
                                Console.WriteLine("----- PRESSÃO -----");
                            }
                            else if (Global.Opcao == 12)
                            {
                                Console.WriteLine("----- ÂNGULO -----");
                            }
                            else if (Global.Opcao == 13)
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Opção não existente!");
                            }
                        } while (Global.Opcao != 13);
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Opção não existente!");
                    break;
            }
        }
    }
}
