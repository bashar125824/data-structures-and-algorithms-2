using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace kth_test
{
    public class linked_list_kth

    {
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

        public class LinkedList
        {
            Node head;

            public int kthNode(int k)
            {

                try
                {

                    int count = 0;

                    if (k < 0)
                    {
                        throw new Exception(" K is less than 0 ..");
                    }
                    else
                    {
                        Node current = head;
                        for (int i = 1; i < count - k; i++)
                        {
                            current = current.next;
                        }

                        return current.data;
                    }

                }


                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return 0;
                }
            }

            public void Insert(int new_data)
            {

                /* 1. alloc the Node and put data*/
                Node new_Node = new Node(new_data);

                /* 2. Make next of new Node as head */
                new_Node.next = head;

                /* 3. Move the head to point to new Node */
                head = new_Node;
            }





        }

        static void Main(string[] args)
        {




        }


    }
}


