using System;
using Xunit;
using Insertoins;

namespace Test
{
    public class linked_list_insertions
    {
        [Fact]
        public void Test1_append()
        {
            Insertoins.linked_list_insertions.linkedList l = new Insertoins.linked_list_insertions.linkedList();

            Insertoins.linked_list_insertions.Node n = new Insertoins.linked_list_insertions.Node(55);

            Assert.Equal(55 , l.append(n.value));
        }


        [Fact]
        public void Test2_append()
        {
            Insertoins.linked_list_insertions.linkedList l = new Insertoins.linked_list_insertions.linkedList();

            Insertoins.linked_list_insertions.Node n = new Insertoins.linked_list_insertions.Node(89);

            Assert.Equal(89, l.append(n.value));
        }

       
       
        [Fact]
        public void Test4_insertAfter()
        {
            Insertoins.linked_list_insertions.linkedList l = new Insertoins.linked_list_insertions.linkedList();

            Insertoins.linked_list_insertions.Node n = new Insertoins.linked_list_insertions.Node(22);

            Assert.Equal(22, l.insertAfter(89, n.value));
        }

    }
}
