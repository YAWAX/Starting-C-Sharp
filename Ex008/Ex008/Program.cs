using System;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a number 
            //as input and print its multiplication table

            int Value;
            Console.Write("Number: ");
            Value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======");

            int s = 0;

            while (true)
            {
                Console.WriteLine($"{Value} x {s} = {Value * s}");
                s += 1;
                if (s == 11) { break; } 
            }
            
            Console.Write("======\nSUCESS");
            Console.ReadLine();
        }
    }
}
