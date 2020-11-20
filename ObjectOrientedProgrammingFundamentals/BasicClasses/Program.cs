using System;

namespace BasicClasses
{
    class Program
    {
        public class Car
        {
            private readonly string _make;
            private readonly string _color;
            private readonly int _yearOfProduction;
            private readonly int _fuelCapacity;
            private readonly int _fuelUsagePer100Km;
            private int _kilometerCounter;
            private int _fuelLevel;

            public string Make => _make;
            public string Color => _color;
            public int YearOfProduction => _yearOfProduction;
            public int KilometerCounter => _kilometerCounter;
            public int FuelLevel => _fuelLevel;

            public Car(string make, string color, int yearOfProduction, int fuelCapacity, int fuelUsagePer100Km)
            {
                _make = make;
                _color = color;
                _yearOfProduction = yearOfProduction;
                _fuelCapacity = fuelCapacity;
                _fuelUsagePer100Km = fuelUsagePer100Km;
            }

            public void Tank(int howManyLiters)
            {
                if (howManyLiters < 0 )
                    throw new ArgumentException("You need to provide positive value");

                if (_fuelLevel + howManyLiters > _fuelCapacity) 
                    _fuelLevel = _fuelCapacity;
                else
                    _fuelLevel += howManyLiters;
            }

            public void Drive(int distance)
            {
                if (distance < 0)
                    throw new ArgumentException("You need to provide positive value");

                var range = _fuelLevel * 100 / _fuelUsagePer100Km;  

                if (distance > range)   
                {
                    //if you have 3 litres in you car, and you want to drive 100 km, and your car uses 6 l / 100km
                    _kilometerCounter += range;
                    _fuelLevel = 0;
                }
                else
                {
                    _kilometerCounter += distance;
                    _fuelLevel -= distance * _fuelUsagePer100Km / 100;
                }
            }
        }


        static void Main(string[] args)
        {
             var car1 = new Car("Ford", "White", 2019, 60, 6);
             
             car1.Tank(300);
             car1.Drive(100);

             car1.Drive(50);

             Console.WriteLine($"{car1.Make} produced in {car1.YearOfProduction} is {car1.Color}");
             Console.WriteLine($"It drove {car1.KilometerCounter} and currently has {car1.FuelLevel} liters of fuel");

             
        }

        private static void PersonTests()
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
}
