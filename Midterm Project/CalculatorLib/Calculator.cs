using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        //returns mean of array
        public double Mean(double[] arr)
        {
            double sum = 0;
            int size = arr.Length;

            foreach(double i in arr)
            {
                sum = sum + i;
            }

            return sum / size;
        }

        //returns median of array
        public double Median(double[] arr)
        {
            int size = arr.Length;

            Array.Sort(arr);

            //if size of array is even, return mean of two middle terms
            if (size % 2 == 0)
                return (arr[(size / 2) - 1] + arr[(size / 2)]) / 2;
            //if size of array is odd, return middle term
            else
                return (arr[(size - 1) / 2]);
        }
    }
}
