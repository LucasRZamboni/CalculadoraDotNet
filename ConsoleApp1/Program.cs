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
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" ------ CALCULADORA ------");
            Console.WriteLine("Escolha a opção desejada abaixo: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Padrão");
            Console.WriteLine("2 - Científica");
            Console.WriteLine("3 - Avançada");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-------------------------------");
            Global.Tipo = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Global.Tipo)
            {
                case 1:
                    //------ CALCULADORA SIMPLES-------------------------------
                    try
                    {
                        do
                        {
                            Padrao.CalcPadrao();

                            Console.WriteLine("-------------------------------");

                            Console.WriteLine("Deseja SAIR da Calculadora Padrão? Digite s (SIM)  /  Digite n (NÃO)");
                            Global.sair = char.Parse(Console.ReadLine());
                        } while (Global.sair != 's');
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Erro", ex);
                    }
                    //------ CALCULADORA SIMPLES-------------------------------
                    break;
                case 2:
                    //------ CALCULADORA INTERMEDIÁRIA-------------------------------
                    try
                    {
                        do
                        {
                            Cientifica.CalcCientifica();

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Deseja SAIR da Calculadora Científica? Digite s (SIM)  /  Digite n (NÃO)");
                            Global.sair = char.Parse(Console.ReadLine());
                        } while (Global.sair != 's');
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Erro", ex);
                    }
                    //------ CALCULADORA INTERMEDIÁRIA-------------------------------
                    break;


                case 3:
                    //------ CALCULADORA ACANÇADA-------------------------------
                    try
                    {
                        do
                        {
                            Avancado.CalcAvancada();

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Deseja SAIR da Calculadora Avançada? Digite s (SIM)  /  Digite n (NÃO)");
                            Global.sair = char.Parse(Console.ReadLine());
                        } while (Global.sair != 's');
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("Erro", ex);
                    }
                    //------ CALCULADORA ACANÇADA-------------------------------
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