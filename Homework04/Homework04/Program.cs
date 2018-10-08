using System;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating and displaying employee class
            Employee emp = new Employee("Spike", "Spiegel", new DateTime(1997,9,15), "0125");

            emp.WriteToConsole();
            Console.WriteLine("\n");

            //creating and displaying salaried employee class
            SalariedEmployee salEmp = new SalariedEmployee("Jet", "Black", new DateTime(2004, 8, 24), "1250", 70000);

            salEmp.WriteToConsole();
            Console.WriteLine("\n");

            //creating and displaying part time employee class
            PartTimeEmployee partEmp = new PartTimeEmployee("Faye", "Valentine", new DateTime(2008, 3, 5), "2115", 20.75);

            partEmp.WriteToConsole();
            Console.WriteLine("\n");
        }
    }
}
