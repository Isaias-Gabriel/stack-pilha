using System;
using FirstConsoleApplication.StackNamespace;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack firstStack = new Stack();

            firstStack.Push(value: 7);
            // firstStack.GetTopElement();

            firstStack.Push(value: 6);
            // firstStack.GetTopElement();

            firstStack.Push(value: 1);
            // firstStack.GetTopElement();

            firstStack.Push(value: 29);

            firstStack.ListElements();

            firstStack.Pop();

            Console.WriteLine("Top element removed");

            firstStack.ListElements();
        }
    }
}
