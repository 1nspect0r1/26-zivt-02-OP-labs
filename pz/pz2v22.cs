using System;

namespace TargetArea_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R: ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Проверка попадания в сектор круга (II четверть)
            if (x <= 0 && y >= 0 && (x * x + y * y <= R * R))
            {
                Console.WriteLine("Точка попадает в заштрихованную область.");
            }
            // Проверка попадания в треугольник (IV четверть)
            else if (y <= 0 && y >= -2 * x && y >= 2 * x - 2 * R)
            {
                Console.WriteLine("Точка попадает в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка НЕ попадает в заштрихованную область.");
            }

            Console.ReadKey();
        }
    }
}