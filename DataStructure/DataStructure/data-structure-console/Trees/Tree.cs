using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
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
                            current = current.left ;
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


            // Breadth function
            public List<int> Breadth(BinaryTree T)
            {

                if (T.root == null)
                {
                    throw new Exception(" Tree is Empty ! ");
                }

                Queue<Node> Q = new Queue<Node>();
                List<int> res = new List<int>();
                Q.Enqueue(T.root);
                while (Q.Count > 0)
                {

                    Node F = Q.Peek();
                    res.Add(F.data);
                    Q.Dequeue();
                    if (F != null)
                    {
                        continue;
                    }
                    if (F.left != null)
                    {
                        Q.Enqueue(F.left);
                    }
                    if (F.right != null)
                    {
                        Q.Enqueue(F.right);
                    }
                }
                return res;

            }





        }


        static void main(string[] args)
        {

           

        }

    }
}
