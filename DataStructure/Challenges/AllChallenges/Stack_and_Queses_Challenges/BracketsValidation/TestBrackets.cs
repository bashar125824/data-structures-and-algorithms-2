using System;
using Xunit;
using stack_queue_brackets;

namespace Test_Brackets
{
    public class Brackets
    {
        [Fact]
        public void Test1()
        {
            string s_test = "{";
            Assert.False(stack_queue_brackets.Brackets.validateBrackets(s_test));
        }
        [Fact]
        public void Test2()
        {
            string s_test2 = "[({]";
            Assert.False(stack_queue_brackets.Brackets.validateBrackets(s_test2));
        }

        //[Fact]
        //public void Test3()
        //{
        //    string s_test3 = "(){}[[]]";
        //    Assert.True(stack_queue_brackets.Brackets.validateBrackets(s_test3));
        //}

        [Fact]
        public void Test4()
        {
            string s_test4 = "()[[Extra Characters]]";
            Assert.False(stack_queue_brackets.Brackets.validateBrackets(s_test4));
        }

    }
}
