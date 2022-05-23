// See https://aka.ms/new-console-template for more information
using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            
            EmployeeWages.AddingCompanies companyA = new EmployeeWages.AddingCompanies("CompanyA", 20, 20, 100);
            EmployeeWages.AddingCompanies companyB = new EmployeeWages.AddingCompanies("CompanyB", 40, 22, 95);
            
            companyA.WageForMonth();
            Console.WriteLine(companyA.toString());
            Console.WriteLine();
            companyB.WageForMonth();
            Console.WriteLine(companyB.toString());

        }
    }
}
