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
        }
        public static void PrintHelp()
        {
            string
                help = string.Format(@"
Назначение: Первый столбец с минимальной суммой элементов меняет местами с последним столбцом с максимальной суммой элементов.
Использование: {0} параметры
Параметры:
  -i, --input-file=ФАЙЛ     входной файл (обязательный параметр)
  -o, --output-file=ФАЙЛ    выходной файл (обязательный параметр)
  -h, --help                показать справку
                    ".Trim(),
                    ConsoleAppUtils.ExeName
                );

            Console.WriteLine(help);
        }
        public static void ParseArgs(string[] args, out string inputFile, out string outputFile)
        {
            CommandLine cmdLine = new CommandLine(args);

            if (cmdLine["help", "h"] != null || args.Length > 0 && args[0] == "/?")
            {
                PrintHelp();
                Console.ReadKey();
            }

            inputFile = cmdLine["input-file", "i"];
            outputFile = cmdLine["output-file", "o"];

            if (
                inputFile == null || inputFile == "false" ||
                outputFile == null || outputFile == "false"
            )
                ConsoleAppUtils.PrintParamsErrorAndExit();

            if (!File.Exists(inputFile))
            {
                ConsoleAppUtils.ErrorWriteLine("Файл {0} не найден!", inputFile);
            }
        }

    }
}
