# Challenge Summary


***In this challenge , I supposed to implement stack as queue , so I used Enqueue and Dequeue to make stack work as queue .***

---

## Whiteboard Process

![IMG](DataStructure/DataStructure/data-structure-console/stack-queue-pseudo/Queue_Pseudo.jpg)

---

## Approach & Efficiency

**Efficiency :**

***Time Complexity : O(N)***
***Space Complexity : O(1)***

---

**Approach :**

***I used two stacks to implement enqueue and dequeue methods , in inqueue method , I pushed new data into first stack , in dequeue method , firstly I popped out elements from first stack and pushed it into the second one (Copy first stack into second stack) , after that I popped first element of second stack , finally I pushed pack elements from second stack to first one***

