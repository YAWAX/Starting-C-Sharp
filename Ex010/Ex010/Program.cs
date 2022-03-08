using System;
namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Write a C# Sharp program to that takes three numbers(x,y,z) 
             *   as input and print the output of (x+y).z and x.y + y.z.    */

            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            int Z = Convert.ToInt32(Console.ReadLine());

            //(x+y).z

            Console.Write($"Result of specified numbers: {X}, {Y}, {Z} Is: ");
            Console.WriteLine($"{(X+Y)*Z}");

            //x.y + y.z
            Console.Write($"Result of specified numbers: {X}, {Y}, {Z} Is: ");
            Console.WriteLine($"{X*Y + Y*Z}");

            Console.ReadLine();

        }
    }
}
