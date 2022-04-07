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
               Node h = head;
               Node n = null;
                Node curr = head;
               while(h!=null)
               {
                  Node tmp = h.next;
                  h.next = n;
                  n = h;
                  h = tmp;
                  head = n;
                  curr = head;
                }
                  int x = 0;
                  while(curr != null)
                   {
                        if(x == k)
                        {
                          return curr.data;
                        }

                        x++;
                        curr = curr.next;
                    }
                    return 0;


               }

            }

        }

    }

    

