using System;
using Xunit;
using allCode;

namespace Test_linkedList
{
    public class Program
    {



        [Fact]
        public void Test1_instantiate()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();

            Assert.Null(l.head);
        }

        [Fact]
        public void Test2_insert()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();
           
            Assert.Equal(77, l.Insert(77));
        }

        [Fact]
        public void Test3_headPointer()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();

            l.Insert(77);

            Assert.Equal(77 , l.head.value);
        }

        [Fact]
        public void Test4_insertMultiple()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();

            Assert.Equal(32, l.Insert(32));
            Assert.Equal(11, l.Insert(11));
            Assert.Equal(21, l.Insert(21));

        }

        [Fact]
        public void Test5_returnTrue()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();

            l.Insert(8);
            l.Insert(9);
            l.Insert(10);

            Assert.True(l.Include(9));

        }

        [Fact]
        public void Test6_returnFalse()
        {
            allCode.Program.linkedList l = new allCode.Program.linkedList();

            l.Insert(8);
            l.Insert(9);
            l.Insert(10);

            Assert.False(l.Include(99));

        }

      


    }
}
