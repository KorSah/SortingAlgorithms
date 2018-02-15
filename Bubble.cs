using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Bubble
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Function sorts array with Bubble sort
        /// </summary>
        /// <param name="array">Unsorted array for sorting</param>
        /// <returns>Function returns sorted array</returns>
        public static int[] Sort(int[] array)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Bubble.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            // The start of array
            int count = 0;

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = array.Length - 1; j > count; j--)
                {
                    // Compare elements pair by pair 
                    if (array[j] < array[j - 1])
                    {
                        // Swap elements
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
                count++;
            }
            return array;
        }
    }
}
