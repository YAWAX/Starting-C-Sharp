using System;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Value1;
            Console.Write("Number 1: ");
            Value1 = Int32.Parse(Console.ReadLine());

            int Value2;
            Console.Write("Number 2: ");
            Value2 = Int32.Parse(Console.ReadLine());

            int Value3;
            Console.Write("Number 3: ");
            Value3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{Value1} X {Value2} X {Value3} = {Value1 * Value2 * Value3}");
            Console.ReadLine();
        

        }
    }
}
