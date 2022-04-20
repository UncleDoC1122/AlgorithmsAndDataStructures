using System;
using AlgorithmsAndDataStructuresCourse.DataStructures;

namespace AlgorithmsAndDataStructuresCourse.Playground
{
    public static class StackPlayground
    {
        public static void StackTest1()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Length());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Length());
            Console.WriteLine(stack.Peek());
        }
    }
}