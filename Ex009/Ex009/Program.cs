using System;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes four 
            //numbers as input to calculate and print the average.

            int N1 = Convert.ToInt32(Console.ReadLine());
            int N2 = Convert.ToInt32(Console.ReadLine());
            int N3 = Convert.ToInt32(Console.ReadLine());
            int N4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(N1 + N2 + N3 + N4) / 4}");
            Console.ReadLine();
        }
    }
}
