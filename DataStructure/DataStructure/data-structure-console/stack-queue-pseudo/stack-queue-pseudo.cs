using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pseudo
{
    public class stack_queue_pseudo
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
        }

        public class Stack
        {
            public Node top { get; set; }

            public void Push(int value)
            {

                Node node = new Node(value);
                node.next = top;
                top = node;


            }

            public int Pop()
            {

                try
                {
                    Node temp = top;
                    top = top.next;
                    temp.next = null;
                    return temp.value;
                }

                catch (NullReferenceException)
                {
                    Console.WriteLine(" You are Popping an empty Stack ! ");
                    return 0;
                }




            }

            public int Peek()
            {

                try
                {
                    return top.value;
                }
                catch (NullReferenceException)
                {

                    Console.WriteLine(" The Stack is empty ! , there is no Peak value .. ");
                    return 0;
                }

            }


        }
        public class pseudo_queue : Stack
        {
            // I will use two stacks to implement Enqueue & Dequeue methods

            Stack s1 = new Stack();
            Stack s2 = new Stack();
            public void Enqueue(int value)
            {

                s1.Push(value);
            }

            public int Dequeue()
            {

                int x, y;

                while (s1.top != null)
                {
                    // take an element out of first stack
                    x = s1.Pop();
                    // insert it into the second stack
                    s2.Push(x);
                }

                // removing the element
                y = s2.Pop();

                // moving back the elements to the first stack
                while (s2.top != null)
                {
                    x = s2.Pop();
                    s1.Push(x);
                }

                return y;
            }


        }

    }
}  
                

            
        
    

