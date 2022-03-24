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