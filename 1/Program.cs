using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введи число a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи число:");
            int b = Convert.ToInt32(Console.ReadLine());

            int x;

            if (a > b) ;
            {

                x = a + b;

            }

            if (a == b) ;
            {

                x = a * b;
            }

            if (a < b) ;
            {
                x = a - b;

            }

            Console.WriteLine($"результат = {x}");




        }




    }



}
