using System;

namespace фигура_псевдографикой
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigth = int.Parse(Console.ReadLine());
            //int width = int.Parse(Console.ReadLine());
            Console.WriteLine("hello");
            for (int x = 0; x < heigth; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            for (int x = 0; x < heigth; x++)
            {
                for (int y = heigth; y > x; y--)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }

    }
}
