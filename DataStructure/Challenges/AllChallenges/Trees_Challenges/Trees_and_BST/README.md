# Trees

***Trees represents a hierarchical tree structure with a set of connected nodes. Each node in the tree can be connected to many children (depending on the type of tree), but must be connected to exactly one parent, except for the root node, which has no parent. These constraints mean there are no cycles or "loops" (no node can be its own ancestor), and also that each child can be treated like the root node of its own subtree, making recursion a useful technique for tree traversal.***


## Challenge

***Implement 2 classes , Binary Tree and Binary Search Tree classes***

## Approach & Efficiency

***O(N) ----> Traversal (InOrder , PreOrder and PostOrder)***
***O(Log(N)) ----> Add and Contains methods***

## API

### Pre order:

1- *Check root node*

2- *Check all the nodes in the left subtree*

3- *Check all the nodes in the right subtree*

### In order

1- *Check all the nodes in the left subtree*

2- *Check the root node*

3- *Check all the nodes in the right subtree*

### Post order

1- *Check all the nodes in the left subtree*

2- *Check all the nodes in the right subtree*
 
3- *Check the root node*

**returns an array of the values, ordered appropriately.**


### Add : 

**Arguments** : integer value
**Return** : nothing
**Adds a new node with that value in the correct location in the binary search tree**

### Contains :

**Argument** : integer value
**Returns** : boolean indicating whether or not the value is in the tree at least once.