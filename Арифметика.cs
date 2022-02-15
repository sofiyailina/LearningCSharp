using System;

namespace Арифметика
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] p = input.Split(" ");
            int a = Convert.ToInt32(p[0]);
            int b = Convert.ToInt32(p[1]);
            int c = Convert.ToInt32(p[2]);
            if (a * b = c) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
