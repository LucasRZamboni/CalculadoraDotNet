using System.Globalization;

namespace Calculadora
{
    internal class Avancado
    {
        public static void CalcAvancada()
        {
            do
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
                                Console.WriteLine("-------------------------------");
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
                                switch (Global.Opcao)
                                {
                                    case 1:
                                        try
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

                                                        try
                                                        {
                                                            do
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("----- REAL -----");
                                                                Console.WriteLine("Real para qual moeda?");
                                                                Console.WriteLine("1 - Para Dolar(EUA)");
                                                                Console.WriteLine("2 - Para Euro(Europa)");
                                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("5 - Voltar");
                                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                                Console.Clear();
                                                                switch (Global.Tipo)
                                                                {

                                                                    case 1:

                                                                        try
                                                                        {
                                                                            do
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Opção escolhida -- > 1 - Para Dolar(EUA)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRDolar();

                                                                                Global.total = Global.moeda;
                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                                                Console.WriteLine("Opção escolhida -- > 2 - Para Euro(Europa)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BREuro();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }
                                                                        break;
                                                                    case 3:
                                                                        do
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Opção escolhida -- > 3 - Para Peso(Argentina)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRPeso();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                Console.WriteLine("Erro", ex);
                                                                            }
                                                                            Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                                            Global.sair = char.Parse(Console.ReadLine());
                                                                        } while (Global.sair != 's');
                                                                        break;
                                                                    case 4:
                                                                        do
                                                                        {
                                                                            try
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("Opção escolhida -- > 4 - Para Yuan(China)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRYuan();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                Console.WriteLine("Erro", ex);
                                                                            }
                                                                            Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                                            Global.sair = char.Parse(Console.ReadLine());
                                                                        } while (Global.sair != 's');
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine("Tipo de conversão não existente!");
                                                                        break;
                                                                }
                                                            } while (Global.Tipo != 5);
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
                                                                Console.WriteLine("----- DOLAR -----");
                                                                Console.WriteLine("Real para qual moeda?");
                                                                Console.WriteLine("1 - Para Real(BRL)");
                                                                Console.WriteLine("2 - Para Euro(Europa)");
                                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("0 - Voltar");
                                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                                Console.Clear();
                                                                switch (Global.Tipo)
                                                                {

                                                                    case 1:

                                                                        try
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("Opção escolhida -- > 1 - Para Real(BRL)");
                                                                            Console.WriteLine("-------------------------------");
                                                                            Console.WriteLine("Digite o número:");
                                                                            Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                            Conversão.DolarBR();

                                                                            Global.total = Global.moeda;
                                                                            Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                            Console.WriteLine("-------------------------------");
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }

                                                                        break;
                                                                    case 2:

                                                                        try
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("Opção escolhida -- > 2 - Para Euro(Europa)");
                                                                            Console.WriteLine("-------------------------------");
                                                                            Console.WriteLine("Digite o número:");
                                                                            Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                            Conversão.BREuro();

                                                                            Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                            Console.WriteLine("-------------------------------");
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }


                                                                        break;
                                                                    case 3:

                                                                        try
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("Opção escolhida -- > 3 - Para Peso(Argentina)");
                                                                            Console.WriteLine("-------------------------------");
                                                                            Console.WriteLine("Digite o número:");
                                                                            Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                            Conversão.BRPeso();

                                                                            Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                            Console.WriteLine("-------------------------------");
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }


                                                                        break;
                                                                    case 4:

                                                                        try
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("Opção escolhida -- > 4 - Para Yuan(China)");
                                                                            Console.WriteLine("-------------------------------");
                                                                            Console.WriteLine("Digite o número:");
                                                                            Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                            Conversão.BRYuan();

                                                                            Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                            Console.WriteLine("-------------------------------");
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine("Tipo de conversão não existente!");
                                                                        break;

                                                                }

                                                            } while (Global.Tipo != 0);

                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            Console.WriteLine("Erro", ex);
                                                        }
                                                        break;
                                                    case 3:
                                                        do
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Conversão escolhida: 3 - Real para Peso(Argentina)");
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRPeso();

                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                Console.WriteLine("-------------------------------");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }
                                                            Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                            Global.sair = char.Parse(Console.ReadLine());
                                                        } while (Global.sair != 's');

                                                        break;
                                                    case 4:
                                                        do
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Conversão escolhida: 4 - Real para Yuan(China)");
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRYuan();

                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                Console.WriteLine("-------------------------------");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }
                                                            Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                            Global.sair = char.Parse(Console.ReadLine());
                                                        } while (Global.sair != 's');

                                                        break;
                                                    case 5:
                                                        do
                                                        {
                                                            try
                                                            {
                                                                Console.WriteLine("Conversão escolhida: 4 - Real para Yuan(China)");
                                                                Console.WriteLine("Digite o número:");
                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                Conversão.BRYuan();

                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                Console.WriteLine("-------------------------------");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                Console.WriteLine("Erro", ex);
                                                            }
                                                            Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                            Global.sair = char.Parse(Console.ReadLine());
                                                        } while (Global.sair != 's');

                                                        break;
                                                    case 6:
                                                        break;

                                                    default:
                                                        Console.WriteLine("Tipo de conversão não existente!");
                                                        break;
                                                }
                                            } while (Global.Tipo != 0);

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            Console.WriteLine("----- VOLUME -----");
                                        }

                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }

                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("----- COMPRIMENTO -----");
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.WriteLine("----- PESO E MASSA -----");
                                        }
                                        break;
                                    case 5:
                                        {
                                            try { 

                                            Console.WriteLine("----- TEMPERATURA -----");
                                            switch (Global.Tipo)
                                            {

                                                case 1:
                                                    Console.WriteLine("1 - Celcius");
                                                    {
                                                        Console.WriteLine("1.1 - Para Fhrenheit");
                                                        Console.WriteLine("1.2 - Para Kelvin");
                                                    }
                                                    break;
                                                case 2:
                                                    Console.WriteLine("2 - Fahrenheit");
                                                    {
                                                        Console.WriteLine("2.1 - Para Celcius");
                                                        Console.WriteLine("2.2 - Para Kelvin");
                                                    }
                                                    break;
                                                case 3:
                                                    Console.WriteLine("3 - Kelvin");
                                                    {
                                                        Console.WriteLine("3.1 - Para Celcius");
                                                        Console.WriteLine("3.2 - Para Fhrenheit");
                                                    }
                                                    break;
                                                default:
                                                    Console.WriteLine("Tipo de conversão não existente!");
                                                    break;

                                            }
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine("Erro", ex);
                                            }
                                        }
                                        break;
                                    case 6:
                                        {
                                            Console.WriteLine("----- ENERGIA -----");
                                        }
                                        break;
                                    case 7:
                                        {
                                            Console.WriteLine("----- ÁREA -----");
                                        }
                                        break;
                                    case 8:
                                        {
                                            Console.WriteLine("----- VELOCIDADE -----");
                                        }
                                        break;
                                    case 9:
                                        {
                                            Console.WriteLine("----- POTÊNCIA -----");
                                        }
                                        break;
                                    case 10:
                                        {
                                            Console.WriteLine("----- DADOS -----");
                                        }
                                        break;
                                    case 11:
                                        {
                                            Console.WriteLine("----- PRESSÃO -----");
                                        }
                                        break;
                                    case 12:
                                        {
                                            Console.WriteLine("----- ÂNGULO -----");
                                        }
                                        break;
                                    case 13:
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
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Opção não existente!");
                        break;
                }
            } while (Global.Opcao != 0);
        }
    }
}
