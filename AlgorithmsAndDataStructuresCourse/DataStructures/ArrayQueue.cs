using System;
namespace AlgorithmsAndDataStructuresCourse.DataStructures
{
    public class Queue<T>
    {
        public T[] internalArray { get; private set; }
        public int head { get; private set; }
        public int tail { get; private set; }
        public int queueLength { get; private set; }
        private int maxSize;

        /// <summary>
        /// Создает экземпляр цикличной очереди с максимальным размером по умолчанию (10 элементов)
        /// </summary>
        public Queue()
        {
            internalArray = new T[10];
            maxSize = 10;
        }

        /// <summary>
        /// Создает экземпляр цикличной очереди с заданным максимальным размером
        /// </summary>
        /// <param name="length">Максимальный размер очереди</param>
        public Queue(int length)
        {
            internalArray = new T[length];
            maxSize = length;
        }

        /// <summary>
        /// Возвращает элемент из начала очереди и удаляет его из очереди
        /// </summary>
        /// <returns>Элемент из начала очереди</returns>
        public T Dequeue()
        {
            //Перенести верхнее значение очереди во временную переменную
            T temp = internalArray[head++];
            //Если указатель на начало очереди указывает на последний элемент массива
            if (head == internalArray.Length)
            {
                //Поместить указатель на начало массива
                head = 0;
            }
            //Уменьшить актуальное количество элементов в очереди
            queueLength--;
            //Вернуть значение
            return temp;
        }

        /// <summary>
        /// Вставляет новый элемент в очередь
        /// </summary>
        /// <param name="value">Вставляемый элемент</param>
        public void Enqueue(T value)
        {
            //Если очередь заполнена - выбросить ошибку
            if (IsFull())
            {
                throw new ArgumentOutOfRangeException("Превышен максимальный размер очереди");
            }
            //Если вставляемый элемент "уперся" в предел внутреннего массива
            if (tail == internalArray.Length)
            {
                //Сместить указатель на конец очереди
                tail = 0;
            }
            //Вставить новый элемент в конец очереди
            internalArray[tail++] = value;

            //Увеличить актуальное количество элементов в очереди
            queueLength++;
        }

        /// <summary>
        /// Возвращает первый элемент очереди без удаления его из очереди
        /// </summary>
        /// <returns>Первый элемент очереди</returns>
        public T Peek()
        {
            return internalArray[head];
        }

        /// <summary>
        /// Показывает, пуста ли очередь
        /// </summary>
        /// <returns>True, если очередь пустая</returns>
        public bool IsEmpty()
        {
            return queueLength == 0;
        }

        /// <summary>
        /// Показывает, заполнена ли очередь
        /// </summary>
        /// <returns>True, если очередь заполнена</returns>
        public bool IsFull()
        {
            return queueLength == maxSize;
        }

        public string QueueContents()
        {
            string output = "";

            for (int i = 0; i < internalArray.Length; i++)
            {
                output += $"Индекс: {i}, значение: {internalArray[i]};\n";
            }

            return output;
        }
    }
}
