using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace allCode
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


        };
        public class linkedList
        {

            public Node head;

            public linkedList()
            {
                
            }
            public int Insert(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
                return new_data;
            }

            public  bool Include(int new_data)
            {
                Node current = head; // Initialize current
                while (current != null)
                {
                    if (current.value == new_data)
                        return true; // data found
                    current = current.next;
                }
                return false; // data not found


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

        };
       

            static void Main(string[] args)
            {
                // Test 1
                linkedList MyList = new linkedList();

                // Test 2
                MyList.Insert(100);

                // Test 3
                MyList.Insert(23);
                MyList.Insert(223);
                MyList.Insert(888);

                // Test 4  , Should return Yes
                if (MyList.Include(23))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");


                // Test 5  , Should return No
                if (MyList.Include(66))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

                // Test 6
                MyList.toString();


            }

        }
    }


