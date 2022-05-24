# Isnertion Sort :

***Insertion sort is , sorting algorithm in which the elements are transferred one at a time to the right position. In other words, an insertion sort helps in building the final sorted list, one item at a time, with the movement of higher-ranked elements. An insertion sort has the benefits of simplicity and low overhead.***

---

## Big (O) Notation  :

**Space Complexity :** *O(1)* 
**Time Complexity :** *O(n^2)* 

---

## How Insertion Sort works ?

We take an unsorted array for our example.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/unsorted_array.jpg)

Insertion sort compares the first two elements.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_1.jpg)

It finds that both 14 and 33 are already in ascending order. For now, 14 is in sorted sub-list.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_2.jpg)

Insertion sort moves ahead and compares 33 with 27.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_3.jpg)

And finds that 33 is not in the correct position.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_4.jpg)

It swaps 33 with 27. It also checks with all the elements of sorted sub-list. Here we see that the sorted sub-list has only one element 14, and 27 is greater than 14. Hence, the sorted sub-list remains sorted after swapping.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_5.jpg)

By now we have 14 and 27 in the sorted sub-list. Next, it compares 33 with 10.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_6.jpg)

These values are not in a sorted order.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_7.jpg)

So we swap them.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_8.jpg)

However, swapping makes 27 and 10 unsorted.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_9.jpg)

Hence, we swap them too.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_10.jpg)

Again we find 14 and 10 in an unsorted order.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_11.jpg)

We swap them again. By the end of third iteration, we have a sorted sub-list of 4 items.
![IMG](https://www.tutorialspoint.com/data_structures_algorithms/images/insertion_sort_12.jpg)

This process goes on until all the unsorted values are covered in a sorted sub-list. Now we shall see some programming aspects of insertion sort.

---

## WhiteBoard : 

![IMG](/DataStructure/Challenges/AllChallenges/Insertion-Sort-Revision/InsertionWB.jpg)