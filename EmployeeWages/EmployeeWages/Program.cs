// See https://aka.ms/new-console-template for more information
using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmployeeWages.AddingCompanies getMethod = new EmployeeWages.AddingCompanies();
            Console.WriteLine("Employee Wage for Company A:");
            getMethod.WageForMonth(20, 20, 100);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company B:");
            getMethod.WageForMonth(40, 25, 80);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company C:");
            getMethod.WageForMonth(60, 15, 90);
        }
    }
}
