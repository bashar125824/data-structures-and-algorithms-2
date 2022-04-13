using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    public class Program
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

                catch (NullReferenceException) {
                    Console.WriteLine(" You are Popping an empty Stack ! ");
                    return 0;
                }




            }

            public int Peek() {

                try
                {
                    return top.value;
                }
                catch (NullReferenceException) {

                    Console.WriteLine(" The Stack is empty ! , there is no Peak value .. ");
                    return 0;
                }

            }

            public bool isEmpty() {

                return top == null;
            }


        }
    

        public class Queue {

            public Node front { get; set; }
            public Node back { get; set; }

            public void Enqueue(int value){

                Node node = new Node(value);


                // Check if the queue is Empty
                if (back == null)
                {
                    front = back = node;
                   
                    return;
                }

                // if the queue is not empty

                back.next = node;
                back = node;
            }

            public int Dequeue() {
                try
                {
                    if (front == null) { }
                    Node temp = front;
                    front = front.next;

                    // If front becomes NULL,
                    // then change back also as NULL
                    if (front == null)
                        back = null;
                    return temp.value;

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine(" You are Dequq an empty Queue !");
                    return 0;
                }
           
            }
               
            

            public int Peek() {

                try
                {
                    return front.value;
                }

                catch (NullReferenceException){
                    Console.WriteLine(" The Stack is empty ! , there is no Peak value .. ");
                    return 0;
                }
            }

            public bool isEmpty() {

                return front == null;
            
            }

        }

        static void main(string[] args)
        {

    

        }
    }
}
    
