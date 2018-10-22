using System;
using System.IO;
using CalculatorLib;

namespace Midterm_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir = Environment.CurrentDirectory;
            string input = Path.Combine(currentDir, "CalcInput.txt");
            string output = Path.Combine(currentDir, "CalcOutput.txt");

            //checks if input file exists, if not, exits application
            StreamReader textReader;
            if (!File.Exists(input))
            {
                Console.WriteLine("CalcInput.txt does not exist");
                System.Environment.Exit(1);
            }

            textReader = File.OpenText(input);
            //counting number of lines in input file to determine array size
            var lineCount = 0;
            using (textReader)
            {
                while (textReader.ReadLine() != null)
                    lineCount++;
            }

            double[] nums = new double[lineCount];

            //reading in file into array
            textReader = File.OpenText(input);
            string line;
            int i = 0;
            while ((line = textReader.ReadLine()) != null)
            {
                nums[i] = Convert.ToDouble(line);
                i++;
            }
            textReader.Close();

            //creating output file
            StreamWriter textWriter = File.CreateText(output);

            //calculating and writing results in output file
            Calculator calc = new Calculator();
            textWriter.WriteLine("For contents of CalcInput.txt");
            textWriter.WriteLine($"Mean: {Math.Round(calc.Mean(nums), 3)}");
            textWriter.WriteLine($"Median: {calc.Median(nums)}");
            textWriter.Close();

            Console.WriteLine("Output completed and printed in CalcOutput.txt");
            Console.WriteLine($"Filepath is {output}");
        }
    }
}
