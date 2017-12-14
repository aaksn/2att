using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClassL;
using Utils;


namespace _9._1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                AllocConsole();
                /*foreach (var item in args)
                {
                    System.Console.WriteLine(item);
                }               
                Console.WriteLine("Для выхода наберите exit.");
                Console.ReadKey();*/
                Nine.ParseArgs(args, out string inputFile, out string outputFile);
                UtilsW.ReadInputFromFile(inputFile, ' ', out int[,] res);
                try
                {                    
                    Nine logic = new Nine(res);
                    logic.Process(out int[,] res1);
                    UtilsW.WriteInputIntoFile(outputFile, res1);
                }
                catch (Exception except)
                {
                    Console.WriteLine(except);
                    Console.ReadKey();
                }
                FreeConsole();                
            }
            else 
            {
                FreeConsole();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();
    }
}
