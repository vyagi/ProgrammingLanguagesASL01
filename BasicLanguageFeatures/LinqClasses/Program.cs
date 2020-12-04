using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace LinqClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetEmployees().ToList();
            var personalData = PersonalData.GetPersonalData().ToList();

            //Example:
            var example =
                from employee in employees
                where employee.Age < 40
                orderby employee.Seniority descending
                select new 
                { 
                    FullName = $"{employee.FirstName} {employee.LastName}", 
                    TotalSalary = employee.BaseSalary + employee.Bonus
                };

            foreach (var emp in example) 
                Console.WriteLine($"{emp.FullName} earns {emp.TotalSalary}");

            // EasyQueries(employees);
            //19. Who lives where

            var nameWithAddress =
                from employee in employees
                join data in personalData on employee.Id equals data.Id
                select new
                {
                    FullName = $"{employee.FirstName} {employee.LastName}",
                    Address = $"{data.City}, {data.Street} {data.House}"
                };

            foreach (var nwa in nameWithAddress) 
                Console.WriteLine($"{nwa.FullName} lives in {nwa.Address}");

            //21. From which city are the most employees
            var employeeWithCity =
                from employee in employees
                join data in personalData on employee.Id equals data.Id
                select new { Employee = employee, data.City };

            var grouped = employeeWithCity
                .GroupBy(x => x.City)
                .OrderByDescending(x => x.Count())
                .ToList();

            var maximalNumberOfEmployees = grouped.First().Count();
            var theCitiesWithMostEmployees = grouped
                .Where(x => x.Count() == maximalNumberOfEmployees)
                .Select(x=> x.Key);

            foreach (var city in theCitiesWithMostEmployees)
            {
                Console.WriteLine(city);
            }

        }

        private static void EasyQueries(List<Employee> employees)
        {
            //1. Select employees with seniority greater than 8 years
            var experiencedEmployees = employees
                .Where(x => x.Seniority > 8);

            foreach (var experiencedEmployee in experiencedEmployees)
                Console.WriteLine($"{experiencedEmployee.FirstName} {experiencedEmployee.LastName}");

            Console.WriteLine("------------------------------------------------------");

            //2. Select women employees
            var womenEmployees = employees
                .Where(x => x.Gender == Gender.Woman);

            foreach (var woman in womenEmployees)
                Console.WriteLine($"{woman.FirstName} {woman.LastName}");

            Console.WriteLine("------------------------------------------------------");

            //3. Find the average salary
            var averageSalary = employees
                .Select(x => x.BaseSalary)
                .Average();

            var averageSalaryWithATrick = employees
                .Average(x => x.BaseSalary);

            Console.WriteLine($"Average salary is {averageSalary} (the same with a trick {averageSalaryWithATrick})");

            Console.WriteLine("------------------------------------------------------");

            //4. Select employees who earn above the average
            var earnAboveTheAverage = employees
                .Where(x => x.BaseSalary > averageSalary);

            foreach (var employee in earnAboveTheAverage)
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");

            Console.WriteLine("------------------------------------------------------");

            //5. Select employees with bonus greater than 10% of their salary
            var withGoodBonus = employees
                .Where(x => x.Bonus > 0.1M * x.BaseSalary);

            foreach (var employee in withGoodBonus)
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");

            Console.WriteLine("------------------------------------------------------");

            //6. Find the sum of salaries paid for men employees
            var sumOfSalariesForMen = employees
                .Where(x => x.Gender == Gender.Man)
                .Sum(x => x.BaseSalary);

            Console.WriteLine($"We pay {sumOfSalariesForMen} for all the men employees in total");
            Console.WriteLine("------------------------------------------------------");

            //7. Find women with the highest seniority
            var womenHighestSeniority = employees
                .Where(x => x.Gender == Gender.Woman)
                .Max(x => x.Seniority);

            var womenWithHighestSeniority =
                employees.Where(x => x.Gender == Gender.Woman && x.Seniority == womenHighestSeniority);

            foreach (var employee in womenWithHighestSeniority)
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");

            Console.WriteLine("------------------------------------------------------");

            //8. Find the sum of bonus for all the employees on their notice period
            var bonusForNoticedEmployees = employees
                .Where(x => x.Role == Role.OnNotice)
                .Sum(x => x.Bonus);

            Console.WriteLine($"We pay {bonusForNoticedEmployees} bonus for all the noticed employees");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
