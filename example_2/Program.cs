using System;

namespace example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашняя работа №1 пример_2
            // Архиреев Аркадий 
            /* 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
                где m — масса тела в килограммах, h — рост в метрах.*/

            Console.Write("Введите свой вес (кг): ");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост (м): ");
            var growth = Convert.ToDouble(Console.ReadLine());

            var bmi = weight / (growth * growth);
            Console.WriteLine($"Индекс массы тела: {bmi:F2};" );
        }
    }
}
