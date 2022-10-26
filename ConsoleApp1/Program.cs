using Calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        
        do
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Simples");
            Console.WriteLine("2 - Intermediária");
            Console.WriteLine("3 - Avançada");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("-------------------------------");
            Global.Tipo = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Tipo)
            {
                case 1:
                    //------ CALCULADORA SIMPLES-------------------------------
                    do
                    {
                        Simples.CalcSimples();

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Deseja continuar? Digite s (SIM)  /  Digite n (NÃO)");
                        Global.sair = Console.ReadLine().ToUpper();

                    } while (Global.sair != "N");
                    //------ CALCULADORA SIMPLES-------------------------------
                    break;
                case 2:
                    //------ CALCULADORA INTERMEDIÁRIA-------------------------------
                    do
                    {
                        Intermediaria.CalcIntermediaria();

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Deseja continuar? Digite s (SIM)  /  Digite n (NÃO)");
                        Global.sair = Console.ReadLine().ToUpper();

                    } while (Global.sair != "N");
                    break;
                //------ CALCULADORA INTERMEDIÁRIA-------------------------------
                
                case 3:
                    //------ CALCULADORA ACANÇADA-------------------------------
                    do
                    {
                        Avancado.CalcAvancada();

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Deseja continuar? Digite s (SIM)  /  Digite n (NÃO)");
                        Global.sair = Console.ReadLine().ToUpper();

                    } while (Global.sair != "N");
                    break;
                //------ CALCULADORA ACANÇADA-------------------------------
                case 4:
                    return;
                default:
                    Console.WriteLine("Tipo de calculadora não existente!");
                    break;
            }
        } while (Global.Tipo != 4);
    }
}