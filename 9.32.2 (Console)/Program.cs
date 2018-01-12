using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassL;
using Utils;

namespace _9._32._2__Console_
{
    /* Консольное приложение к заданию 9.32.2
     * Файл ввода и вывода лежат в "папка с решением"/9.32.2 (Console)/bin/Debug
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
                    Nine logic = new Nine(res);
                    logic.Process2(out int[,] res1, out int rm);
                    UtilsW.WriteInputIntoFile(outputFile, res1);
                    Console.WriteLine("Минимальная сумма по столбцам: {0}", rm.ToString());
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
