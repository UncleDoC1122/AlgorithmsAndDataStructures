using System;
using AlgorithmsAndDataStructuresCourse.Algorithms;

namespace AlgorithmsAndDataStructuresCourse.DataStructures
{
    public class Array
    {
        public int[] array { get; private set; }

        /// <summary>
        /// Создает массив чисел, состоящий из 100 элементов и заполняет его случайными значениями от 1 до 100
        /// </summary>
        /// <param name="maxRandomValue">Максимальное значение случайно сгененрированного числа</param>
        /// <param name="sort">Параметр, указывающий, нужна ли сортировка массива, по умолчанию - false</param>
        public Array(int maxRandomValue = 100, bool sort = false)
        {
            array = new int[100];
            FillArrayWithRandomValues(maxRandomValue);
        }

        /// <summary>
        /// Создает массив чисел произвольной длины и заполняет его случайными значениями от 1 до 100
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// /// <param name="maxRandomValue">Максимальное значение случайно сгененрированного числа</param>
        /// <param name="sort">Параметр, указывающий, нужна ли сортировка массива, по умолчанию - false</param>
        public Array(int length, int maxRandomValue = 100, bool sort = false)
        {
            array = new int[length];
            FillArrayWithRandomValues(maxRandomValue);
            if (sort)
            {
                OrderArrayWithBubbleSort();
            }
        }

        /// <summary>
        /// Заполняет массив случайными значениями от 1 до maxValue
        /// </summary>
        /// <param name="maxValue">Максимальное значение случайно сгенерированного числа (по умолчанию = 100)</param>
        private void FillArrayWithRandomValues(int maxValue = 100)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(maxValue);
            }
        }

        /// <summary>
        /// Сортирует внутренний массив по возрастанию при помощи пузырьковой сортировки
        /// </summary>
        private void OrderArrayWithBubbleSort()
        {
            array = BubbleSort.Sort(array);
        }

        /// <summary>
        /// Возвращает индекс первого найденного элемента, удовлетворяющего
        /// поисковому запросу при помощи линейного поиска
        /// Возвращает -1, если элемент не найден
        /// </summary>
        /// <param name="searchValue">Искомый элемент</param>
        /// <returns>Индекс первого элемента, удовлетворяющему поисковому
        /// запросу (-1 если элемент не найден)</returns>
        public int LinearSearch(int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Осуществляет поиск элемента массива путем бинарного поиска
        /// </summary>
        /// <param name="searchValue">Искомый элемент</param>
        /// <returns>Индекс искомого элемента в отсортированном массиве (не работает с неотсортированными массивами)</returns>
        public int BinarySearch(int searchValue)
        {
            //Индекс начала поисковой области бинарного поиска
            var start = 0;
            //Индекс конца поисковой области бинарного поиска
            var end = array.Length;

            while (start <= end)
            {
                //Середина поисковой области
                var middle = (start + end) / 2;
                //Получаем элемент из середины поисковой области
                var foundElement = array[middle];
                //Если найденный элемент равен поисковому запросу
                if (foundElement == searchValue)
                {
                    //Вернуть индекс найденного элемента
                    return middle;
                }
                //Если найденный элемент больше поискового запроса
                else if (foundElement > searchValue)
                {
                    //Сместить верхнюю гранцу поисковой области на 1 ниже середины
                    end = middle - 1;
                }
                //Если найденный элемент меньше поискового запроса
                else if (foundElement < searchValue)
                {
                    //Сместить нижнюю границу поисковой области на 1 выше середины
                    start = middle + 1;
                }
            }
            //Если элемент не найден - вернуть -1
            return -1;
        }
    }
}
