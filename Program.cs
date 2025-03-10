using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayImplementation arrays = new ArrayImplementation();
           arrays.ArrayImplementationMethod();
           arrays.HandlingMultiDimensionArray();

            List_Collections_Implementation listImplementation = new List_Collections_Implementation();
            listImplementation.HandlingLists();
            listImplementation.LinkedListImplementation();

            ArrayList_DictionaryImplementation arrayListDictionary = new ArrayList_DictionaryImplementation();
            arrayListDictionary.ArrayListImplementation();
            arrayListDictionary.DictionaryImplementation();

            Hashset_SortedSetImplementation hashSet_sorterdSetImplementation = new Hashset_SortedSetImplementation();
            hashSet_sorterdSetImplementation.HashSetImplementation();
            hashSet_sorterdSetImplementation.SortedSetImplementation();

        }
    }
}
