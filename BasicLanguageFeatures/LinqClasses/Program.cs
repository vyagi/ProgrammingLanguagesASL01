using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetEmployees().ToList();
            var personalData = PersonalData.GetPersonalData().ToList();
            
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



        }
    }
}
