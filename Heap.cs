using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Heap
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Function which creates tree
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Graph(int[] array, int i, int N)
        {
            // For max value
            int imax;
            int buf;

            if ((2 * i + 2) < N)
            {
                if (array[2 * i + 1] < array[2 * i + 2])
                    imax = 2 * i + 2;
                else
                    imax = 2 * i + 1;
            }
            else
                imax = 2 * i + 1;
            if (imax >= N)
                return i;
            if (array[i] < array[imax])
            {
                buf = array[i];
                array[i] = array[imax];
                if (imax < N / 2)
                    i = imax;
            }
            return i;
        }

        /// <summary>
        /// Sorting array with Heap sort
        /// </summary>
        /// <param name="array">Unsorted array</param>
        /// <param name="length">Length of the array</param>
        public static void HeapSort(int[] array, int length)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Heap.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            for (int i = length / 2 - 1; i >= 0; --i)
            {
                long previous = i;
                i = Graph(copyArray, i, length);
                if (previous != i)
                    ++i;
            }
            int buf;
            for (int k = length - 1; k > 0; --k)
            {
                buf = copyArray[0];
                copyArray[0] = copyArray[k];
                copyArray[k] = buf;
                int i = 0;
                int previous = -1;
                while (i != previous)
                {
                    previous = i;
                    i = Graph(copyArray, i, k);
                }
            }
        }

        /// <summary>
        /// This function will be called in Main function with one parametr
        /// </summary>
        /// <param name="array">Unsorted array</param>
        /// <returns>Function returns sorted array</returns>
        public static int[] Sort(int[] array)
        {
            HeapSort(array, array.Length);
            return array;
        }
    }
}
