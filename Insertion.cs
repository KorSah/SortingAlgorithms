using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Insertion
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Function sorts array with Insertion sort
        /// </summary>
        /// <param name="array">Unsorted array for sorting</param>
        /// <returns>Function returns sorted array</returns>
        public static int[] Sort(int[] array)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Insertion.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            for (int i = 1; i < array.Length; i++)
            {
                // Leftmost number we count as sorted
                int count = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    // Compare next elements with sorted part
                    if (copyArray[count] < copyArray[j])
                    {
                        // Swap elements
                        int temp = copyArray[j];
                        copyArray[j] = copyArray[count];
                        copyArray[count] = temp;
                    }
                    count--;
                }
            }
            return copyArray;
        }
    }
}
