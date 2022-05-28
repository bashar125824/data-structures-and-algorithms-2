using System;
using Xunit;
using maxTree;

namespace tree_max
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_Max_Of_Tree()
        {
            maxTree.tree_max.BinaryTree testTree = new maxTree.tree_max.BinaryTree();
            testTree.root = new maxTree.tree_max.Node(1);
            testTree.root.left = new maxTree.tree_max.Node(3);
            testTree.root.right = new maxTree.tree_max.Node(16);
            testTree.root.left.left = new maxTree.tree_max.Node(5);
            testTree.root.left.right = new maxTree.tree_max.Node(6);
            Assert.Equal(16 , testTree.findMax());

        }
    }
}
