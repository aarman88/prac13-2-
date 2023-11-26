using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Создаем коллекцию List<double>
        List<double> numbers = new List<double> { 2.5, 1.8, 3.6, 4.2, 2.9, 5.1, 3.4 };

        // Выводим элементы, значение которых больше среднего арифметического
        DisplayNumbersAboveAverage(numbers);
    }

    static void DisplayNumbersAboveAverage(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("Коллекция пуста.");
            return;
        }

        // Вычисляем среднее арифметическое
        double average = numbers.Sum() / numbers.Count;

        Console.WriteLine($"Среднее арифметическое: {average:F2}");

        // Выводим элементы, которые больше среднего арифметического
        Console.WriteLine("Элементы, которые больше среднего арифметического:");
        foreach (var number in numbers)
        {
            if (number > average)
            {
                Console.WriteLine(number);
            }
        }
    }
}
