namespace Statistics.Core.Arithmetic
{
    using Helper;
    using System.Collections.Generic;

    public static class Arithmetic
    {
        public static int Summation(IEnumerable<int> dataSet)
        {
            ArgumentCheck.Instance.Null(dataSet, nameof(dataSet));

            int sum = 0;

            foreach(int data in dataSet)
            {
                sum = checked(sum + data);
            }

            return sum;
        }

        public static long Summation(IEnumerable<long> dataSet)
        {
            ArgumentCheck.Instance.Null(dataSet, nameof(dataSet));

            long sum = 0L;

            foreach(long data in dataSet)
            {
                sum = checked(sum + data);
            }

            return sum;
        }

        public static float Summation(IEnumerable<float> dataSet)
        {
            ArgumentCheck.Instance.Null(dataSet, nameof(dataSet));

            double sum = 0d;
            foreach(float data in dataSet)
            {
                sum += data;
            }

            return (float)sum;
        }

        public static double Summation(IEnumerable<double> dataSet)
        {
            ArgumentCheck.Instance.Null(dataSet, nameof(dataSet));

            double sum = 0d;
            foreach(double data in dataSet)
            {
                sum += data;
            }

            return sum;
        }

        public static decimal Summation(IEnumerable<decimal> dataSet)
        {
            ArgumentCheck.Instance.Null(dataSet, nameof(dataSet));

            decimal sum = 0.0m;
            foreach(decimal data in dataSet)
            {
                sum += data;
            }

            return sum;
        }
    }
}