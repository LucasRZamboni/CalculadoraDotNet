using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Simples
    {
        public static void CalcSimples()
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
            Global.Opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Opção escolhida -- > 1 - Somar");
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
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
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
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
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
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
                        Console.WriteLine("Digite o primeiro numero");
                        Global.valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
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
                    return;
                default:
                    Console.WriteLine("Opção não existente!");
                    break;
            }
        }
    }
}
