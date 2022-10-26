﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Intermediaria
    {
        public static void CalcIntermediaria()
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
            Console.WriteLine("7 - Absoluto");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("-------------------------------");
            Global.Opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Opcao)
            {
                case 1:
                    try
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
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        Global.valor2 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Pow((double)Global.valor1, (double)Global.valor2);
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
                        Console.WriteLine("Opção escolhida -- > 3 - Raiz Quadrada");
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Sqrt((double)Global.valor1);
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
                        Console.WriteLine("Opção escolhida -- > 4 - Número Elevado ao Quadrado");
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Pow((double)Global.valor1, 2);
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
                        Console.WriteLine("Opção escolhida -- > 5 - Pi");
                        Global.total = (decimal)Math.PI;
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
                        Console.WriteLine("Opção escolhida -- > 6 - Log");
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = (decimal)Math.Log((double)Global.valor1, 10);
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
                        Console.WriteLine("Opção escolhida -- > 7 - Absoluto");
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());

                        Global.total = Math.Abs(Global.valor1);
                        Console.WriteLine($"Seu valor é: {Global.total}");
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