namespace Statistics.Tests
{
    using Core;
    using System;
    using System.Collections.Generic;
    using Xunit;

    public class StatisticsTests
    {
        [Theory]
        [InlineData(new int[] { 424, -110, 512, 771, -718, -492, 940, 865, -933, 490 }, 174.9)]
        public void MeanInt_ShouldReturnExpectedAverage(int[] dataSet, double expected)
        {
            var result = Statistics.Mean(dataSet);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new long[] { 8431505962840485801, -2330337311172387869, 1351374897039825569 }, 2.4841811829026412E+18)]
        public void MeanLong_ShouldReturnExpectedAverage(long[] dataSet, double expected)
        {
            var result = Statistics.Mean(dataSet);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new float[] { 1.100525131F, 1.037576687F, 1.082994304F, 1.25498008F, 1.104618285F, 1.139981702F, 1.051709758F }, 1.110340850F)]
        public void MeanFloat_ShouldReturnExpectedAverage(float[] dataSet, double expected)
        {
            var result = Statistics.Mean(dataSet);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 71.485569846023347, 58591058.851719525502704, 22586458.018039870326565, 40569684.741146802963242 }, 30436818.274119012)]
        public void MeanDouble_ShouldReturnExpectedAverage(double[] dataSet, double expected)
        {
            var result = Statistics.Mean(dataSet);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MeanDecimal_ShouldReturnExpectedAverage()
        {
            decimal[] testInput = new decimal[]
            {
                42104439.434938478256258M, 29486028.869750852045348m, 5684606.906582218650134m, 49931448.963650180590449m
            };
            decimal expected = 31801631.04373043238554725M;

            var result = Statistics.Mean(testInput);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MeanInt_ShouldThrowOverflowException()
        {
            var testInput = new int[] { int.MaxValue, 1 };
            Assert.Throws<OverflowException>(() => Statistics.Mean(testInput));
        }

        [Fact]
        public void Mean_ShouldThrowArgumentNullExceptionException()
        {
            Assert.Throws<ArgumentNullException>(() => Statistics.Mean((IEnumerable<int>)null));
        }
    }
}