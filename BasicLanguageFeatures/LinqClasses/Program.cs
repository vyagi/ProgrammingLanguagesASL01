using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClasses
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{FirstName} {LastName} is {Age}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ages = new List<int> { 45, 32, 38, 28, 10 };
            var names = new List<string> { "John", "Adam", "Zoey", "Bartholomew", "Cecil" };
            var persons = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Rambo", Age = 80},
                new Person {FirstName = "Bruce", LastName = "Wayne", Age = 60 },
                new Person {FirstName = "Harry", LastName = "Potter", Age = 25},
                new Person {FirstName = "Bruce", LastName = "Lee", Age = 74}
            };

            //Old school approach
            // int sum = 0;
            //
            // foreach (var age in ages)
            // {
            //     sum += age;
            // }

            var sum = ages.Sum();
            var avg = ages.Average();
            var min = ages.Min();
            var max = ages.Max();

            Console.WriteLine($"{max}, {min}, {sum}, {avg}");

            var adults = ages.Where(x => x > 17);

            foreach (var adult in adults) Console.WriteLine(adult);
            Console.WriteLine("---------------------------------");

            var oddAges = ages.Where(x => x % 2 != 0);
            foreach (var age in oddAges) Console.WriteLine(age);
            Console.WriteLine("---------------------------------");

            var fromYoungest = ages.OrderBy(x => x);
            foreach (var age in fromYoungest) Console.WriteLine(age);
            Console.WriteLine("---------------------------------");

            var byOnes = ages.OrderByDescending(x => x % 10);
            foreach (var age in byOnes) Console.WriteLine(age);
            Console.WriteLine("---------------------------------");

            var namesAlphabetically = names.OrderBy(x => x);
            foreach (var name in namesAlphabetically) Console.WriteLine(name);
            Console.WriteLine("---------------------------------");

            var namesByLength = names.OrderByDescending(x => x.Length);
            foreach (var name in namesByLength) Console.WriteLine(name);
            Console.WriteLine("---------------------------------");

            var strangelySortedNames = names
                .Where(x => x.Length < 6)
                .OrderBy(x => x.Last());

            foreach (var name in strangelySortedNames) Console.WriteLine(name);
            Console.WriteLine("---------------------------------");

            var namesOfOlderHeros = persons
                .Where(x => x.Age > 30)
                .OrderBy(x => x.FirstName)
                .Select(x => x.FirstName + " " + x.LastName);

            foreach (var name in namesOfOlderHeros) Console.WriteLine(name);
            Console.WriteLine("---------------------------------");

            var sortedAlphabeticallyByFirstName = persons.OrderBy(x => x.FirstName);
            foreach (var name in sortedAlphabeticallyByFirstName) Console.WriteLine(name);
            Console.WriteLine("---------------------------------");
        }
    }
}
