using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassL;
using Utils;

namespace _10._1._1__Console_
{
    /* Консольное приложение к 10 заданию
     * Файл ввода и вывода лежат в "папка с решением"/10.1.1 (Console)/bin/Debug
     */
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                
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
                Console.WriteLine("Аргументы командной строки не заданы");
                Console.ReadKey();
            }
        }
    }
}
