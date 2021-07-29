using System;

namespace example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №1 пример_4
            // Архиреев Аркадий 
            /* 4. Написать программу обмена значениями двух переменных:
                а) с использованием третьей переменной;
	            б) *без использования третьей переменной.*/
            Console.Write("Введите a: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            var b = Convert.ToInt32(Console.ReadLine());

            // а
            int c = a;
            a = b;
            b = c;

            // б
            /*a = a + b;
            b = b - a;
            b = -b;
            a = a - b;*/

            Console.Write($"Число a: {a}, число b: {b};");
        }
    }
}
