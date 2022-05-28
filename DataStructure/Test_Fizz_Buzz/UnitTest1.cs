using System;
using Xunit;
using tree_fizz_buzz;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test_Fizz()
        {
            tree_fizz_buzz.Tree.Node node_1 = new Tree.Node(9);
            tree_fizz_buzz.Tree.Node node_2 = new Tree.Node(99);
            tree_fizz_buzz.Tree.Node node_3 = new Tree.Node(5);
            tree_fizz_buzz.Tree.Node node_4 = new Tree.Node(21);
            tree_fizz_buzz.Tree.Node node_5 = new Tree.Node(3);
            tree_fizz_buzz.Tree.Node node_6 = new Tree.Node(97);
            tree_fizz_buzz.Tree.BinaryTree FB = new Tree.BinaryTree();
            FB.root = new Tree.Node(3);
            FB.root.left = node_1;
            FB.root.left.left = node_2;
            FB.root.left.right = node_3;
            FB.root.right = node_4;
            FB.root.right.left = node_5;
            FB.root.right.right = node_6;
            List<string> L = new List<string>() { " Fizz " };
            Assert.Equal(L , FB.FizzBuzz(FB.root));
        }
        [Fact]
        public void Test_Buzz()
        {

        tree_fizz_buzz.Tree.Node node_1 = new Tree.Node(9);
        tree_fizz_buzz.Tree.Node node_2 = new Tree.Node(99);
        tree_fizz_buzz.Tree.Node node_3 = new Tree.Node(5);
        tree_fizz_buzz.Tree.Node node_4 = new Tree.Node(21);
        tree_fizz_buzz.Tree.Node node_5 = new Tree.Node(3);
        tree_fizz_buzz.Tree.Node node_6 = new Tree.Node(97);
        tree_fizz_buzz.Tree.BinaryTree FB = new Tree.BinaryTree();
        FB.root = new Tree.Node(5);
            FB.root.left = node_1;
            FB.root.left.left = node_2;
            FB.root.left.right = node_3;
            FB.root.right = node_4;
            FB.root.right.left = node_5;
            FB.root.right.right = node_6;
            List<string> L = new List<string>() { " Buzz " };
        Assert.Equal(L, FB.FizzBuzz(FB.root));
        }

        [Fact]
        public void Test_Fizz_Buzz()
        {

            tree_fizz_buzz.Tree.Node node_1 = new Tree.Node(9);
            tree_fizz_buzz.Tree.Node node_2 = new Tree.Node(99);
            tree_fizz_buzz.Tree.Node node_3 = new Tree.Node(5);
            tree_fizz_buzz.Tree.Node node_4 = new Tree.Node(21);
            tree_fizz_buzz.Tree.Node node_5 = new Tree.Node(3);
            tree_fizz_buzz.Tree.Node node_6 = new Tree.Node(97);
            tree_fizz_buzz.Tree.BinaryTree FB = new Tree.BinaryTree();
            FB.root = new Tree.Node(60);
            FB.root.left = node_1;
            FB.root.left.left = node_2;
            FB.root.left.right = node_3;
            FB.root.right = node_4;
            FB.root.right.left = node_5;
            FB.root.right.right = node_6;
            List<string> L = new List<string>() { " FizzBuzz " };
            Assert.Equal(L, FB.FizzBuzz(FB.root));
        }

        [Fact]
        public void Test_Not_Fizz_and_Not_Buzz()
        {

            tree_fizz_buzz.Tree.Node node_1 = new Tree.Node(9);
            tree_fizz_buzz.Tree.Node node_2 = new Tree.Node(99);
            tree_fizz_buzz.Tree.Node node_3 = new Tree.Node(5);
            tree_fizz_buzz.Tree.Node node_4 = new Tree.Node(21);
            tree_fizz_buzz.Tree.Node node_5 = new Tree.Node(3);
            tree_fizz_buzz.Tree.Node node_6 = new Tree.Node(97);
            tree_fizz_buzz.Tree.BinaryTree FB = new Tree.BinaryTree();
            FB.root = new Tree.Node(1);
            FB.root.left = node_1;
            FB.root.left.left = node_2;
            FB.root.left.right = node_3;
            FB.root.right = node_4;
            FB.root.right.left = node_5;
            FB.root.right.right = node_6;
            List<string> L = new List<string>() { " 1 " };
            Assert.Equal(L, FB.FizzBuzz(FB.root));
        }

        [Fact]
        public void Test_Empty_Tree()
        {
            tree_fizz_buzz.Tree.BinarySearchTree test_tree = new tree_fizz_buzz.Tree.BinarySearchTree();
            Exception E = Assert.Throws<Exception>(() => test_tree.FizzBuzzTree(test_tree));
            Assert.Equal(" Empty Tree ! ", E.Message);

        }
    }
}
