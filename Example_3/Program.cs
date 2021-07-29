using System;
using System.Linq;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №1 пример_3
            // Архиреев Аркадий 
            /* 3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
                по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
                используя спецификатор формата .2f (с двумя знаками после запятой);
                  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

            // a)
            Console.Write("Введите x1: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            var y2 = Convert.ToDouble(Console.ReadLine());

            var a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Результат: {a:f2};");
        }
    }
}
