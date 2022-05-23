// See https://aka.ms/new-console-template for more information
using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmployeeWages.AddingCompanies getMethod = new EmployeeWages.AddingCompanies();
            getMethod.WageForMonth();
            
        }
    }
}
