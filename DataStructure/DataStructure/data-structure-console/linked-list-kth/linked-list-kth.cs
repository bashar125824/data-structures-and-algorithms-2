using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.linked_list_kth
{
    class linked_list_kth

    {

        public class LinkedList
        {
            public Node head; // head of the list

            /* Linked List node */
            public class Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }


            public int linkedListKth(int k)
            {
                int len = 0;
                Node temp = head;

                // 1) count the number of nodes in Linked List
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }

                // check if value of n is not more than length of
                // the linked list
                if (len < k)
                    return 0;

                temp = head;

<<<<<<< HEAD
                // 2) get the (len-k+1)th node from the beginning
=======
                // 2) get the (len-n+1)th node from the beginning
>>>>>>> main
                for (int i = 1; i < len - k + 1; i++)
                    temp = temp.next;

                return temp.data;
            }

            /* Inserts a new Node at front of the list. */
            public void push(int new_data)
            {
                /* 1 & 2: Allocate the Node &
                        Put in the data*/
                Node new_node = new Node(new_data);

                /* 3. Make next of new Node as head */
                new_node.next = head;

                /* 4. Move the head to point to new Node */
                head = new_node;
            }

<<<<<<< HEAD
            public static void main(String[] args)
=======
            public static void Main(String[] args)
>>>>>>> main
            {
                LinkedList myList = new LinkedList();
                myList.push(100);
                myList.push(22);
                myList.push(343);
                myList.push(43);

                int result = myList.linkedListKth(3);

                Console.WriteLine(result);
            }
        }







    }
        }
    

