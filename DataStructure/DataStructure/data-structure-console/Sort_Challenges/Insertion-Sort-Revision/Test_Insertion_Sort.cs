sing System;
using Xunit;
using Insertion;

namespace Test_Insertion_Sort
{
    public class Insertion_Sort
    {
        [Fact]
        public void Test1_Unsorted_Array()
        {

            int[] Test_array = { 4 , 11 , 22 , 1 , 9 };
            int[] result = { 1 , 4 , 9 , 11 , 22 };

            Insertion.Insertion_Sort Test_Sort = new Insertion.Insertion_Sort();
            int[] Temp;

            Temp = Test_Sort.InsertionSort(Test_array);
            Assert.Equal(result, Temp);

        }

        [Fact]
        public void Test2_Sorted_Array()
        {

            int[] Test_array = { 41 , 91, 100 , 101 , 299 };
            int[] result = { 41 , 91 , 100 , 101 , 299 };

            Insertion.Insertion_Sort Test_Sort = new Insertion.Insertion_Sort();
            int[] Temp;

            Temp = Test_Sort.InsertionSort(Test_array);
            Assert.Equal(result, Temp);

        }

        [Fact]
        public void Test3_Negative_Numbers()
        {

            int[] Test_array = { -22 , -1 , -100, -88 , -65 };
            int[] result = { -100 , -88 , -65 , -22 , -1 };

            Insertion.Insertion_Sort Test_Sort = new Insertion.Insertion_Sort();
            int[] Temp;

            Temp = Test_Sort.InsertionSort(Test_array);
            Assert.Equal(result, Temp);

        }
    }
}
