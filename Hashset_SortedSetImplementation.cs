using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Hashset_SortedSetImplementation
    {
        //unorded collection of unique elements
        public void HashSetImplementation()
        {
            Console.WriteLine("--------HashSet Implementation--------");
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Mountains");
            hashSet.Add("Rivers");
            hashSet.Add("Oceans");

            IEnumerator<string> em = hashSet.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }

            Console.WriteLine("The number of elements in hashset is :" + hashSet.Count);
            Console.WriteLine("The element at index of 2 is {0}", hashSet.ElementAt(2));
            hashSet.Remove("Rivers");
            hashSet.Add("Ponds");
            hashSet.Add("Sea");
            //Doesn't add one more value sea in the set since it allows only unique elements
            // hashSet.Add("Sea");
            Console.WriteLine("The number of elements in hashset after adding & removing is :" + hashSet.Count);

            em = hashSet.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }
            hashSet.Clear();
            Console.WriteLine("After clearing a hashset, the number of elements in hashset is :" + hashSet.Count);
        }

        public void SortedSetImplementation()
        {
            Console.WriteLine("--------SortedSet Implementation----------");
            //Ordered set of unique elements
            SortedSet<string> sortedSet = new SortedSet<string>();
            sortedSet.Add("Integers");
            sortedSet.Add("Whole Numbers");
            sortedSet.Add("Rational numbers");

            Console.WriteLine("The count of elements in sortedSet is : " + sortedSet.Count);

            IEnumerator<string> em = sortedSet.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }
            Console.WriteLine("The element at index 2 is {0}", sortedSet.ElementAt(2));
            sortedSet.Add("Even numbers");
            sortedSet.Add("Odd Numbers");
            sortedSet.RemoveWhere(x => x.Contains("Rational"));
            Console.WriteLine("The count of elements in sortedSet after adding, removing is : " + sortedSet.Count);
            sortedSet.Reverse();
            foreach (var k in sortedSet)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Copying the elements of sortedSet to an array :");
            string[] arr = new string[sortedSet.Count];
            sortedSet.CopyTo(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element in index " + i + " is : " + arr[i]);
            }

        }
        

    }
}
