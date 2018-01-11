using Class_UtilsForGrid;
using System;
using Class_UtilsForFile;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _10._1._3.Сonsole
{
    class Program
    {
        static bool ConfirmAction(string question)
        {
            Console.Write(question + " (y/n): ");

            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);

            Console.WriteLine();

            return keyInfo.Key == ConsoleKey.Y;
        }

        static int[,] ReadArrFromFile()
        {
            while (true)
            {
                try
                {
                    string filePath = ClassForFileConsole_9.ReadValueFromConsole<string>("входной файл");

                    string arrText = ClassForFile_9.Read(filePath);
                    return DataConverter.StrToArray2D<int>(arrText);
                }
                catch (Exception)
                {
                    ClassForFileConsole_9.ShowError("Ошибка в считывании");
                }
            }
        }

        static int[,] ReadArrFromConsole()
        {
            return ClassForFileConsole_9.ReadArray2DFromConsole<int>("Введите параметры");
        }

        public static void SaveResultToFile(string answer)
        {
            while (true)
            {
                try
                {
                    string filePath = ClassForFileConsole_9.ReadValueFromConsole<string>("выходной файл");

                    ClassForFile_9.Write(filePath, answer);
                    return;
                }
                catch (Exception)
                {
                    ClassForFileConsole_9.ShowError("Ошибка в записи");
                }
            }
        }

        static int Main(string[] args)
        {
            while (true)
            {
                int[,] arr;

                if (ConfirmAction("Считываем данные из файла?"))
                {
                    arr = ReadArrFromFile();
                }
                else
                {
                    arr = ReadArrFromConsole();
                }

                ReturnMaxLine matUtils = new ReturnMaxLine();

                string input = DataConverter.Array2DToStr(arr);

                Console.WriteLine(input);
                Console.WriteLine();

                string result = DataConverter.Array2DToStr(matUtils.DelitedStrAndCol());

                Console.WriteLine(result);

                if (ConfirmAction("Сохраните результат?"))
                {
                    SaveResultToFile(result);
                }

                if (ConfirmAction("Хотите продолжить работу?"))
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            return 0;
        }
    }
}
