using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcasting - convert from lower type to upper type.
            short s = 125;
            int i = s; //Convert short to int
            long l = i; // Convert int to long



            float f = 10.40f;
            double d = f; //Convert float to double



            float g = i; //Converting integer to float



            //Downcasting - Convert from large type to small
            long h = 12345;
            int k = (int)h; //explicit conversion required
            short st = (short)k; // explicitly converting to short



            float ff = 56.50f;
            int it = (int)ff;

            //String to number conversion
            string str = "125";
            int num = Convert.ToInt32(str);
            short sh = Convert.ToInt16(str);
            long lg = Convert.ToInt64(str);
            float n1 = Convert.ToSingle(str);
            double dd = Convert.ToDouble(str);
            decimal dec = Convert.ToDecimal(str);

            //Boxing and unboxing
            //Boxing - a type of upcasting and converting from value type to object type. No need for explicit casting
            object data1 = 10; //Storing integer to object
            object data3 = true; //Storing boolean to object
            object data4 = 55.64f; //Storing float to object
            object data5 = 1234.76m; // Storing decimal to object



            //Unboxing - a type of downcasting and converting object back to value type. Explicit casting required.
            int num1 = (int)data1;
            float f1 = (float)data4;
            bool b1 = (bool)data3;

            //Nullable types
            //Nullable<double> d5 = null;
            double? d5 = null; //shortcut syntax



            double? val = GetMyValue();
            if (val.HasValue)
            {
                Console.WriteLine($"Value of double is {val.Value}");
            }
            else
            {
                Console.WriteLine("Null is returned");
            }
            Console.ReadKey();
        }

            //this function may return a double value or null
            static double? GetMyValue()
            {
                return 65959.00;
                //return null;
            }

        }
    }
