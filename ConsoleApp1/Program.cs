using Calculadora;
using System.Runtime.InteropServices;

internal class Program
{

    const int SWP_NOSIZE = 0x0001;

    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();

    private static IntPtr MyConsole = GetConsoleWindow();

    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
    private static void Main(string[] args)
    {

        int xpos = 350;
        int ypos = 200;
        SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);
        Console.SetWindowSize(width: 70, height: 30);
        // Console.SetWindowPosition(30, 30);
        do
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Padrão");
            Console.WriteLine("2 - Científica");
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
                        Padrao.CalcSimples();

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
                        Cientifica.CalcIntermediaria();

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