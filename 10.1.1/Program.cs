﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClassL;
using Utils;


namespace _10._1
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
                ConsoleAppUtils.ParseArgs(args, out string inputFile, out string outputFile);
                UtilsW.ReadInputFromFile(inputFile, ' ', out int[,] res);                
                try
                {
                    Ten logic = new Ten(res);
                    logic.Process(out int[,] res1, out int rm);
                    UtilsW.WriteInputIntoFile(outputFile, res1);
                    Console.WriteLine("Количество параллельных прямых: {0}", rm.ToString());
                }
                catch (Exception except)
                {
                    Console.WriteLine(except);
                }
                Console.ReadKey();
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
