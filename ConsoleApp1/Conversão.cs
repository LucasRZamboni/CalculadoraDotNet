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


        /*
Celsius Fahrenheit °F = °C × 1,8 + 32
Fahrenheit Celsius °C = (°F − 32) / 1,8
Celsius Kelvin K = °C + 273,15
Kelvin Celsius °C = K − 273,15
Fahrenheit Kelvin K = (°F + 459,67) / 1,8
Kelvin Fahrenheit °F = K × 1,8 - 459,67*/

        public static void CelciusF()
        {
             Global.fahren = (Global.valor1 * 1.8m) + 32;
        }
        public static void FahrenheitC()
        {
            Global.celcius = (Global.valor1 - 32) / 1.8m;
        }
        public static void CelciusK()
        {
            Global.kelvin = Global.valor1 + 273.15m;
        }
        public static void KelvinC()
        {
            Global.celcius = Global.valor1 - 273.15m;
        }
        public static void FahrenheitK()
        {
            Global.kelvin = (Global.valor1 + 459.67m) / 1.8m;
        }
        public static void KelvinF()
        {
            Global.fahren = (Global.valor1 * 1.8m) - 459.67m;
        }


    }
}
