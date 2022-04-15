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


            public LinkedList zipLists(LinkedList L1, LinkedList L2)
            {

                Node nodeBefore = L1.head;
                Node nodeCurrent = L2.head;
                Node nodeAfter;
                // Checks if list1 is empty.
                if (nodeBefore == null)
                {
                    nodeAfter = null;
                    nodeCurrent = null;
                    L1.head = L2.head;
                }
                else
                {
                    nodeAfter = nodeBefore.next;
                }
                // Zipping 
                while (nodeCurrent != null)
                {
                    // Adjust the pointer.
                    nodeBefore.next = nodeCurrent;
                    // Shift the pointers.
                    nodeBefore = nodeCurrent;
                    nodeCurrent = nodeAfter;
                    nodeAfter = nodeBefore.next;
                }
                // Empty L2 , becuase there is no need to use it
                L2.head = null;
                // Return L1 after zipping it.
                return L1;

            }




            static void main(string[] args)
            {




            }
        }
    }
}




