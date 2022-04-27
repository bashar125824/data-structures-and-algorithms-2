using System;
using Xunit;
using tree;

namespace Tree
{
    public class UnitTest1
    {

        tree.Tree.BinaryTree testTree = new tree.Tree.BinaryTree();

        tree.Tree.BinarySearchTree testSearchTree = new tree.Tree.BinarySearchTree();


        [Fact]
        public void Test1_Instantiate_an_Empty_Tree()
        {
            Assert.Null(testTree.root);

        }

        [Fact]
        public void Test2_Instantiate_Empty_Tree_with_Single_Root()
        {
            testTree.root = new tree.Tree.Node(76);
            Assert.NotNull(testTree.root);
        }

        [Fact]
        public void Test3_PreOrder()
        {
            testTree.root = new tree.Tree.Node(3);
            testTree.root.left = new tree.Tree.Node(6);
            testTree.root.right = new tree.Tree.Node(5);
            testTree.root.left.left = new tree.Tree.Node(1);
            testTree.root.left.right = new tree.Tree.Node(2);
            int[] testArr = { 3, 6, 1, 2, 5 };

            for (int i = 0; i < testArr.Length; i++)
            {
                Console.Write(testArr[i] + " ");
            }
            Assert.Equal(testArr, testTree.preOrder(testTree.root));
        }

        [Fact]
        public void Test4_inOrder()
        {
            testTree.root = new tree.Tree.Node(3);
            testTree.root.left = new tree.Tree.Node(6);
            testTree.root.right = new tree.Tree.Node(5);
            testTree.root.left.left = new tree.Tree.Node(1);
            testTree.root.left.right = new tree.Tree.Node(2);
            int[] testArr = { 1, 6, 2, 3, 5 };

            for (int i = 0; i < testArr.Length; i++)
            {
                Console.Write(testArr[i] + " ");
            }
            Assert.Equal(testArr, testTree.inOrder(testTree.root));
        }

        [Fact]
        public void Test5_preOrder()
        {
            testTree.root = new tree.Tree.Node(3);
            testTree.root.left = new tree.Tree.Node(6);
            testTree.root.right = new tree.Tree.Node(5);
            testTree.root.left.left = new tree.Tree.Node(1);
            testTree.root.left.right = new tree.Tree.Node(2);
            int[] testArr = { 3, 6, 1, 2, 5 };

            for (int i = 0; i < testArr.Length; i++)
            {
                Console.Write(testArr[i] + " ");
            }
            Assert.Equal(testArr, testTree.preOrder(testTree.root));
        }

        [Fact]
        public void Test6_Contains_True()
        {

            testSearchTree.Add(11);
            Assert.True(testSearchTree.Contains(11));
        }
        [Fact]
        public void Test_Binary_Search_Tree_Contains_False()
        {

            testSearchTree.Add(455);
            Assert.False(testSearchTree.Contains(455));
        }
    }
}
