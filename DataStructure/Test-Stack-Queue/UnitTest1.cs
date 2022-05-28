using System;
using Xunit;
using stack_and_queue;

namespace Test_Stack_Queue
{
    public class Program
    {
        [Fact]
        public void Test1_Push_Into_Stack()
        { 
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            S.Push(3);

            Assert.False(S.isEmpty());
          
        }

        [Fact]
        public void Test2_Push_Multiple_Into_Stack()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            S.Push(3);
            S.Push(2);
            S.Push(5);

            Assert.False(S.isEmpty());
        }

        [Fact]
        public void Test3_Pop_From_Stack()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            S.Push(3);

            S.Pop();

            Assert.True(S.isEmpty());
        }

        [Fact]
        public void Test4_Pop_Multiple_From_Stack()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            S.Push(3);
            S.Push(6);
            S.Push(9);

            S.Pop();
            S.Pop();
            S.Pop();

            Assert.True(S.isEmpty());

        }


        [Fact]
        public void Test5_Peek_Stack()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            S.Push(3);
            S.Push(6);
            S.Push(9);
           

            Assert.Equal(9, S.Peek());
        }

        [Fact]
        public void Test6_Instantiate_Empty_Stack()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();
           
            Assert.True(S.isEmpty());
        }

        [Fact]
        public void Test7_Raise_An_Exception_On_Pop()
        {
            stack_and_queue.Program.Stack S = new stack_and_queue.Program.Stack();

            // I handled the exception then return 0
            Assert.Equal(0 , S.Pop());

        }

        [Fact]
        public void Test8_Enqueue_Into_Queue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            Q.Enqueue(4);

            Assert.False(Q.isEmpty());

        }

        [Fact]
        public void Test9_Enqueue_Multiple_Into_Queue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            Q.Enqueue(4);
            Q.Enqueue(5);
            Q.Enqueue(3);

            Assert.False(Q.isEmpty());

        }

        [Fact]
        public void Test10_Dequeue_From_Queue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            Q.Enqueue(4);

            Q.Dequeue();

            Assert.True(Q.isEmpty());

        }

        [Fact]
        public void Test11_Peek_Queue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            // front of the queue
            Q.Enqueue(4);
            //
            Q.Enqueue(77);
            Q.Enqueue(6);

            // Should equal 4 
            Assert.Equal(4 , Q.Peek());

        }

        [Fact]
        public void Test12_Empty_Queue_After_Multiple_Dequeues()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            Q.Enqueue(4);
            Q.Enqueue(77);
            Q.Enqueue(6);

            Q.Dequeue(); 
            Q.Dequeue();
            Q.Dequeue();

            Assert.True(Q.isEmpty());

        }

        [Fact]
        public void Test13_Instantiate_Empty_Queue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();

            Assert.True(Q.isEmpty());

        }

        [Fact]
        public void Test14_Raise_An_Exception_On_Dequeue()
        {
            stack_and_queue.Program.Queue Q = new stack_and_queue.Program.Queue();
           

            Assert.Equal(0, Q.Dequeue());

        }
    }
}
