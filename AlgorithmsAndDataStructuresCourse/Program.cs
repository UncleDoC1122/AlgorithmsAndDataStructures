using System;
using AlgorithmsAndDataStructuresCourse.DataStructures;

namespace AlgorithmsAndDataStructuresCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new DataStructures.Array(length: 1000);

            var linearSearchTest = array.LinearSearch(20);
            Console.WriteLine(linearSearchTest);

            var orderedArray = new DataStructures.Array(1000, 1000, true);

            var binarySearchTest = orderedArray.BinarySearch(20);
            Console.WriteLine(binarySearchTest);
        }
    }
}
