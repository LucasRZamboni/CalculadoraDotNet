using System.Globalization;

namespace Calculadora
{
    internal class Avancado
    {
        public static void CalcAvancada()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ------ CALCULADORA AVANÇADA ------");
                Console.WriteLine("Escolha a opção desejada abaixo: ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1 - Programador");
                Console.WriteLine("2 - Cálculo de Data");
                Console.WriteLine("3 - Conversor");
                Console.WriteLine("0 - SAIR");
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
                                Console.WriteLine("Opção escolhida -- > 1 - Programador");


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
                                Console.WriteLine("Opção escolhida -- > 2 - Cálculo de Data");


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
                                //Console.WriteLine("0 - SAIR");
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
                                                // CONVERTER MOEDA
                                                //Process.Start("python", @"C:\Users\Usuario\Desktop\Pasta\ConsoleApp1\ConsoleApp1\moedas.py");
                                                //até aqui  está ok, mas ele nao executa corretamente o arquivo .py
                                                Console.Clear();
                                                Console.WriteLine("----- MOEDA -----");
                                                Console.WriteLine("1 - Real");
                                                Console.WriteLine("2 - Dolar(EUA)");
                                                Console.WriteLine("3 - Euro(Europa)");
                                                Console.WriteLine("4 - Peso(Argentina)");
                                                Console.WriteLine("5 - Yuan(China)");
                                                Console.WriteLine("0 - SAIR");
                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                Console.Clear();
                                                switch (Global.Tipo)
                                                {
                                                    case 1:

                                                        try
                                                        {
                                                            do
                                                            { //CONVERTER REAL
                                                                Console.Clear();
                                                                Console.WriteLine("----- REAL -----");
                                                                Console.WriteLine("Real para qual moeda?");
                                                                Console.WriteLine("1 - Para Dolar(EUA)");
                                                                Console.WriteLine("2 - Para Euro(Europa)");
                                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("5 - SAIR");
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
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
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
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                                                Console.WriteLine("Opção escolhida -- > 3 - Para Peso(Argentina)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRPeso();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                                                Console.WriteLine("Opção escolhida -- > 4 - Para Yuan(China)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRYuan();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                            { //CONVERTER DOLAR
                                                                Console.Clear();
                                                                Console.WriteLine("----- DOLAR -----");
                                                                Console.WriteLine("Real para qual moeda?");
                                                                Console.WriteLine("1 - Para Real(Brasil)");
                                                                Console.WriteLine("2 - Para Euro(Europa)");
                                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("0 - SAIR");
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
                                                                                Console.WriteLine("Opção escolhida -- > 1 - Para Real(BRL)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.DolarBR();

                                                                                Global.total = Global.moeda;
                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
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
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                                                Console.WriteLine("Opção escolhida -- > 3 - Para Peso(Argentina)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRPeso();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
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
                                                                                Console.WriteLine("Opção escolhida -- > 4 - Para Yuan(China)");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Digite o número:");
                                                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                Conversão.BRYuan();

                                                                                Console.WriteLine("Seu valor é: " + Global.total.ToString("C", CultureInfo.CurrentCulture) + " !");
                                                                                Console.WriteLine("-------------------------------");
                                                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                Global.sair = char.Parse(Console.ReadLine());
                                                                            } while (Global.sair != 's');
                                                                        }
                                                                        catch (Exception ex)
                                                                        {
                                                                            Console.WriteLine("Erro", ex);
                                                                        }
                                                                        break;
                                                                    case 0:
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
                                                        try
                                                        {
                                                            do
                                                            {
                                                                //CONVERTER EURO
                                                                Console.Clear();
                                                                Console.WriteLine("----- EURO -----");
                                                                Console.WriteLine("Euro para qual moeda?");
                                                                Console.WriteLine("1 - Para Real(Brasil)");
                                                                Console.WriteLine("2 - Para Dolar(EUA)");
                                                                Console.WriteLine("3 - Para Peso(Argentina)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("0 - SAIR");
                                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                                Console.Clear();

                                                            } while (Global.Tipo != 0);
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
                                                                //CONVERTER PESO
                                                                Console.Clear();
                                                                Console.WriteLine("----- PESO -----");
                                                                Console.WriteLine("Peso para qual moeda?");
                                                                Console.WriteLine("1 - Para Real(Brasil)");
                                                                Console.WriteLine("2 - Para Dolar(EUA)");
                                                                Console.WriteLine("3 - Para Euro(Europa)");
                                                                Console.WriteLine("4 - Para Yuan(China)");
                                                                Console.WriteLine("0 - SAIR");
                                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                                Console.Clear();

                                                            } while (Global.Tipo != 0);
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
                                                                //CONVERTER YUAN
                                                                Console.Clear();
                                                                Console.WriteLine("----- YUAN -----");
                                                                Console.WriteLine("Yuan para qual moeda?");
                                                                Console.WriteLine("1 - Para Real(Brasil)");
                                                                Console.WriteLine("2 - Para Dolar(EUA)");
                                                                Console.WriteLine("3 - Para Euro(Europa)");
                                                                Console.WriteLine("4 - Para Peso(Argentina");
                                                                Console.WriteLine("0 - SAIR");
                                                                Global.Tipo = int.Parse(Console.ReadLine());
                                                                Console.Clear();

                                                            } while (Global.Tipo != 0);

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
                                    case 2:
                                        try
                                        {
                                            do
                                            {
                                                Console.WriteLine("----- VOLUME -----");

                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }

                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }

                                        break;
                                    case 3:
                                        {
                                            do
                                            {
                                                Console.WriteLine("----- COMPRIMENTO -----");

                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        break;
                                    case 4:
                                        {
                                            do
                                            {
                                                Console.WriteLine("----- PESO E MASSA -----");

                                                Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');


                                        }
                                        break;
                                    case 5:
                                        {
                                            try
                                            {
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("----- TEMPERATURA -----");
                                                    Console.WriteLine("-------------------------------");
                                                    Console.WriteLine("1 - Celcius");
                                                    Console.WriteLine("2 - Fahrenheit");
                                                    Console.WriteLine("3 - Kelvin");
                                                    Console.WriteLine("0 - SAIR");
                                                    Console.WriteLine("-------------------------------");
                                                    Global.Tipo = int.Parse(Console.ReadLine());

                                                    switch (Global.Tipo)
                                                    {

                                                        case 1:
                                                            try
                                                            {
                                                                do
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Conversão escolhida: 1 - Celcius");
                                                                    Console.WriteLine("-------------------------------");
                                                                    Console.WriteLine("1 - Para Fhrenheit");
                                                                    Console.WriteLine("2 - Para Kelvin");
                                                                    Console.WriteLine("0 - SAIR");
                                                                    Global.Opcao = int.Parse(Console.ReadLine());
                                                                    Console.WriteLine("-------------------------------");
                                                                    switch (Global.Opcao)
                                                                    {

                                                                        case 1:
                                                                            try
                                                                            {
                                                                                do
                                                                                {
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("Conversão escolhida: 1 - Para Fhrenheit");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.CelciusF();
                                                                                    Global.total = Global.fahren;
                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°F");

                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
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
                                                                                    Console.WriteLine("Conversão escolhida: 2 - Para Kelvin");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.CelciusK();
                                                                                    Global.total = Global.kelvin;

                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°K");

                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                    Global.sair = char.Parse(Console.ReadLine());
                                                                                } while (Global.sair != 'n');

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

                                                                } while (Global.Opcao != 0);
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
                                                                    Console.WriteLine("Conversão escolhida: 2 - Fahrenheit");
                                                                    Console.WriteLine("1 - Para Celcius");
                                                                    Console.WriteLine("2 - Para Kelvin");
                                                                    Console.WriteLine("0 - SAIR");
                                                                    Global.Tipo = int.Parse(Console.ReadLine());
                                                                    Console.WriteLine("-------------------------------");

                                                                    switch (Global.Tipo)
                                                                    {
                                                                        case 1:
                                                                            try
                                                                            {
                                                                                do
                                                                                {
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("Conversão escolhida: 1 - Para Celcius");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.FahrenheitC();

                                                                                    Global.total = Global.celcius;

                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°C");
                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
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
                                                                                    Console.WriteLine("Conversão escolhida: 2 - Para Kelvin");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.FahrenheitK();

                                                                                    Global.total = Global.kelvin;

                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°K");
                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                    Global.sair = char.Parse(Console.ReadLine());
                                                                                } while (Global.sair != 'n');

                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                Console.WriteLine("Erro", ex);
                                                                            }
                                                                            break;
                                                                        case 0:
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
                                                            try
                                                            {
                                                                do
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Conversão escolhida: 3 - Kelvin");
                                                                    Console.WriteLine("-------------------------------");
                                                                    Console.WriteLine("1 - Para Celcius");
                                                                    Console.WriteLine("2 - Para Fhrenheit");
                                                                    Console.WriteLine("0 - SAIR");

                                                                    Global.Tipo = int.Parse(Console.ReadLine());
                                                                    Console.WriteLine("-------------------------------");

                                                                    switch (Global.Tipo)
                                                                    {
                                                                        case 1:
                                                                            try
                                                                            {
                                                                                do
                                                                                {
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("Conversão escolhida: 1 - Para Celcius");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.KelvinC();

                                                                                    Global.total = Global.celcius;

                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°C");
                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
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
                                                                                    Console.WriteLine("Conversão escolhida: 2 - Para Fahrenheit");
                                                                                    Console.WriteLine("-------------------------------");
                                                                                    Console.WriteLine("Digite o número:");
                                                                                    Global.valor1 = decimal.Parse(Console.ReadLine());

                                                                                    Conversão.KelvinF();

                                                                                    Global.total = Global.fahren;

                                                                                    Console.WriteLine("Seu valor é: " + Math.Round(Global.total, 2) + "°F");
                                                                                    Console.WriteLine("-------------------------------");

                                                                                    Console.WriteLine("Deseja converter outro valor? Digite s (SIM)  /  Digite n (NÃO)");
                                                                                    Global.sair = char.Parse(Console.ReadLine());
                                                                                } while (Global.sair != 'n');

                                                                            }

                                                                            catch (Exception ex)
                                                                            {
                                                                                Console.WriteLine("Erro", ex);
                                                                            }
                                                                            break;
                                                                        case 0:
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
                                                        case 0:
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
                                        }
                                        break;
                                    case 6:
                                        try
                                        {
                                            do
                                            {
                                                {
                                                    Console.WriteLine("----- ENERGIA -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');


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
                                                {
                                                    Console.WriteLine("----- ÁREA -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
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
                                                {
                                                    Console.WriteLine("----- VELOCIDADE -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 9:
                                        try
                                        {
                                            do
                                            {
                                                {
                                                    Console.WriteLine("----- POTÊNCIA -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 10:
                                        try
                                        {
                                            do
                                            {
                                                {
                                                    Console.WriteLine("----- DADOS -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 11:
                                        try
                                        {
                                            do
                                            {
                                                {
                                                    Console.WriteLine("----- PRESSÃO -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 12:
                                        try
                                        {
                                            do
                                            {
                                                {
                                                    Console.WriteLine("----- ÂNGULO -----");
                                                }
                                                Console.WriteLine("Deseja mesmo SAIR? Digite s (SIM)  /  Digite n (NÃO)");
                                                Global.sair = char.Parse(Console.ReadLine());
                                            } while (Global.sair != 's');
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Erro", ex);
                                        }
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        Console.WriteLine("Opção não existente!");
                                        break;

                                }
                                Console.WriteLine("Deseja SAIR do Conversor? Digite s (SIM)  /  Digite n (NÃO)");
                                Global.sair = char.Parse(Console.ReadLine());
                            } while (Global.sair != 's');
                        }
                        catch (Exception ex)

                        {
                            Console.WriteLine("Erro", ex);
                        }
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Opção não existente!");
                        break;
                }
            }
        }
    }
}
