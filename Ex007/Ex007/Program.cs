using System;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Write a C# Sharp program to print on screen the output of adding, 
             * subtracting, multiplying and dividing of two numbers 
             * which will be entered by the user.
            */

            int Value1;
            int Value2;

            Console.Write("Input First Number: ");
            Value1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input Second Number: ");
            Value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{Value1} + {Value2} = {Value1 + Value2}");
            Console.WriteLine($"{Value1} - {Value2} = {Value1 - Value2}");
            Console.WriteLine($"{Value1} x {Value2} = {Value1 * Value2}");
            Console.WriteLine($"{Value1} / {Value2} = {Value1 / Value2}");
            
            Console.ReadLine();


        }
    }
}
