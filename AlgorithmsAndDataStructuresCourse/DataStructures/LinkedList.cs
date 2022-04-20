using System;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructuresCourse.DataStructures
{
    public class LinkedList<T>
    {
        private Link<T> head;

        public LinkedList()
        {
            
        }

        public void InsertToEnd(T data)
        {
            if (head == null)
            {
                head = new Link<T>(data);
            }
            else
            {
                var link = head;
                while (link.nextLink != null)
                {
                    link = link.nextLink;
                }
                link.nextLink = new Link<T>(data);
            }
        }

        public void InsertToStart(T data)
        {
            var newLink = new Link<T>(data);
            newLink.nextLink = head;
            head = newLink;
        }

        public T PopFirstData()
        {
            var temp = head;
            head = head.nextLink;
            return temp.GetData();
        }

        public IEnumerable<T> DisplayData()
        {
            var data = new List<T>();

            var temp = head;
            data.Add(temp.GetData());
            while (temp.nextLink != null)
            {
                data.Add(temp.GetData());
                temp = temp.nextLink;
            }

            return data;
        }

        private class Link<T>
        {
            private T data;
            public Link<T> nextLink;

            public Link(T data)
            {
                this.data = data;
            }

            public override string ToString()
            {
                return data.ToString();
            }

            public T GetData()
            {
                return data;
            }
        }
    }


}
