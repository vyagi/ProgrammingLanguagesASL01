using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person { FirstName = "Marcin", LastName = "Jagieła" , Age = 19 };

            //old fashioned way of initializing
            var person2 = new Person();
            person2.FirstName = "John";
            person2.LastName = "Travolta";
            person2.Age = 60;

            var person3 = new Person("Donald", "Trump", 70);

            Console.WriteLine(person1.FullName);
            Console.WriteLine(person2.FullName);
            Console.WriteLine(person3.FullName);

            Console.WriteLine(person1.IsAdult);

            var person4 = new  Person();
            Console.WriteLine($"{person4.FirstName} {person4.LastName} {person4.Age}");
        }
    }
    
    public class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //This is how you would to this in Java
        // public string GetFullName()
        // {
        //     return $"{FirstName} {LastName}";
        // }
        public string FullName => $"{FirstName} {LastName}";

        public bool IsAdult => Age >= 18;

        public string LastName;
        public string FirstName;
        public int Age;
    }
}
