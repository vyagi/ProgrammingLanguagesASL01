using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Marcin", "Jagieła", 19);
            var person2 = new Person("Donald", "Trump", 70);

            Console.WriteLine(person1.FullName);
            Console.WriteLine(person2.FullName);

            Console.WriteLine(person1.IsAdult);

            var person3 = new Person("Donald", "Tusk", 60);
            Console.WriteLine(person3.LastName);
            person3.LastName = "Wałęsa";
            Console.WriteLine(person3.LastName);
        }
    }
    
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name should not be empty");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name should not be empty");

            if (age < 0)
                throw new ArgumentException("Age should not be negative");

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string FullName => $"{_firstName} {_lastName}";

        public bool IsAdult => _age >= 18;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name should not be empty");

                _lastName = value;
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name should not be empty");

                _firstName = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age should not be negative");

                _age = value;
            }
        }

        private string _lastName;
        private string _firstName;
        private int _age;
    }
}
