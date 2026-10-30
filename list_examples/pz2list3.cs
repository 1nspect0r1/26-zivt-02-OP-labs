using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решите уравнение:\n Y=2+2*2-3");
            Console.WriteLine("Выберите правильный ответ:\n");
            Console.WriteLine("Ответ №1: 3 Ответ №2: 5\n");
            Console.WriteLine("Ответ №3: 0 Ответ №4: 1\n");
            
            char x = (char) Console.Read();
            Console.ReadLine(); // очистка буфера от символа нажатия Enter
            
            switch (x)
            {
                case '1': Console.WriteLine("Ответ: 3\n"); break;
                case '2': Console.WriteLine("Ответ: 5\n"); break;
                case '3': Console.WriteLine("Ответ: 0\n"); break;
                case '4': Console.WriteLine("Ответ: 1\n"); break;
            }
            
            if (x == '1') Console.WriteLine(" Ответ верный");
            else Console.WriteLine(" Ответ неверный");
            
            Console.ReadKey();
        }
    }
}