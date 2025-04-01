using System;
using System.Text.RegularExpressions;

namespace Solution.Palindrome;

public static class PalindromeChecker
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
            if (top == null) throw new InvalidOperationException("Stack kosong");
            var poppedNode = top;
            top = top.Next;
            return poppedNode.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public static bool CekPalindrom(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return true;
        }

        
        var normalizedInput = Regex.Replace(input, "[^a-zA-Z0-9]", "").ToLower();

        
        var stack = new Stack();
        int length = normalizedInput.Length;

    
        for (int i = 0; i < length / 2; i++)
        {
            stack.Push(normalizedInput[i]);
        }

        
        int startIndex = (length % 2 == 0) ? length / 2 : (length / 2) + 1;

        
        for (int i = startIndex; i < length; i++)
        {
            if (stack.IsEmpty() || stack.Pop() != normalizedInput[i])
            {
                return false;
            }
        }

        return stack.IsEmpty(); 
    }
}