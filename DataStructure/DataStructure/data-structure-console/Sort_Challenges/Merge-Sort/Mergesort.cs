using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    public class MergeSort
    {

        public int[] Mergesort(int[] arr)
        {
            int n = arr.Length;
            if (n == 0)
            {
                throw new Exception("Array is empty");
            }
            if (n > 1)
            {
                int mid = n / 2;
                int[] L = new int[mid];
                for (int i = 0; i < mid; i++)
                {
                    L[i] = arr[i];
                }
                int[] R = new int[n - mid];
                for (int i = mid; i < n; i++)
                {
                    R[i - mid] = arr[i];
                }
                Mergesort(L);
                Mergesort(R);
                Merge(L, R, arr);
            }
            return arr;
        }
        public void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0,             // left array pointer               
            j = 0,            // right array pointer               
           k = 0;            // merged array pointer            
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i += 1;
                }
                else
                {
                    arr[k] = right[j];
                    j += 1;
                }
                k += 1;
            }
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
