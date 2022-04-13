using System;
using Xunit;
using pseudo;

namespace stack_queue_pseudo
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Enqueue()
        {
            pseudo.stack_queue_pseudo.pseudo_queue s = new pseudo.stack_queue_pseudo.pseudo_queue();

            s.Enqueue(5);

            Assert.NotNull(s);

        }

        [Fact]
        public void Test_Dequeue()
        {
            pseudo.stack_queue_pseudo.pseudo_queue s = new pseudo.stack_queue_pseudo.pseudo_queue();

            s.Enqueue(5);
            s.Enqueue(4);
            int test = s.Dequeue();
           
            Assert.Equal(5 , test);
        }
    }
}
