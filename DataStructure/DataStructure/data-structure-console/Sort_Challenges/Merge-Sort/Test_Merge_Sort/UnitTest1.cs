using System;
using Xunit;
using Merge_Sort;

namespace MergeSort
{
    public class UnitTest1
    {

        [Fact]
        public void Test1_Sorted_Array()
        {
            int[] array = { 1 , 6 , 88 , 90 , 122 };

            int[] result = { 1, 6 , 88 , 90 , 122 };

            Merge_Sort.MergeSort sort = new Merge_Sort.MergeSort();

            int[] FinalArray = sort.Mergesort(array);

            Assert.Equal(result, FinalArray);

        }


        [Fact]
        public void Test2_Not_Sorted_Array_1()
        {
            int[] array = { 44 , 3 , 21 , 6 , 4  };

            int[] result = { 3 , 4 , 6 , 21 , 44 };

            Merge_Sort.MergeSort sort = new Merge_Sort.MergeSort();

            int[] FinalArray = sort.Mergesort(array);

            Assert.Equal(result , FinalArray);

        }

        [Fact]
        public void Test3_Not_Sorted_Array_2()
        {
            int[] array = { -22 , 22 , 12 , 321 , 7 , 90 };

            int[] result = { -22 , 7 , 12 , 22 , 90 , 321 };

            Merge_Sort.MergeSort sort = new Merge_Sort.MergeSort();

            int[] FinalArray = sort.Mergesort(array);

            Assert.Equal(result, FinalArray);

        }

        [Fact]
        public void Test4_Empty_Array()
        {
            int[] array = new int[] { };

            Merge_Sort.MergeSort sort = new Merge_Sort.MergeSort();

            Exception E = Assert.Throws<Exception>(() => sort.Mergesort(array));

            Assert.Equal("Array is empty", E.Message);


        }
    }
}
