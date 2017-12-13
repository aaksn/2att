using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Utils
{
    public class ConsoleAppUtils
    {
        public static readonly string
            ExeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName),
            ExeDir = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);


        public static void WriteLineWithColor(ConsoleColor textColor, ConsoleColor backColor, bool error, string line, params object[] args) {
            ConsoleColor oldForeColor = Console.ForegroundColor;
            ConsoleColor oldBackColor = Console.BackgroundColor;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backColor;
            (error ? Console.Error : Console.Out).WriteLine(line, args);
            // вернем, как было
            Console.ForegroundColor = oldForeColor;
            Console.BackgroundColor = oldBackColor;
        }


        public static void WriteLineWithColor(ConsoleColor textColor, bool error, string line, params object[] args) {
            WriteLineWithColor(textColor, Console.BackgroundColor, error, line, args);
        }


        public static void WriteLineWithColor(ConsoleColor textColor, string line, params object[] args) {
            WriteLineWithColor(textColor, Console.BackgroundColor, false, line, args);
        }


        public static void ErrorWriteLine(string line, params object[] args) {
            WriteLineWithColor(ConsoleColor.Red, true, line, args);
        }


        public static void PrintParamsErrorAndExit() {
            ErrorWriteLine("Ошибка в парамерах (не все или некорректно указаны)!");
            ErrorWriteLine("Воспользуйтесь справкой: {0} --help", ExeName);
            // код воврата отличен от 0 - ошибочное завершение программы
            Environment.Exit(1);
        }
    }
}
