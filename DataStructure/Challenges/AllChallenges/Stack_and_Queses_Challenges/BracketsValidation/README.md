# Challenge Summary

***Validate Brackets using Stack data structure***

## Whiteboard Process

![IMG](/DataStructure/Challenges/AllChallenges/Stack_and_Queses_Challenges/BracketsValidation/Brackets.jpg)

## Approach & Efficiency

***O(N) --->  Time Complexity***
***O(N) --->  Space Complexity***

**Approach :**

***validateBrackets(string str):***

1.  ***Loop str to one letter every time***

2. ***Checking*** : 

- **Check if character is ‘(‘ , if yes , then push ‘)’ to stack**

- **Check if character is ‘[‘, if yes , then push ‘]’ to stack**

- **Check if character is ‘}’ , if yes , then push ‘}’ to stack**

3. ***Check if stack is empty, if yes return false***

4. ***Else if stack is not empty, pop from stack and popped bracket should be same as first bracket , else return false***
