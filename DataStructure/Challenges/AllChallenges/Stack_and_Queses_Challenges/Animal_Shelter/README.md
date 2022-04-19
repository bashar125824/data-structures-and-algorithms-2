# Challenge Summary

***In this challenge , I suppose to create a class called AnimalShelter , which contains two methods ,  Enqueue and Dequeue , the shelter operates using a first-in, first-out approach , the class contains Dog and Cat which are Animals objects ***

## Whiteboard Process

![IMG](/DataStructure/Challenges/AllChallenges/Stack_and_Queses_Challenges/Animal_Shelter/Shelter.jpg)

## Approach & Efficiency

***O(1) --->  Time Complexity***
***O(1) --->  Space Complexity***

**Approach :**

***I created a parent class called Animal , then I created two children classes , Dog and Cat , in AnimalShelter class , I created two queues of types Dog and Cat , then I implement the two methods :***

1. **Enqueue :** 

*Arguments : animal*
*animal can be either a dog or a cat object*
*Return : None*

2. **Dequeue :**

*Arguments : pref (string)*
*pref can be either "dog" or "cat"*
*Return : either a dog or a cat, based on preference*
*If pref is not "dog" or "cat" then return null*
