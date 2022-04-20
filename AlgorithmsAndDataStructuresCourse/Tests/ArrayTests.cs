using System;
using System.Diagnostics;

namespace AlgorithmsAndDataStructuresCourse.Tests
{
    public static class ArrayTests
    {
        public static void BinarySearchTest()
        {
            var orderedArray = new DataStructures.Array(1000 * 1000, 1000 * 1000, true);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var binarySearchTest = orderedArray.BinarySearch(1000 * 100);
            Console.WriteLine($"Потрачено времени на бинарный поиск: {stopwatch.ElapsedTicks}");

        }

        public static void LinearSearchTest()
        {
            var array = new DataStructures.Array(1000 * 1000, 1000 * 1000, true);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var linearSearchTest = array.LinearSearch(1000 * 100);
            Console.WriteLine($"Потрачено времени на линейный поиск: {stopwatch.ElapsedTicks}");
        }
    }
}
