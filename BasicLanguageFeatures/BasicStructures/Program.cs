using System;
using System.Runtime.InteropServices;

namespace BasicStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first side");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side");
            var c = Convert.ToDouble(Console.ReadLine());

            var perimeter = a + b + c;
            var s = perimeter / 2;

            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"The area is {area} and perimeter is {perimeter}");
        }
    }
}
