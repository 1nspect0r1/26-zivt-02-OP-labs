using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость с которой вы ездите на своей машине:\nV = ");
            string v = Console.ReadLine();
            int V = Convert.ToInt32(v);

            if (V >= 0 && V <= 10) Console.WriteLine("Ваш трамвай только что ушел!");
            else if (V >= 11 && V <= 40) Console.WriteLine("Вы чайник, уважаемый!");
            else if (V >= 41 && V <= 90) Console.WriteLine("Неплохо! Так держать!");
            else Console.WriteLine("Ну ты лихач!!!!");
            
            Console.ReadKey();
        }
    }
}