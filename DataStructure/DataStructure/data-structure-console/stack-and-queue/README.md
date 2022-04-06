# Stacks and Queues

**Stacks** : *linear data structure in which elements can be inserted and deleted only from one side of the list, called the **top** . A stack follows the **LIFO** (Last In First Out) principle*

*The insertion of an element into stack is called **push** operation, and deletion of an element from the stack is called **pop** operation. In stack we always keep track of the last element present in the list with a pointer called **top**.*


**Queues** : *A queue is a linear data structure in which elements can be inserted only from one side of the list called **tail**, and the elements can be deleted only from the other side called the **front** . The queue data structure follows the **FIFO** (First In First Out) principle*

*The insertion of an element in a queue is called an **enqueue** operation and the deletion of an element is called a **dequeue** operation. In queue we always maintain two pointers, one pointing to the element which was inserted at the first and still present in the list with the **front** pointer and the second pointer pointing to the element inserted at the last with the **back** pointer.*

---

## Challenge


***In this challenge , I suppose to create 3 classes , Node , Stack and Queue***

***In Stack class , I should implement top properity which is from Node type , and implement many methods , like push() into a stack , pop() from it , get peak() value from top node , and isEmpty() method wich check if the stack is empty or not .***

***In Queue class , I should implement front properity which is from Node type , and implement many methods , like enqueue() into a queue , dequeue() from it , get peak() value from front node , and isEmpty() method wich check if the queue is empty or not .***

---

## Approach & Efficiency

***Space Complexity & Time Complexity : O(1)***

---

## API

**Queue methods :**

-   ***enqueue***
    *Arguments: int value*
    *adds a new node with that value to the back of the queue with an O(1) Time performance.*

-   ***dequeue***
    *Arguments: No Arguments*
    *Returns: the value from node from the front of the queue*
    *adds a new node with that value to the back of the queue with an O(1) Time performance.*
    *Removes the node from the front of the queue*
    *Should raise exception when called on empty queue*

-   ***peek***
    *Arguments: No Arguments*
    *Returns: Value of the node located at the front of the queue*
    *Should raise exception when called on empty stack*


-   ***is empty***
   *Arguments: No Arguments*
   *Returns: Boolean indicating whether or not the queue is empty*

   ---

   **Stack methods :**

-   ***push***
   *Arguments: int value*
   *adds a new node with that value to the top of the stack with an O(1) Time performance.*

-   ***pop***
   *Arguments: No Arguments*
   *Returns: the value from node from the top of the stack*
   *Removes the node from the top of the stack*
   *Should raise exception when called on empty stack*

-   ***peek***
   *Arguments: No Arguments*
   *Returns: Value of the node located at the top of the stack*
   *Should raise exception when called on empty stack*

-  ***is empty***
   *Arguments: No Arguments*
   *Returns: Boolean indicating whether or not the stack is empty*




