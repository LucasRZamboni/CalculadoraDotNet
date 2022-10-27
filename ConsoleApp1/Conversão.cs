using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Conversão
    {
        public static void BRDolar()
        {
            Global.moeda = Global.valor1 / Global.dolar;
        }
        public static void BREuro()
        {
            Global.moeda = Global.valor1 / Global.euro;
        }
        public static void BRYuan()
        {
            Global.moeda = Global.valor1 / Global.yuan;
        }
        public static void BRPeso()
        {
            Global.moeda = Global.valor1 / Global.peso;
        }
        public static void DolarBR()
        {
            Global.moeda = Global.valor1 * Global.dolar;
        }
        public static void EuroBR()
        {
            Global.moeda = Global.valor1 * Global.euro;
        }
        public static void YuanBR()
        {
            Global.moeda = Global.valor1 * Global.yuan;
        }
        public static void PesoBR()
        {
            Global.moeda = Global.valor1 * Global.peso;
        }
    }
}
