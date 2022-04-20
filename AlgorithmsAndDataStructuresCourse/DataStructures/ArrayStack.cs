using System;
namespace AlgorithmsAndDataStructuresCourse.DataStructures
{
    public class Stack<T>
    {
        //Массив для хранения данных
        public T[] internalArray { get; private set; }
        //Индекс головного элемента
        private int head;

        /// <summary>
        /// Создает новый экземпляр стека с массивом из 10 элементов
        /// </summary>
        public Stack()
        {
            internalArray = new T[10];
            head = 0;
        }

        /// <summary>
        /// Внутренний метод стека, позволяющий расширять внутренний массив по необходимости
        /// </summary>
        private void ExtendInternalArrayIfNeeded()
        {
            //если индекс вставляемого элемента выходит за границы массива
            if (head == internalArray.Length - 1)
            {
                //расширить массив
                T[] newArray = new T[internalArray.Length * 2];
                for (int i = 0; i < internalArray.Length; i++)
                {
                    newArray[i] = internalArray[i];
                }
                internalArray = newArray;
            }
        }

        /// <summary>
        /// Вставить элемент в стек (увеличить длину внутреннего хранилища вдвое, если не хватает места)
        /// </summary>
        /// <param name="value">Вставляемое значение</param>
        public void Push(T value)
        {
            //Расширить внутренний массив, если не хватает места
            ExtendInternalArrayIfNeeded();
            //Вставить элемент
            internalArray[head++] = value;
        }

        /// <summary>
        /// Достать "верхний" элемент из стека
        /// </summary>
        /// <returns>Значение "верхнего" элемента стека</returns>
        public T Pop()
        {
            return internalArray[--head];
        }

        /// <summary>
        /// Вставляет элемент в стек и возвращает новое количество элементов в стеке
        /// </summary>
        /// <param name="value">Вставляемый элемент</param>
        /// <returns></returns>
        public int PushWithLength(T value)
        {
            //Расширить внутреннее хранилище, если нужно
            ExtendInternalArrayIfNeeded();

            internalArray[head++] = value;
            return head + 1;
        }

        public T Peek()
        {
            return internalArray[head - 1];
        }

        public int Length()
        {
            return head;
        }
    }
}
