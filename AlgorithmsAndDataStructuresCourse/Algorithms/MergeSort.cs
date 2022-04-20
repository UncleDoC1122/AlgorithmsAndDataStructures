using System;
using System.Linq;

namespace AlgorithmsAndDataStructuresCourse.Algorithms
{
    public static class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;

            return Merge(Sort(array.Take(middle).ToArray()), Sort(array.Skip(middle).ToArray()));
        }

        private static int[] Merge(int[] array1, int[] array2)
        {
            int a = 0, b = 0;

            int[] merged = new int[array1.Length + array2.Length];

            for (int i = 0; i < (array1.Length + array2.Length); i ++)
            {
                if (b < array2.Length && a < array1.Length)
                {
                    if (array1[a] > array2[b] && b < array2.Length)
                    {
                        merged[i] = array2[b++];
                    }
                    else
                    {
                        merged[i] = array1[a++];
                    }
                }
                else
                {
                    if (b < array2.Length)
                    {
                        merged[i] = array2[b++];
                    }
                    else
                    {
                        merged[i] = array1[a++];
                    }
                }
            }
            return merged;
        }
    }
}
