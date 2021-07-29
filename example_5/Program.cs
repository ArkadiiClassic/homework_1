using System;

namespace example_5
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
 
        static void Main()
        {
            // Домашняя работа №1 пример_4
            // Архиреев Аркадий 
            /* 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                б) *Сделать задание, только вывод организовать в центре экрана.
                в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).*/

            // a)
            Print("Аркадий Архиреев, Казань!\n", 25, 15);
            Print("Привет еще раз!", ConsoleColor.Green);
            Console.ReadLine();
        }
    }
}
