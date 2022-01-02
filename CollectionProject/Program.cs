using System;
using System.Collections;

namespace CollectionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(100); //integer
            stack.Push("Hello"); //string
            stack.Push(false); //boolean
            stack.Push('A'); // character
            stack.Push(3.14f); //float

            foreach (object obj in stack)
                Console.Write(obj + " ");
            Console.WriteLine();

            //Pop example
            Console.WriteLine(stack.Pop());//removes and return the top most value
            foreach (object obj in stack)
                Console.Write(obj + " ");
            Console.WriteLine();

            //Peek example
            Console.WriteLine(stack.Peek());//the top most value without removing it.
            foreach (object obj in stack)
                Console.Write(obj + " ");
            Console.WriteLine();

            //count
            Console.WriteLine("Total Count: " + stack.Count);//total count
            
            stack.Clear();

            Console.WriteLine(stack.Count);

            Console.ReadLine();
        }
    }
}
