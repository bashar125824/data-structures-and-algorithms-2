using System;
using Xunit;
using tree;
using System.Collections.Generic;

namespace Breadth_First
{
    public class UnitTest1
    {

        [Fact]
        public void Test1_Empty_Tree()
        {

            tree.Tree.BinarySearchTree tree = new tree.Tree.BinarySearchTree();
            Exception E = Assert.Throws<Exception>(() => tree.Breadth(tree));
            Assert.Equal(" Tree is Empty ! ", E.Message);

        }


        [Fact]
        public void Test2()
        {

            // Test the example given in Canvas 
            tree.Tree.BinarySearchTree t_Test = new Tree.BinarySearchTree();
            t_Test.root = new tree.Tree.Node(2);
            t_Test.root.left = new tree.Tree.Node(7);
            t_Test.root.right = new tree.Tree.Node(5);
            t_Test.root.left.left = new tree.Tree.Node(2);
            t_Test.root.left.right = new tree.Tree.Node(6);
            t_Test.root.left.right.left = new tree.Tree.Node(5);
            t_Test.root.left.right.right = new tree.Tree.Node(11);
            t_Test.root.right.right = new tree.Tree.Node(9);
            t_Test.root.right.right.left = new tree.Tree.Node(4);


            List<int> list = new List<int>() { 2,7,5,2,6,5,11,9,4 };

            Assert.Equal(list , t_Test.Breadth(t_Test));
        }

       
    }
}
