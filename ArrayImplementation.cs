using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ArrayImplementation
    {
        string[] arrayOfStrings = new string[4];

        public ArrayImplementation()
        {
            arrayOfStrings[0] = "Functional testing";
            arrayOfStrings[1] = "Automation Testing";
            arrayOfStrings[2] = "API Automation Testing";
            arrayOfStrings[3] = "Database testing";
        }
        public void ArrayImplementationMethod()
        {
            try
            {
                Console.WriteLine("-------Array Implementation---------");
                //Basic Arrays
                string[] array2 = new string[] { "Manimekala", "Automation", "EPAM", "February" };

                Console.WriteLine("Printing elements of \'arrayOfStrings\' :");
                foreach (var i in arrayOfStrings)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Printing elements of \'array2\' with index:");
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine("String in Index " + i + ": is " + array2[i]);
                }

                //Resizing an array 
                Console.WriteLine("Resizing arrayOfStrings array from 4 to 6 :");
                Array.Resize(ref arrayOfStrings, 6);
                arrayOfStrings[4] = "Smoke Testing";
                arrayOfStrings[5] = "Regression Testing";

                foreach (var i in arrayOfStrings)
                {
                    Console.WriteLine(i);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void HandlingMultiDimensionArray()
        {
            int[,] multi = { { 0,1},{3,4 },{6,7 } };
            for(int i = 0; i < multi.GetLength(0); i++)
            {
                for(int j = 0; j < multi.GetLength(1); j++)
                {
                    Console.WriteLine("Row i :" + i + " column : " + j + " value : " + multi[i, j]);
                }            
            }
              
        }

        public void SortingArrays()
        {
            int[] a = { 100, 54, 77, 54, 43 };
            Console.WriteLine("Before Sorting Array:");
            foreach (var j in a)
            {
                Console.WriteLine(j);
            }
            Array.Sort(a);
            Console.WriteLine("After Sorting Array:");
            foreach (var j in a)
            {
                Console.WriteLine(j);
            }

        }
    }
}
