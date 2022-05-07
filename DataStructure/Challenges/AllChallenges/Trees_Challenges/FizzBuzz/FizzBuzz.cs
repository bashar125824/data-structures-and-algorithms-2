using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tree;

namespace tree_fizz_buzz
{

    public class Tree
    {

        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }

        }



        public class BinaryTree
        {

            public List<int> myList = new List<int>();

            public Node root;

            public BinaryTree()
            {

                root = null;
            }
            public int[] preOrder(Node r)
            {
                if (r == null)
                {
                    throw new Exception(" Empty Tree ! ");
                }
                myList.Add(r.data);

                if (r.left != null)
                {
                    preOrder(r.left);

                }
                if (r.right != null)
                {
                    preOrder(r.right);
                }
                return myList.ToArray();
            }

            public int[] postOrder(Node r)
            {

                if (r == null)
                {
                    throw new Exception(" Empty Tree ! ");
                }
                if (r.left != null)
                {
                    postOrder(r.left);
                }
                if (r.right != null)
                {
                    postOrder(r.right);
                }
                myList.Add(r.data);
                return myList.ToArray();
            }
            public int[] inOrder(Node r)
            {

                if (r == null)
                {
                    throw new Exception(" Empty Tree ! ");
                }
                if (r.left != null)
                {
                    inOrder(r.left);
                }
                myList.Add(r.data);

                if (r.right != null)
                {
                    inOrder(r.right);
                }
                return myList.ToArray();
            }

            public void FizzBuzzTree(BinaryTree T)
            {

                FizzBuzz(T.root);
            }

            public List<string> FizzBuzz(Node N)
            {
                if (root == null)
                {
                    throw new Exception(" Empty Tree ! ");
                }

                List<string> L = new List<string>();
                if (N.data % 3 == 0 && N.data % 5 == 0)
                {
                    L.Add(" FizzBuzz ");
                    Console.WriteLine(" FizzBuzz ");
                }

                else if (N.data % 3 == 0)
                {
                    L.Add(" Fizz ");
                    Console.WriteLine(" Fizz ");
                }
                else if (N.data % 5 == 0)
                {

                    L.Add(" Buzz ");
                    Console.WriteLine(" Buzz ");
                }

                else
                {
                    L.Add($" {N.data} ");
                    Console.WriteLine($" {N.data} ");
                }
                if (N.left != null)
                {
                    FizzBuzz(N.left);
                }
                if (N.right != null)
                {
                    FizzBuzz(N.right);
                }
                return L;
            }


        }


        public class BinarySearchTree : BinaryTree
        {
            public void Add(int value)
            {
                Node parent;
                Node current;
                Node node = new Node(value);
                if (root != null)
                {
                    current = root;

                    while (true)
                    {
                        parent = current;
                        if (value < current.data)
                        {
                            current = current.left;
                            if (current == null)
                            {
                                parent.left = node;
                                break;
                            }
                        }
                        else
                        {
                            current = current.right;
                            if (current == null)
                            {
                                parent.right = node;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    root = node;
                }
            }

            public bool Contains(int value)
            {
                Node n = root;
                while (n != null)
                {
                    if (n.data == value)
                    {
                        return true;
                    }
                    if (n.data > value)
                    {
                        n = n.left;

                    }
                    else
                    {
                        n = n.right;
                    }
                }
                return false;
            }




        }

        static void Main(string[] args)
        {
            Node node_1 = new Node(5);
            Node node_2 = new Node(3);
            Node node_3 = new Node(60);
            Node node_4 = new Node(33);
            Node node_5 = new Node(77);

            BinarySearchTree FB = new BinarySearchTree();

            FB.root = new Node(1);
            FB.root.left = node_1;
            FB.root.left.left = node_2;
            FB.root.left.right = node_3;
            FB.root.right = node_4;
            FB.root.right.left = node_5;

            FB.FizzBuzzTree(FB);
        }
    }

}

