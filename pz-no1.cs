using System;

class Program
{
    static void Main()
    {
        // Ввод двух чисел с клавиатуры
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // 1. Среднее арифметическое кубов двух чисел
        // Можно использовать Math.Pow(a, 3) или прямое умножение (a * a * a)
        double averageOfCubes = (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2;

        // 2. Среднее арифметическое самих чисел
        double averageOfNumbers = (a + b) / 2;

        // Вывод результатов
        Console.WriteLine($"\nСреднее арифметическое кубов: {averageOfCubes}");
        Console.WriteLine($"Среднее арифметическое чисел: {averageOfNumbers}");
    }
}