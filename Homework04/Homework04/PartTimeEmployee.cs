using System;
using System.Collections.Generic;
using System.Text;

namespace Homework04
{
    class PartTimeEmployee : Employee
    {
        //constructors
        public PartTimeEmployee() { }

        public PartTimeEmployee(string fname, string lname, DateTime date, string empcode, double hourly)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.DateHired = date;
            this.EmployeeCode = empcode;
            this.HourlyRate = hourly;
        }

        //methods
        new public void WriteToConsole()
        {
            Console.WriteLine($"Part timee employee {FirstName} {LastName} with employee code {EmployeeCode}, was hired on {DateHired:MM/dd/yyyy}" +
                $" and has an hourly rate of ${HourlyRate}");
        }

        //properties
        public double HourlyRate;
    }
}
