Merge Sort

Merge sort is similar to the quick sort algorithm as it uses the divide and conquer approach to sort the elements. It is one of the most popular and efficient sorting algorithm. It divides the given list into two equal halves, calls itself for the two halves and then merges the two sorted halves.

Pseudo Code
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length

    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1

        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left

How Merge Sort algorithm works :

given array : [8,4,23,42,16,15]

find mid of the array which is at index 3

recursively divide the array into two halves, keep dividing until array length become 1.

compare each element with its consecutive elements and arrange them in a sorted manner.

compare two arrays and sort them

compare the elements of the two arrays each of size and we will get our resultant sorted array

Visual

![IMG](https://www.worldofitech.com/wp-content/uploads/2021/03/merge-sort-example_0-.1.png)

Efficency
Time Complexity: O(nLogn)
Space Complexity: O(n)