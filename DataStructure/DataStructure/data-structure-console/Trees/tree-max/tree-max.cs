using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxTree
{
    public class tree_max
    {
        // I used Binary tree and Node classes that I implement it in previous CC
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

            public int findMax()
            {

                

                int res = root.data;
                var q = new Queue();
                q.Enqueue(root);

                while (q.Count != 0)
                {
                    Node n = (Node)q.Peek();
                    if (n.left != null)
                    {
                        q.Enqueue(n.left);
                    }
                    if (n.right != null)
                    {
                        q.Enqueue(n.right);
                    }
                    if (n.data > res)
                    {
                        res = n.data;
                    }
                    q.Dequeue();
                }
                return res;


            }
        }
            
    }
}
