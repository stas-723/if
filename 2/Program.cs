using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X < 0 && Y > 0)
            {
                Console.WriteLine($"{X}, {Y} находится в 1 четверти");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine($"{X}, {Y} находится во 2 четверти");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"{X}, {Y} находится в 3 четверти");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine($"{X}, {Y} находится в 4 четверти");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine($"{X}, {Y} находится в позиции ноль");
            }
        }
    }
}