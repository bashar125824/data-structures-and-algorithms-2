# What is Merge Sort ?

***Merge Sort is one of the most popular sorting algorithms that is based on the principle of Divide and Conquer Algorithm.***

# How Merge 

## Divide and Conquer Strategy

***Using the Divide and Conquer technique, we divide a problem into subproblems. When the solution to each subproblem is ready, we 'combine' the results from the subproblems to solve the main problem.***

***Suppose we had to sort an array A. A subproblem would be to sort a sub-section of this array starting at index p and ending at index r, denoted as ```A[p..r]```.***

**Divide**

***If q is the half-way point between p and r, then we can split the subarray A[p..r] into two arrays ```A[p..q]``` and ```A[q+1, r]```.***

**Conquer**

***In the conquer step, we try to sort both the subarrays ```A[p..q]``` and ```A[q+1, r]``` . If we haven't yet reached the base case, we again divide both these subarrays and try to sort them.***

**Combine**

***When the conquer step reaches the base step and we get two sorted subarrays ```A[p..q]``` and ```A[q+1, r]``` for array ```A[p..r]```, we combine the results by creating a sorted array ```A[p..r]``` from two sorted subarrays ```A[p..q]``` and ```A[q+1, r]```.***

![Img](https://cdn.programiz.com/cdn/farfuture/PRTu8e23Uz212XPrrzN_uqXkVZVY_E0Ta8GZp61-zvw/mtime:1586425911/sites/tutorial2program/files/merge-sort-example_0.png)

### What actually happened in the obove example :

1. **get mid element in the array which is at index 3 (10)**

2. **recursively divide the array into two halves, keep dividing until array length become 1.**

3. **compare each element with its consecutive elements and arrange them in a sorted manner.**

4. **compare two arrays and sort them**

5. **compare the elements of the two arrays each of size and we will get our resultant sorted array**

# WhiteBoard :

![IMG](/DataStructure/DataStructure/data-structure-console/Sort_Challenges/Merge-Sort/WBMergeSort.jpg)

# Big(O) Notation

***Time Complexity :*** **O(Nlog(N))**
***Space Complexity :*** **O(N)**
