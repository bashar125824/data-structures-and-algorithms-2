using System;
using Xunit;
using Insertoins;

namespace Test
{
    public class linked_list_insertions
    {
        [Fact]
        public void Test1()
        {
            Insertoins.linked_list_insertions.linkedList l = new Insertoins.linked_list_insertions.linkedList();

            Insertoins.linked_list_insertions.Node n = new Insertoins.linked_list_insertions.Node(55);

            n.next = null;

            Assert.Equal(n , l.append(55));
        }

     
    }
}
