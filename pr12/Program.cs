//*******************************************
//* Практическая работа №12                 *
//* Выполнил: Быков М.С., группа 2ИСП       *
//* Вариант: 2                              *
//*******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12
{
    internal class Program
    {
        static char CL(char c) // вспомогательный цикл
        {
            if (c >= 'a' && c <= 'z')
                return char.ToUpper(c);
            if (c >= 'A' && c <= 'Z')
                return char.ToLower(c);
            return c;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №12";
            bool repeat = true; // ввод переменной
            while (repeat)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Здравстуйте!");
                    Console.Write("Введите строку: ");
                    string i = Console.ReadLine();  
                    string res = "";
                    for (int j=0; j<i.Length; j++) //вывод измененной строки
                    {
                        res += CL(i[j]);
                    }
                    Console.WriteLine($"Результат: {res}");
                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("Нажмите Y - выход из консоли, N - повтор");
                string selectKey = Console.ReadLine();
                Console.WriteLine();
                switch (selectKey)
                {
                    case "N":// продолжаеется цикл
                        repeat = true;
                        break;
                    case "Y": // выход из цикла
                        repeat = false;
                        Environment.Exit(0);
                        break;
                    default: // при любом другом
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введена неправильная буква");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                        repeat = false;
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
