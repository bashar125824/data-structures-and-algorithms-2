using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zip
{
    public class linked_list_zip
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public class LinkedList
        {
            public Node head;

            public int append(int new_data)
            {
                // Allocate the Node &
                // Put in the data
                // Set next as null 
                Node new_node = new Node(new_data);

                //  If the Linked List is empty,
                //  then make the new node as head 
                if (head == null)
                {
                    head = new Node(new_data);
                    return new_data;
                }

                // This new node is going to be
                // the last node, so make next of it as null 
                new_node.next = null;

                //  Else traverse till the last node 
                Node last = head;
                while (last.next != null)
                    last = last.next;

                //  Change the next of last node 
                last.next = new_node;

                return last.data;
            }

            public LinkedList zipLists(LinkedList L1, LinkedList L2)
            {
                LinkedList zippedList = new LinkedList();

                Node head1 = L1.head;
                Node head2 = L2.head;

                int tempData;

                while (head1 != null || head2 != null)
                {

                    if (head1 != null)
                    {
                        tempData = head1.data;

                        zippedList.append(tempData);
                        head1 = head1.next;
                    }


                    else if (head2 != null)
                    {
                        tempData = head2.data;
                        zippedList.append(tempData);
                        head2 = head2.next;

                    }
                }

                return zippedList;
            }

            public void toString()
            {

                Node tmp = head;
                while (tmp != null)
                {
                    Console.Write($"{tmp.data} -> ");

                    tmp = tmp.next;

                }
                Console.Write("NULL");

            }



            static void main(string[] args)
            {

                LinkedList L = new LinkedList();
                LinkedList L1 = new LinkedList();
                LinkedList L2 = new LinkedList();

                L1.append(33);
                L1.append(23);
                L1.append(77);

                L2.append(32);
                L2.append(56);
                L2.append(12);


                L.zipLists(L1,L2);

                L.toString();
               
                

            }
        }
    }
}

   

    
