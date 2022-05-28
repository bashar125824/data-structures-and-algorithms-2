using System;
using Xunit;
using Insertion;

namespace Test_Insertion_Sort
{
    public class Insertion_Sort
    {
        [Fact]
        public void Test1()
        {

            int[] Test_array = { 4, 11, 22, 1, 9 };
            int[] result = { 1, 4, 9, 11, 22 };

            Insertion.Insertion_Sort Test_Sort = new Insertion.Insertion_Sort();
            int[] Temp;

            Temp = Test_Sort.InsertionSort(Test_array);
            Assert.Equal(result, Temp);

        }
    }
}
