using System;

namespace WaldoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Bob", "Dana", "Julie", "Sarah", "Fred", "Waldo", "Jenny", "Cathy" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Waldo")
                {
                    Console.WriteLine($"Waldo was found at position {i}");
                    Environment.Exit(0);
                }
            }

        }
    }
}
