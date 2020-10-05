using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }

        public static double GetSumTwo(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numerator = Math.Pow(-1.0, i + 1);
                double denominator = (double)i * (i + 1);
                double quotient = numerator / denominator;
                sum += quotient;
            }

            return sum;
        }
        
        public static double GetSumThree(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numerator = 1;
                double denominator = Math.Pow(i, 5);
                double quotient = numerator / denominator;
                sum += quotient;
            }

            return sum;
        }
        
        public static double GetSumFour(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numerator = 1;
                double denominator = Math.Pow((2 * i) + 1, 2);
                double quotient = numerator / denominator;
                sum += quotient;
            }

            return sum;
        }

        public static double GetProductOne(int n)
        {
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                double numerator = 1;
                double denominator = Math.Pow(i, 2);
                double quotient = numerator / denominator;
                double newSum = quotient + 1;
                sum *= newSum;
            }

            return sum;
        }

        public static double GetSumFive(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double numerator = Math.Pow(-1, i);
                double denominator = (2 * i) + 1;
                double quotient = numerator / denominator;
                sum += quotient;
            }

            return sum;
        }

        public static double GetSumSix(int n)
        {
            double sum = 0;

            for (int i = 1; i < n + 1; i++)
            {
                double factorial = 1;

                for (double j = 1; j < i + 1; j++)
                {
                    factorial *= j;
                }

                sum += factorial / GetSumOne(i);

                if (sum > double.MaxValue)
                {
                    return double.PositiveInfinity;
                }
            }

            return sum;
        }

        public static double GetSumSeven(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = Math.Sqrt(sum + 2);
            }

            return sum;
        }

        public static double MySin(double angle)
        {
            return Math.Sin((angle / 180D) * Math.PI);
        }

        public static double GetSumSin(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double term = MySin(i);
                sum += term;
            }

            return sum;
        }

        public static double GetSumEight(int n)
        {
            double sum = 0;

            for (int i = 1; i < n + 1; i++)
            {
                double sinSum = 0;

                for (int j = 1; j < i + 1; j++)
                {
                    sinSum += Math.Sin(j * Math.PI / 180);
                }

                sum += 1.0 / sinSum;
            }

            return sum;
        }
    }
}
