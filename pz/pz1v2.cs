using System;

namespace LinearProgramLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ввод исходных данных
            Console.Write("Введите значение угла альфа (в радианах): ");
            double a = Convert.ToDouble(Console.ReadLine());

            // 2. Вычисление по формулам
            double z1 = Math.Cos(2 * a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            double z2 = 3 * Math.Sqrt(2) * Math.Sin(a) * Math.Cos(2 * a);

            // 3. Вывод результатов (с округлением до 4 знаков после запятой для аккуратности)
            Console.WriteLine($"Результат z1 = {z1:F4}");
            Console.WriteLine($"Результат z2 = {z2:F4}");

            // Ожидание нажатия клавиши, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
    }
}
