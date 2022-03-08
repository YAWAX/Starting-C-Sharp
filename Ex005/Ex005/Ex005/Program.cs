using System;
namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to swap two numbers.

            int Value1 = 5; 
            int Value2 = 10;
            
            int FirstNumber = Value1;
            Value1 = Value2;
            Value2 = FirstNumber;

            Console.WriteLine($"1 = {Value1} 2 = {Value2}");
            Console.ReadLine();


        }
    }
}
