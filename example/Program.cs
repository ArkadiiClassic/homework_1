using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №1 пример_1
            // Архиреев Аркадий 
            /* 1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
            В результате вся информация выводится в одну строчку:
                а) используя склеивание;
                б) используя форматированный вывод;
                в) используя вывод со знаком $.*/
            
            Console.Write("Введите своё имя: ");
            var name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите свою фамилию: ");
            var surname = Convert.ToString(Console.ReadLine());
            Console.Write("Введите свой возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите свой рост: ");
            var growth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой вес: ");
            var weight = Convert.ToDouble(Console.ReadLine());

            //использование склеивания
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname + ", возраст: "
                + age + ", рост: " + growth + " и вес:" + weight + ";");

            //использование форматированного вывода
            Console.WriteLine("{0}, {1}, {2:D}, {3:F2}, {4:F2}", name, surname, age, growth, weight);

            //использование вывода со знаком $.
            Console.WriteLine($"{name}, {surname}, {age:D}, {growth:F2}, {weight:F2}");
        }
    }
}
