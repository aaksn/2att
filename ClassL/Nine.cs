using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassL;
using Utils;

namespace ClassL
{
    public class Nine
    {
        public int[,] Mas { get; set; }

        public Nine(int[,] mas)
        {
            Mas = mas;
        }
        public void Process(out int[,] res) 
        {
            int n = Mas.GetLength(0);
            int n1 = Mas.GetLength(1);
            int[] res1 = new int[n1];  //массив для хранения сумм столбцов
            int summ1 = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ1 += Mas[j, i];   //суммируем элементы столбцов
                }
                res1[i] = summ1; //пишем сумму в массив
                summ1 = 0; //обнуляем переменную
            }
            int min = Array.IndexOf(res1, res1.Min());// находим индекс колонки с минимальным элементом            
            // находим индекс последней колонки с максимальным элементом  
            int max = Array.IndexOf(res1, res1.Max()), nmax = res1[0];
            for (int i = 1; i < res1.Length; ++i)
                if (res1[i] >= nmax)
                {
                    max = i;
                    nmax = res1[i];
                }
            //заполнение нового массива
            int[,] result = new int[n, n1];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n1; y++)
                {
                    result[x, y] = Mas[x, y];
                    
                    if (y==min)
                    {
                        result[x, y] = Mas[x, max];                    
                    }
                    if (y == max)
                    {
                        result[x, y] = Mas[x, min];
                    }
                }                
            }

            res = result; 
        }

        //чтение многомерного массива из файла
        public static void ReadInputFromFile(string filename, char w, out int[,] res)
        {                        
            string[] lines = File.ReadAllLines(filename).ToArray();
            //заводим массив
            int count = 1;
            foreach (char c in lines[1])
                if (c == w)
                {
                    count++;                    
                }
            int[,] arr = new int[lines.Length, count];
            // разбор в массив
            for (int i = 0; i < lines.Length; i++)
            {
                int[] row = lines[i].Split(new char[] { w }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < count; j++)
                {
                    arr[i, j] = row[j];
                }
            }
            res = arr;
        }
        


        // запись входных данных в файл
        public static void WriteInputIntoFile(string filename, int[,] input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.GetLength(0); i++)
            {                
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (j==input.GetLength(1) - 1)
                    {
                        sb.Append(input[i, j].ToString());
                    }
                    else sb.Append(input[i, j].ToString()+' ');                    
                }
                if (i != input.GetLength(0) - 1)
                {
                    sb.AppendLine();
                }                                
            }
            File.WriteAllText(filename, sb.ToString());
        }
        //Работа с консолью
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
                
                // код воврата 0 - корректное завершение программы
                
                Environment.Exit(0);
                
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
                // код воврата отличен от 0 - ошибочное завершение программы
                Environment.Exit(2);
            }
        }
    }
}
