Insertion Sort

Insertion sort is the sorting mechanism where the sorted array is built having one item at a time. The array elements are compared with each other sequentially and then arranged simultaneously in some particular order. The analogy can be understood from the style we arrange a deck of cards. This sort works on the principle of inserting an element at a particular position, hence the name Insertion Sort.

How Insertion Sort algorithm works :

1. Iterate through the array from arr[1] to arr[n].
2. Compare the current element (key) to one that came before it.
3. If the data at the current index is less than the data at the previous index, you will compare it to the element before it.
4. You will shift bigger elements to the next index to make space for swapped elements, and then you will iterate the same steps again to sort the complete array.

visual:


![Img](https://media.geeksforgeeks.org/wp-content/uploads/insertionsort.png)


Efficency
Time Complexity: O(n^2)

Space Complexity: O(1)