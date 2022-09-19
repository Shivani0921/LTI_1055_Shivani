using System;
using System.Collections;

namespace Non_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            //int[] myarray=new int[3];
            myList.Add(12);
            myList.Add(25.8m);
            myList.Add(3.407f);
            myList.Add(Math.PI);
            myList.Add("L and T");
            myList.Add(DateTime.Now);

            //this is a process called boxing
            //value type or any type converted to object type
            foreach (var obj in myList)
            {
                Console.WriteLine(obj);
            }
            //unboxing process is going on in foreach
            //object type to its original value type conversion means boxing
            
            // implicitly typed variable  var   condition is it must get initial value
            var x = 10;// int
            var y = 3.45;// double
            var name = "sarita";
            x = 'a';  // single char means inside it is ASCII code int a=97
                      //   x = "sarita";not allowed
            x = (int)7.5;
        }
    }
}
