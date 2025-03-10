using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ArrayList_DictionaryImplementation
    {

        public void ArrayListImplementation()
        {
            Console.Write("--------ArrayList Implementation---------");
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Puppies");
            arrayList.Add("Kittens");
            arrayList.Add("Birds");

            IEnumerator em = arrayList.GetEnumerator();
            while(em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }
            int count = arrayList.Count;
            Console.WriteLine("The count of elements in the ArrayList is : " + count);

            Console.WriteLine("Removing element at 2 in ArrayList");
            arrayList.RemoveAt(2);
            int Updatedcount = arrayList.Count;
            Console.WriteLine("The count of elements in the ArrayList is : " + Updatedcount);

            Console.WriteLine("Printing the elements in ArrayList after removing and inserting: ");
            arrayList.Insert(1, "Fishes");
            arrayList.Insert(2, "Plants");

           
            em = arrayList.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }

            arrayList.Sort();
            arrayList.Reverse();

            Console.WriteLine("Printing the elements in ArrayList after sorting and Reversing: ");
            em = arrayList.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }

        }

        public void DictionaryImplementation()
        {
            Console.WriteLine("-------Dictionary Implementation---------");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "C");
            dictionary.Add(2, "C++");
            dictionary.Add(3, "JAVA");
            
            foreach(var ele in dictionary)
            {
                Console.WriteLine("Key : " + ele.Key + " Value : " + ele.Value);
            }

            Console.WriteLine("The count of elements in dictionary : " + dictionary.Count);

            

            dictionary.Add(dictionary.Count + 1, "C#");
            dictionary.Add(dictionary.Count + 1, "Python");

            dictionary.Remove(1);

            Console.WriteLine("The count of elements in dictionary after adding and removing : " + dictionary.Count);
            foreach (var ele in dictionary)
            {
                Console.WriteLine("Key : " + ele.Key + " Value : " + ele.Value);
            }

            if (dictionary.ContainsKey(3))
            {
                Console.WriteLine("The value in key {0} is {1}", 3, dictionary[3]);
            }
            else
            {
                Console.WriteLine("The key is not present in the dictionary");
            }

            if (dictionary.ContainsValue("Python"))
            {
                Console.WriteLine("The value is present in the dictionary");
            }
            else
            {
                Console.WriteLine("The value is not present in the dictionary");
            }

        }
    }
}
