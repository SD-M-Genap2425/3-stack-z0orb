using System;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class StackNode
        {
            public char Data { get; }
            public StackNode Next { get; set; }

            public StackNode(char data)
            {
                Data = data;
                Next = null;
            }
        }

        private class Stack
        {
            private StackNode top;

            public Stack()
            {
                top = null;
            }

            public void Push(char data)
            {
                var newNode = new StackNode(data);
                newNode.Next = top;
                top = newNode;
            }

            public char Pop()
            {
                if (top == null) throw new InvalidOperationException("Stack is empty");
                var poppedNode = top;
                top = top.Next;
                return poppedNode.Data;
            }

            public bool IsEmpty()
            {
                return top == null;
            }
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            var stack = new Stack();

            foreach (var ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.IsEmpty())
                    {
                        return false; // Closing bracket without a matching opening bracket
                    }

                    var top = stack.Pop();
                    if (!IsMatchingPair(top, ch))
                    {
                        return false; // Mismatched brackets
                    }
                }
            }

            return stack.IsEmpty(); // If stack is empty, all brackets are matched
        }

        private bool IsMatchingPair(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}