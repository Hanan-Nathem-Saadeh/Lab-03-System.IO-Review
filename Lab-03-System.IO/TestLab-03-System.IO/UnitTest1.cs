using System;
using Xunit;
using Lab_03_System.IO;

namespace TestLab_03_System.IO
{
    public class UnitTest1
    {
        //challenge1
        [Fact]
        public void MultiplyStringOfNumbers()
        {
            string testString = ("4 2 3");
            int result = Program.MultiplyNumbers(testString);
            Assert.Equal(24, result);

        }
        [Fact]
        public void MultiplyMore3Numbers()
        {
            string testString = ("4 1 3 7 9 2 5 ");
            int result = Program.MultiplyNumbers(testString);
            Assert.Equal(12, result);
        }
        [Fact]
        public void MultiplyLess3Numbers()
        {
            string testString = ("4 1");
            int result = Program.MultiplyNumbers(testString);
            Assert.Equal(0, result);
        }
        [Fact]
        public void MultiplyNegativeNumbers()
        {
            string testString = ("4 1 -10");
            int result = Program.MultiplyNumbers(testString);
            Assert.Equal(-40, result);
        }
        //challenge2
        [Fact]
        public void GetAvgWithDifferentRanges()
        {
            int[] array1= new int[2] { 6, 8 };
            int result1 = Program.GetAverage(array1);
            Assert.Equal(7, result1);
            int[] array2 = new int[8] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int result2 = Program.GetAverage(array2);
            Assert.Equal(9, result2);
            int[] array3 = new int[4] { 1, 1, 1, 1 };
            int result3 = Program.GetAverage(array3);
            Assert.Equal(1, result3);
            int[] array4 = new int[3] { 5, 10, 12 };
            int result4 = Program.GetAverage(array4);
            Assert.Equal(9, result4);
            //Test all numbers are zeroes
            int[] array5 = new int[6] { 0, 0, 0 , 0 , 0 , 0};
            int result5 = Program.GetAverage(array5);
            Assert.Equal(0, result5);
        }
        //challenge4
        [Fact]
        public void RepeatedNDefferentSizeArr()
        {
            int[] array1 = {2,3,4,3,5,1,2,4,1,4,4};
            //There multiple numbers that show up the same amount of times
            int[] array2 = { 2, 2, 2, 2, 3, 3, 3,3};
            int[] array3 = { 9,1,1 };
            int[] array4 = { 5,4,3,5,6,1};
            //No duplicates exist in the array
            int[] array5 = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17};
            //All numbers in the array are the same value
            int[] array6 = {5,5,5,5,5};

            Assert.Equal(4, Program.RepeatedNumber(array1));
            Assert.Equal(2, Program.RepeatedNumber(array2));
            Assert.Equal(1, Program.RepeatedNumber(array3));
            Assert.Equal(5, Program.RepeatedNumber(array4));
            Assert.Equal(1, Program.RepeatedNumber(array5));
            Assert.Equal(5, Program.RepeatedNumber(array6));

        }
        //challenge5
        [Fact]
        public void TestFindMaximumValue()
        {
            // Negative numbers
            int[] array1 = { -1,2,1,-100,100};
            int[] array2 = { -19,-22,-99,-100,-4,-1};
            //All values are the same
            int[] array3 = {4,4,4,4,4,4};
            int[] array4 = { 10,10,10,10,10,10,10,10 };
            Assert.Equal(100 ,Program.FindMaximumValue(array1));
            Assert.Equal(-1, Program.FindMaximumValue(array2));
            Assert.Equal(4, Program.FindMaximumValue(array3));
            Assert.Equal(10, Program.FindMaximumValue(array4));
        }
        // Challenge 9
        [Theory]
        [InlineData("Hanan Saadeh", new string[] { "Hanan: 5, ", "Saadeh: 6, " })]
        [InlineData("I'm 30 years old!! ***", new string[] { "I'm: 3, ", "30: 2, ", "years: 5, ", "old!!: 5, ", "***: 3, "})]

        public void TestNumberOfCharacters(string input, string[] expected)
        {
            string[] result = Program.NumberOfCharacters(input);
            Assert.Equal(expected, result);
        }
    }
}

