using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            Console.WriteLine("Opção escolhida -- > 3 - Conversor");
                            Console.WriteLine("O que deseja converter?");
                            Console.WriteLine("1 - Moeda");
                            Console.WriteLine("2 - Peso");
                            Global.Opcao = int.Parse(Console.ReadLine());

                            if (Global.Opcao == 1)
                            {
                                do
                                {
                                    Console.WriteLine("Para qual moeda deseja converter?");
                                    Console.WriteLine("1 - Real para Dolar(EUA)");
                                    Console.WriteLine("2 - Real para Euro(Europa)");
                                    Console.WriteLine("3 - Real para Peso(Argentina)");
                                    Console.WriteLine("4 - Real para Yuan(China)");
                                    Console.WriteLine("5 - Dolar(EUA) para Real");
                                    Console.WriteLine("6 - Euro(Europa) para Real");
                                    Console.WriteLine("7 - Peso(Argentina) para Real");
                                    Console.WriteLine("8 - Yuan(China) para Real");
                                    Console.WriteLine("9 - Sair");
                                    Global.Tipo = int.Parse(Console.ReadLine());
                                    switch (Global.Tipo)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Conversão escolhida: 1 - Real para Dolar(EUA)");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.BRDolar();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total,2) + "!");
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
                                                Console.WriteLine("Conversão escolhida: 5 - Dolar(EUA) para Real");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.DolarBR();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total, 2) + "!");
                                            }
                                            break;
                                        case 6:
                                            {
                                                Console.WriteLine("Conversão escolhida: 6 - Euro(Europa) para Real");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.EuroBR();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é:" + Math.Round(Global.total,2) + "!");
                                            }
                                            break;
                                        case 7:
                                            {
                                                Console.WriteLine("Conversão escolhida: 7 - Peso(Argentina) para Real");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.PesoBR();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é: {Global.total}");
                                            }
                                            break;
                                        case 8:
                                            {
                                                Console.WriteLine("Conversão escolhida: 8 - Yuan(China) para Real");
                                                Console.WriteLine("Digite o número:");
                                                Global.valor1 = decimal.Parse(Console.ReadLine());

                                                Conversão.YuanBR();

                                                Global.total = Global.moeda;
                                                Console.WriteLine($"Seu valor é: {Global.total}");
                                            }
                                            break;
                                        case 9:
                                            return;
                                        default:
                                            Console.WriteLine("Tipo de conversão não existente!");
                                            break;
                                    }
                                } while (Global.Tipo != 9);
                            }
                            else if (Global.Opcao == 2)
                            {

                            }
                            else if (Global.Opcao == 3)
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Opção não existente!");
                            }
                        } while (Global.Opcao != 3);
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
