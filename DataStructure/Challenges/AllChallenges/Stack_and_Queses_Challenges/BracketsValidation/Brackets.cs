using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stack_and_queue;

namespace stack_queue_brackets
{
    public class Brackets
    {
        public static bool validateBrackets(string s)
        {

            stack_and_queue.Program.Stack myStack = new stack_and_queue.Program.Stack();
            for (int i = 0; i < s.Length; i++)
            {

                char temp = s[i];
                if (temp == '{' || temp == '(' || temp == '[')
                {

                    myStack.Push(temp);

                }
                if (temp == '}' || temp == ')' || temp == ']')
                {

                    if (myStack.isEmpty()) { return false; }

                    char temp2 = (char)myStack.Peek();

                    if (temp == '(' && temp2 == ')' || temp == '{' && temp2 == '}' || temp == '[' && temp2 == ']')
                    {

                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            return myStack.isEmpty();
        }


    }
}

