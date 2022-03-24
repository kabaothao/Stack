// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();

            //push 3 items 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //peek at an item. return the object at the top of the Stack without removing it. 
            Console.WriteLine("Peek 1 : {0}", stack.Peek());

            //remove an item. is used to remove and returns the object at the top of the Stack. This method is similar to the Peek method, but Peek does not modify the Stack.
            Console.WriteLine("Pop 1 : {0}", stack.Pop());

            Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(String.Join(", ", numArray2));

            stack.Clear();




            foreach (object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }

        }
    }
}


/*
 Stack - how it works is it's a last in first out collection

Output should show:
Stack : 3
Stack : 2
Stack : 1

 */