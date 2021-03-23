using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введи число a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи число b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи число c:");
            int c = Convert.ToInt32(Console.ReadLine());


            if (a <= b && b <= c && a <= c)
            {


                Console.WriteLine($"{a},{b},{c}");
            }

            else if (a <= b && b >= c && a <= c)
            {

                Console.WriteLine($"{a},{c},{b}");

            }

            else if (a >= b && b <= c && c <= a)
            {

                Console.WriteLine($"{b},{c},{a}");
            }

            else if (a >= b && b <= c && c >= a)
            {

                Console.WriteLine($"{b},{a},{c}");
            }

            else if (a >= b && b >= c && c <= a)
            {

                Console.WriteLine($"{c},{b},{a}");
            }

            else if (a <= b && b >= c && c <= a)
            {

                Console.WriteLine($"{c},{a},{b}");
            }



        }




    }



}