# Hashtables

***A hash table is a data structure that implements an associative array (dictionary). In an associative array, data is stored as a collection of key-value pairs. The position of the data within the array is determined by applying a hashing algorithm to the key - a process called hashing. The hashing algorithm is called a hash function.***

***Hash tables enable very efficient searching. In the best case, data can be retrieved from a hash table in constant time, so you will find them wherever high performance searching is a requirement. Maintaining (adding, updating and deleting) data in a hash table is also very efficient.***


## Challenge

***Implement HashTable class , that contains number of methods like Get , Set , Hash , Contains and Keys***

## Approach & Efficiency

***Efficiency for functions : Get(K key) , Set(K key, V value) and Contains(K key) :***

**Time Complexity : O(1)**
**Space Complexity : O(1)**

***Efficiency for function : Hash(K key) :***

**Time Complexity : O(n)**
**Space Complexity : O(1)**

## API

- ***Set method***

**Arguments** : *key, value*

**Returns** : *nothing*

*This method should hash the key, and set the key and value pair in the table, handling collisions as needed.*

*Should a given key already exist, replace its value from the value argument given to this method.*

- ***Get method***

**Arguments** : *key*

**Returns** : *Value associated with that key in the table*

- ***Contains method***

**Arguments** : *key*

**Returns** : *Boolean, indicating if the key exists in the table already.*

- ***Keys method***

**Returns** : *Collection of keys*

- ***Hash method***

**Arguments** : *key*

**Returns** : *Index in the collection for that key*