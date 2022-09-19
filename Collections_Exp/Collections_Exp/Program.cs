using System;
using System.Collections;

namespace Collections_Exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList myList = new ArrayList();
            Stack mystack = new Stack();
            //mystack.Push(12);
            //mystack.Push("LTI");
            //mystack.Push(12.89f);
            //try
            //{
            //    //Peek() only reads the value and pop reads and removes the value
            //    Console.WriteLine(mystack.Peek());
            //    Console.WriteLine(mystack.Pop());
            //    Console.WriteLine(mystack.Pop());
            //    Console.WriteLine(mystack.Pop());
            //    Console.WriteLine(mystack.Pop());
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Queue myq = new Queue();
            //myq.Enqueue(123);
            //myq.Enqueue("LTI");
            //myq.Enqueue(DateTime.Now.ToShortDateString());
            //Console.WriteLine("Check if name is in Q or not :"+myq.Contains("Shivani"));

            //try
            //{
            //    Console.WriteLine(myq.Dequeue());
            //    Console.WriteLine(myq.Dequeue());
            //    Console.WriteLine(myq.Dequeue());
            //    Console.WriteLine(myq.Dequeue());

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Hashtable mytable = new Hashtable();
            mytable.Add(1, "one");
            mytable.Add(2, "two");
            mytable.Add(3, null);



        }
    }
}
