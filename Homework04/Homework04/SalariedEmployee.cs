using System;
using System.Collections.Generic;
using System.Text;

namespace Homework04
{
    class SalariedEmployee : Employee
    {
        //constructors
        public SalariedEmployee() { }

        public SalariedEmployee(string fname, string lname, DateTime date, string empcode, double salary)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.DateHired = date;
            this.EmployeeCode = empcode;
            this.AnnualSalary = salary;
        }

        //write to console method
        new public void WriteToConsole()
        {
            Console.WriteLine($"Salaried employee {FirstName} {LastName} with employee code {EmployeeCode}, was hired on {DateHired:MM/dd/yyyy}" +
                $" and has a yearly salary of ${AnnualSalary}");
        }

        //properties
        public double AnnualSalary { get; set; }
    }
}
