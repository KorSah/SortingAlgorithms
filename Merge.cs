using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Merge
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Function sorts array with Merge sort
        /// </summary>
        /// <param name="array">Unsorted array for sorting</param>
        /// <returns>Function returns sorted array</returns>
        public static int[] Sort(int[] array)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Merge.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            // Divide array while it does not consist of one element
            if (copyArray.Length == 1)
                return copyArray;

            // First half of array
            int[] firstArray = new int[(copyArray.Length) / 2];
            Merge.memoryUsage += firstArray.Length * (sizeof(int));
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = copyArray[i];
            }

            // Second half of array
            int[] lastArray = new int[copyArray.Length - firstArray.Length];
            Merge.memoryUsage += lastArray.Length * (sizeof(int));
            for (int j = 0; j < lastArray.Length; j++)
            {
                if (copyArray.Length % 2 == 0)
                {
                    lastArray[j] = copyArray[copyArray.Length - firstArray.Length + j];
                }
                else
                {
                    lastArray[j] = copyArray[copyArray.Length - firstArray.Length - 1 + j];
                }
            }
            firstArray = Sort(firstArray);
            lastArray = Sort(lastArray);
            return MergeSort(firstArray, lastArray);
        }
        public static int[] MergeSort(int[] left, int[] right)
        {
            // Array consist of two element for comparing 
            int[] arr = new int[left.Length + right.Length];
            Merge.memoryUsage += arr.Length * (sizeof(int));

            // Index of left side element
            int indexL = 0;
            // Index of right side element
            int indexR = 0;

            int i = 0;
            for (; indexL < left.Length && indexR < right.Length; i++)
            {
                // Compare elements of arrays
                if (left[indexL] < right[indexR])
                {
                    arr[i] = left[indexL];
                    indexL++;
                }
                else
                {
                    arr[i] = right[indexR];
                    indexR++;
                }
            }

            // Sort elements in array
            while (indexL < left.Length)
                arr[i++] = left[indexL++];
            while (indexR < right.Length)
                arr[i++] = right[indexR++];

            return arr;
        }
    }
}
