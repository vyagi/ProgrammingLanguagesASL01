using System;
using System.Collections.Generic;

namespace BasicStructures
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Reverse2Test()
        {
            int[] testArray = {4, 7, 1, 2, 9, 2};
            var result = ArrayUtils.Reverse2(testArray);

            foreach (var element in result)
                Console.WriteLine(element);

            Console.WriteLine("----------------");

            foreach (var element in testArray)
                Console.WriteLine(element);
        }

        private static void Reverse1Test()
        {
            int[] testArray = {4, 7, 1, 2, 9, 2};
            ArrayUtils.Reverse1(testArray);

            foreach (var element in testArray)
                Console.WriteLine(element);
        }

        private static void Program11b()
        {
            Console.Write("Write the quantity of numbers: ");

            var quantity = Convert.ToInt32(Console.ReadLine());

            var list = new List<int>();
            for (var i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter a number (no {i + 1})");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var sum = 0;

            foreach (var element in list)
                sum += element;

            var average = 1.0 * sum / list.Count;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Program11a()
        {
            Console.Write("Write the quantity of numbers: ");

            var quantity = Convert.ToInt32(Console.ReadLine());
            var array = new int[quantity];

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"Write the number no {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;

            foreach (var element in array)
                sum += element;

            var avg = sum / (double) quantity;
            Console.WriteLine($"Sum: {sum}\nAvg: {avg}");
        }

        private static void Program10c()
        {
            var list = new List<int>();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter a number (no {i + 1})");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var sum = 0;

            foreach (var element in list)
                sum += element;

            var average = 1.0 * sum / list.Count;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Program10b()
        {
            var array = new int[4];

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter a number (no {i + 1})");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sum = 0;

            foreach (var element in array)
                sum += element;

            var average = 1.0 * sum / array.Length;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Program10a()
        {
            Console.WriteLine("Enter the first number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fourth number");
            var d = Convert.ToInt32(Console.ReadLine());

            var sum = a + b + c + d;
            var average = sum / 4.0;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Program6()
        {
            Console.WriteLine("Input the radius of the circle : ");
            var radius = Convert.ToDouble(Console.ReadLine());

            var perimeter = 2 * Math.PI * radius;
            var area = Math.PI * radius * radius;

            Console.WriteLine($"Perimeter of Circle : {perimeter} and area is {area}");
            Console.ReadKey();
        }

        private static void Program9()
        {
            Console.Write("Please write the temperature in Celsius: ");
            var cel = Convert.ToDouble(Console.ReadLine());
            var fahr = cel * 1.8 + 32;
            var kel = cel + 273.15;

            Console.WriteLine($"Temperature in Fahrenheit: {fahr} F\nTemperature in Kelvins: {kel} K");
        }

        private static void Program8()
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
