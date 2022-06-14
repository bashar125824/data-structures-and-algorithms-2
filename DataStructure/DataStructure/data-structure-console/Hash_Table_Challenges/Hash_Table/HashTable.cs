using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class HashTable
    {
        public class Node
        {
            public int Key;
            public string Value;
            public Node Next;

            public Node(int key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        
            int Size;
            Node[] hashTable;

            public HashTable(int hashSize)
            {
             Size = hashSize;
             hashTable = new Node[hashSize];
            }

            public void Set(int key, string value)
            {
            

                int hashedKey = Hash(key);

                if (hashTable[hashedKey] == null)
                {
                hashTable[hashedKey] = new Node(key, value);
                }
                // Collision Handling
                else
                {
                    
                    Node temp = hashTable[hashedKey];
                    while (temp.Next != null)
                    {
                        // Override , if the key already exists ..
                        if (temp.Key == key)
                        {
                            temp.Value = value;
                            return;
                        }

                        temp = temp.Next;
                    }

                    temp.Next = new Node(key, value);
                }
            }

            public bool Contains(int key)
            {
                int hashedKey = Hash(key);
                Node temp = hashTable[hashedKey];

                while (temp != null)
                {
                    if (temp.Key == key)
                        return true;

                    temp = temp.Next;
                }

                return false;
            }

            public string Get(int key)
            {
                if (!Contains(key))
                    throw new Exception("Key does't exist!");

                int hashedKey = Hash(key);

                Node temp = hashTable[hashedKey];
                while (temp.Key != key)
                {
                    temp = temp.Next;
                }

                return temp.Value;

            }
            private int Hash(int key)
            {
                return key % Size;
            }
    }
}
