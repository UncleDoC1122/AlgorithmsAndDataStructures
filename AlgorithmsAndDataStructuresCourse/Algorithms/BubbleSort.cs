using System;
namespace AlgorithmsAndDataStructuresCourse.Algorithms
{
    public static class BubbleSort
    {
        /// <summary>
        /// Осуществляет сортировку массива по возрастанию при помощи пузырьковой сортировки
        /// </summary>
        /// <param name="array">Массив, который нужно отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] Sort(int[] array)
        {
            //Проходим по каждому элементу массива
            for (int i = 0; i < array.Length; i++)
            {
                //Для каждого следующего за i элемента массива
                for (int j = i + 1; j < array.Length; j++)
                {
                    //Если последующий элемент меньше опорного
                    if (array[i] > array[j])
                    {
                        //Поменять их местами
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
