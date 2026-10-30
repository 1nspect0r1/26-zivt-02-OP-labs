using System;

namespace Example22
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 3;
            Console.Write("Введите значение X (от -10 до 8): ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double y;

            if (x < -10 || x > 8)
            {
                Console.WriteLine("Значение X выходит за границы графика!");
            }
            else
            {
                if (x <= -8) y = -R;
                else if (x <= -3) y = 0.6 * x + 1.8;
                else if (x <= 3) y = -Math.Sqrt(R * R - x * x);
                else if (x <= 5) y = x - 3;
                else y = 3;

                Console.WriteLine("Значение Y = " + y);
            }

            Console.ReadKey();
        }
    }
}
