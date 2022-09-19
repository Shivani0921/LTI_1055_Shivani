using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One Dimentional Array
            int[] ar = new int[5];
            ar[0] = 10;
            ar[1] = 20;
            ar[2] = 30;
            ar[3] = 40;
            ar[4] = 50;

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
            //Multidimensional array
            int[,] mar = new int[3, 4];

            //row 1
            mar[0, 0] = 10;
            mar[0, 1] = 20;
            mar[0, 2] = 30;
            mar[0, 3] = 40;

            //row 2
            mar[1, 0] = 11;
            mar[1, 1] = 12;
            mar[1, 2] = 10;
            mar[1, 3] = 14;

            //row 3
            mar[2, 0] = 34;
            mar[2, 1] = 44;
            mar[2, 2] = 35;
            mar[2, 3] = 43;

            for (int i = 0; i < mar.GetLength(0); i++)
            {
                for (int j = 0; j < mar.GetLength(1); j++)
                {
                    Console.Write($"{mar[i, j]}  ");
                }
                Console.WriteLine(); //Goto next line
            }
            Console.WriteLine($"Total items : {mar.Length}");
            Console.WriteLine($"No of rows :{mar.GetLength(0)}");
            Console.WriteLine($"No of columns:{mar.GetLength(1)}");

            //jagged array
            int [][] jar = new int[3][];
            jar[0] = new int[] { 10, 20, 30, 40, 50, 60 };
            jar[1] = new int[] { 100, 200, 300 };
            jar[2] = new int[] { 40, 34, 50 };

            Console.WriteLine($"Length of JAR:{jar.Length}");
            Console.WriteLine($"First row length:{jar[0].Length}");
            Console.WriteLine($"Second row length:{jar[1].Length}");
            Console.WriteLine($"Third row length:{jar[2].Length}");

            for (int i = 0; i < jar.Length; i++)
            {
                for (int j = 0; j < jar.Length; j++)
                {
                    Console.Write($"{jar[i][j]}  ");
                }
                Console.WriteLine(); //Goto next line
            }
            Console.ReadKey();


        }
    }
}
