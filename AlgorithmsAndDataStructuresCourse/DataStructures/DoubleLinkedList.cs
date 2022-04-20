using System;
namespace AlgorithmsAndDataStructuresCourse.DataStructures
{
    public class DoubleLinkedList
    {
        public DoubleLinkedList()
        {
        }

        private class DoubleLink<T>
        {
            public DoubleLink<T> next;
            public DoubleLink<T> previous;
            private T data;


        }
    }
}
