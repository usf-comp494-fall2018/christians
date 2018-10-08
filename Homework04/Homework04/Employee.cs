using System;
using System.Collections.Generic;
using System.Text;

namespace Homework04
{
    class Employee
    {
        //constructors
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateHired = new DateTime();
            EmployeeCode = string.Empty;
        }

        public Employee(string fname, string lname, DateTime date, string empcode)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.DateHired = date;
            this.EmployeeCode = empcode;
        }

        //write to console method
        public void WriteToConsole()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} with employee code {EmployeeCode}, was hired on {DateHired:MM/dd/yyyy}");
        }

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public string EmployeeCode { get; set; }
    }
}
