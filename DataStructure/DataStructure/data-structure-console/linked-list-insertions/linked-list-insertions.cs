using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertoins
{
    public class linked_list_insertions
    {
       public class Node
        {

            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }


        };
        public class linkedList
        {

            internal Node head;

            public Node append(int new_data)
            {
                // 1. Allocate the Node &
                // 2. Put in the data
                // 3. Set next as null 
                Node new_node = new Node(new_data);

                // 4. If the Linked List is empty,
                //  then make the new node as head 
                if (head == null)
                {
                    head = new Node(new_data);
                    return head;
                }

                // 4. This new node is going to be
                // the last node, so make next of it as null 
                new_node.next = null;

                // 5. Else traverse till the last node 
                Node last = head;
                while (last.next != null)
                    last = last.next;

                // 6. Change the next of last node 
                last.next = new_node;

                return last.next;
            }

            // I used 'Include' method that was implemented in previous challenge
            // to check if the specified value that will be passed to 'insertAfter' and 'insertBefore'
            // methods is already found
            public Node Include(int specifiedValue)
            {
                Node notFound = new Node(0);
                Node current = head; // Initialize current
                while (current != null)
                {
                    if (current.value == specifiedValue)
                        return current; // data found
                    current = current.next;
                }
                return notFound;
            }

            public void insertBefore(int specifiedValue, int new_data)
            {
                // Store the result of 'Include' in a node
                Node nextNode = Include(specifiedValue);

                // First check if the given
                // pointer is the address of
                // head
                if (head == nextNode)
                {
                    // Create a new node
                    Node n = new Node(new_data);

                    // Point to next to current
                    // head
                    n.next = head;

                    // Update the head pointer
                    head = n;

                }

                else
                {
                    Node p = null;

                    // This loop will return p with
                    // previous pointer of given node
                    for (Node n = head; n != nextNode;
                        p = n, n = n.next) ;

                    // Create a new node
                    Node m = new Node(new_data);

                    // Update the m.next
                    m.next = p.next;

                    // Update previous node's next
                    p.next = m;


                }
            }


           
            public void insertAfter(int specifiedValue, int new_data) {

                // Store the result of 'Include' in a node
                Node previousNode = Include(specifiedValue);

                //  Allocate the Node &
                // Put in the data
                Node new_node = new Node(new_data);

                // Make next of new Node as
                // next of current 
                new_node.next = previousNode.next;

                // make next of current
                // as new_node 
                previousNode.next = new_node;


            }
        

            public void toString()
            {

                Node tmp = head;
                while (tmp != null)
                {
                    Console.Write($"{tmp.value} -> ");

                    tmp = tmp.next;

                }
                Console.Write("NULL");

            }
            static void Main(string[] args)
            {

                linkedList l = new linkedList();
                l.append(33);
                l.append(9);
                l.append(78);
                l.append(897);
                l.insertBefore(33, 8080);
                l.insertAfter(9, 100);
                
                l.toString();
            }

        }
    }  
}
