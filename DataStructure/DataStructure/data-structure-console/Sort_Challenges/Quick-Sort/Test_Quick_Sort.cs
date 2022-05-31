using System;
using Xunit;
using QuickSort;

namespace Test_Quick_Sort
{
    public class Quick_Sort
    {
        [Fact]
        public void Test1_Unsorted_Array()
        {
            int[] array = { 23 , 110 , 213 , 9 , -8 };
            int[] result = { -8 , 9 , 23 , 110 , 213 };
           
            QuickSort.Quick_Sort testSort = new QuickSort.Quick_Sort();
            testSort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, testSort.showArray(array));
        }

        [Fact]
        public void Test2_Sorted_Array()
        {
            int[] array = {-99 , -1 , 0 , 232 , 999 };
            int[] result = { -99 , -1 , 0 , 232 , 999 };

            QuickSort.Quick_Sort testSort = new QuickSort.Quick_Sort();
            testSort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, testSort.showArray(array));
        }

        [Fact]
        public void Test3_Duplicate_Numbers_in_Array()
        {
            int[] array = { 22 , 22 , 3 , 3 , 200 };
            int[] result = { 3 , 3 , 22 , 22 , 200 };

            QuickSort.Quick_Sort testSort = new QuickSort.Quick_Sort();
            testSort.Quicksort(array, 0, array.Length - 1);
            Assert.Equal(result, testSort.showArray(array));
        }
    }
}
