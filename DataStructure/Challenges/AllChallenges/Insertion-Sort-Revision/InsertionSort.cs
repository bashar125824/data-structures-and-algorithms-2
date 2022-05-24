using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    public class Insertion_Sort
    {
        public int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int Temp = arr[min];
                arr[min] = arr[i];
                arr[i] = arr[min];
            }
            return arr;
        }


    }
}
