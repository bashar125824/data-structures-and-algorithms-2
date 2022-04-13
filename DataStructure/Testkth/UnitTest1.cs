using System;
using Xunit;
using kth_test;

namespace Testkth
{
    public class linked_list_kth
    {
        [Fact]
        public void Test1_k_Greater_than_length()
        {

            kth_test.linked_list_kth.LinkedList l = new kth_test.linked_list_kth.LinkedList();

            l.push(1);
            l.push(2);
            l.push(3);

            Assert.Equal(0 , l.kthNode(4));

        }

        [Fact]
        public void Test2_k_equal_length()
        {

            kth_test.linked_list_kth.LinkedList l = new kth_test.linked_list_kth.LinkedList();

            l.push(1);
            l.push(2);
            l.push(3);

            Assert.Equal(0, l.kthNode(3));

        }

        [Fact]
        public void Test3_length_of_link_list_equal_1()
        {

            kth_test.linked_list_kth.LinkedList l = new kth_test.linked_list_kth.LinkedList();

           
            l.push(3);

            Assert.NotEqual(1 , l.kthNode(3));

        }
    }
}
