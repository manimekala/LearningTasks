using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class List_Collections_Implementation
    {
        private List<string> list1 = new List<string>();

        private LinkedList<int> linkedList1 = new LinkedList<int>();
        
        public void HandlingLists()
        {
            Console.WriteLine("-----List Implementation-------");
            list1.Add("Development");
            list1.Add("Testing");
            list1.Add("API Creation");
            list1.Add("DB creation");
            Console.WriteLine("The size of list1 : {0}", list1.Count);

            //using enumerator 
            List<string>.Enumerator em = list1.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine("Elements in list1 are :" + em.Current);
            }
            //Methods in list
            Console.WriteLine("Check index of the element \'API Mapping\' : " + list1.IndexOf("API Creation"));
            list1.Insert(3, "API Integration");
            list1.Insert(0, "Requirement Gathering");
            list1.RemoveAt(1);
            list1.Insert(1, "Development");
            
            foreach (var j in list1)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Check if list contains \'DB creation\' : "+list1.Contains("DB Creation"));

            list1.Sort();
            Console.WriteLine("Printing elements after sorting, Inserting and Removing elements :");
            foreach(var j in list1)
            {
                Console.WriteLine(j);
            }
        }

        public void LinkedListImplementation()
        {
            Console.WriteLine("----LinkedList Implementation------");
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Sanity testing");
            linkedList.AddLast("Smoke testing");
            linkedList.AddLast("Regression testing");

            Console.WriteLine("Just printing the Linked list node values :");
            foreach(var k in linkedList)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Adding \'Functional testing\' at first node");
            linkedList.AddFirst("Functional testing");

            Console.WriteLine("Adding \'API testing\' before smoke testing node");
            LinkedListNode<string> beforeNode = linkedList.FindLast("Smoke testing");
            linkedList.AddBefore(beforeNode, "API testing");

            Console.WriteLine("Adding \'Performance testing\' after Regression testing node");
            LinkedListNode<string> afterNode = linkedList.FindLast("Regression testing");
            linkedList.AddAfter(afterNode, "Performance testing");

            Console.WriteLine("Adding \'DB testing\' at last node");
            linkedList.AddLast("DB testing");

            Console.WriteLine("Just printing the Linked list node values after adding before and after nodes,at first and last :");
            foreach (var m in linkedList)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("Removing last and first nodes in linked list:");
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            IEnumerator<string> em =  linkedList.GetEnumerator();

            while(em.MoveNext())
            {
                Console.WriteLine("Elements in linked list are :" + em.Current);
            }

        }
    }
}