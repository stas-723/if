using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение a");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c");
            double c = Convert.ToInt32(Console.ReadLine());

            double x = (c - b) / a;

            Console.WriteLine($"Результат: {x}");


        }
    }
}