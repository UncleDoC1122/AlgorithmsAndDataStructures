using System;
using AlgorithmsAndDataStructuresCourse.DataStructures;

namespace AlgorithmsAndDataStructuresCourse.Playground
{
    public static class LinkedListPlayground
    {
        public static void LinkedListTest1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.InsertToStart(1);

            var linkedListData = linkedList.DisplayData();

            foreach (var element in linkedListData)
                Console.WriteLine(element);
            /*
            {
                data: 1;
                nextLink: -> {
                    data: 2;
                    nextLink: -> {
                        data: 3;
                        nextLink: null
                    };
                };
            }

            {
                data: 1,
                next: null,
                prev: null
            }
            */
        
        }
    }
}
