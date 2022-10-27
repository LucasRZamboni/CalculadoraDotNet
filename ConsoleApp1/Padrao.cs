using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Padrao
    {
        public static void CalcSimples()
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
            Console.WriteLine("9 - Sair");
            Console.WriteLine("-------------------------------");
            Global.Opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 1 - Somar");
                        Console.WriteLine("Digite o primeiro número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        Global.valor2 = decimal.Parse(Console.ReadLine());

                        Global.total = Global.valor1 + Global.valor2;
                        Console.WriteLine($"Seu valor é: {Global.total}");
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
                        Console.WriteLine("Digite o primeiro número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        Global.valor2 = decimal.Parse(Console.ReadLine());

                        Global.total = Global.valor1 * Global.valor2;
                        Console.WriteLine($"Seu valor é: {Global.total}");
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
                        Console.WriteLine("Digite o primeiro número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        Global.valor2 = (decimal)double.Parse(Console.ReadLine());

                        Global.total = Global.valor1 / Global.valor2;
                        Console.WriteLine($"Seu valor é: {Global.total}");
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
                        Console.WriteLine("Digite o primeiro número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número");
                        Global.valor2 = decimal.Parse(Console.ReadLine());

                        Global.total = Global.valor1 - Global.valor2;
                        Console.WriteLine($"Seu valor é: {Global.total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 5 - Fração");
                        Console.WriteLine("Digite um número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = 1/Global.valor1;
                        Console.WriteLine($"Seu valor é: {Global.total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 6 - Raiz Quadrada");
                        Console.WriteLine("Digite um número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Sqrt((double)Global.valor1);
                        Console.WriteLine($"Seu valor é: {Global.total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 7:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 7 - Número Elevado ao Quadrado");
                        Console.WriteLine("Digite um número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Pow((double)Global.valor1, 2);
                        Console.WriteLine($"Seu valor é: {Global.total}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro", ex);
                    }
                    break;
                case 8:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 8 - Porcentagem");
                        Console.WriteLine("Digite o primeiro número");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Número virar porcento");
                        Global.valor2 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Qual tipo de conta deseja fazer?");
                        Console.WriteLine("1 - Somar");
                        Console.WriteLine("2 - Multiplicar");
                        Console.WriteLine("3 - Dividir");
                        Console.WriteLine("4 - Subtrair");
                        Global.Tipo = int.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------");

                        if (Global.Tipo == 1)
                        {
                            Global.total = Global.valor1 + (Global.valor1*(Global.valor2 / 100));
                        }
                        else if (Global.Tipo == 2)
                        {
                            Global.total = Global.valor1 * (Global.valor2/100);
                        }
                        else if (Global.Tipo == 3)
                        {
                            Global.total = Global.valor1 / (Global.valor2 / 100);
                        }
                        else if(Global.Tipo == 4)
                        {
                            Global.total = Global.valor1 - (Global.valor1*(Global.valor2 / 100));
                        }
                        else
                        {
                            Console.WriteLine("Tipo de cálculo não existente!");
                        }

                        
                        Console.WriteLine($"Seu valor é: {Global.total}");
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
        }
    }
}
