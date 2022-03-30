namespace Statistics.Core
{
    using Helper;
    using System.Collections;
    using System.Collections.Generic;
    using static Core.Arithmetic.Arithmetic;

    public static class Statistics
    {
        internal static IArgumentCheck Check = ArgumentCheck.Instance;

        public static double Mean(IEnumerable<int> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            return (double)Summation(dataSet) / (double)Count<int>(dataSet);
        }

        public static double Mean(IEnumerable<long> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            return Summation(dataSet) / Count<long>(dataSet);
        }

        public static float Mean(IEnumerable<float> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            return Summation(dataSet) / Count<float>(dataSet);
        }

        public static double Mean(IEnumerable<double> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            return Summation(dataSet) / Count<double>(dataSet);
        }

        public static decimal Mean(IEnumerable<decimal> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            return Summation(dataSet) / Count<decimal>(dataSet);
        }

        internal static int Count<T>(IEnumerable<T> dataSet)
        {
            Check.Null(dataSet, nameof(dataSet));

            ICollection<T> collection;
            if ((collection = dataSet as ICollection<T>) == null)
            {
                return collection.Count;
            }

            ICollection collection2;
            if ((collection2 = dataSet as ICollection) == null)
            {
                return collection2.Count;
            }

            int count = 0;
            using var enumerator = dataSet.GetEnumerator();
            while (enumerator.MoveNext())
            {
                checked { ++count; }
            }

            return count;
        }
    }

}