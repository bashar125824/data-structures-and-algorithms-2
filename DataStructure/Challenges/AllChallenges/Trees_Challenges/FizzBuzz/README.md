# Challenge Summary

***In this challenge , I suppose to write a function called FizzBuzzTree , that traverse a tree  and determine if nodes values are divisible by 3 or 5 or both 3 and 5 , if node value is divisible by 3 , then it's " Fizz " and if it's divisible by 5 , then it's " Buzz " and if it's divisible by 3 and 5 , then it's " FizzBuzz " , and if it's NOT divisible by 3 or 5  , then replace it with it's value as a string***

## Whiteboard Process

![Img](/DataStructure/Challenges/AllChallenges/Trees_Challenges/FizzBuzz/FizzBuzzWB.jpg)

## Approach & Efficiency

***O(N) ---> Space and Time Complexity***

## Solution

![IMG](/DataStructure/Challenges/AllChallenges/Trees_Challenges/FizzBuzz/FzzBuzz.PNG)

***In this code , the tree containing 6 nodes , the root and 5 other nodes , as the terminal shows , the root isn't divisible by either 3 or 5 , so it's replaced with itself as a string , first node (5) is divisible by 5 , then it's " Buzz " , second and fourth nodes (3) , (33) are divisible by 3 , then they are " Fizz " , third node  (60) is divisible by 3 and 5 , then it's " FizzBuzz " , the last node (77) isn't divisible by 3 or 5 , so it's replaced by itself .***