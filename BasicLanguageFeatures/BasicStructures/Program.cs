﻿using System;
using System.Collections.Generic;

namespace BasicStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Program10c();
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
