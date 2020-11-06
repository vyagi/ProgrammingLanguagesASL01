using System;

namespace BasicClasses
{
    public class Person
    {
        private string _lastName;
        private string _firstName;
        private int _age;

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
    }
}