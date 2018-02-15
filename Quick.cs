using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Quick
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Recursive call  
        /// </summary>
        /// <param name="arr">unsorted array</param>
        /// <param name="left">leftmost element</param>
        /// <param name="right">rightmost element</param>
        public static void QuickSort(int[] array, int left, int right)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Quick.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            if (left < right)
            {
                // Changable pivot value
                int pivot = Partition(copyArray, left, right);

                if (pivot > 1)
                    QuickSort(copyArray, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(copyArray, pivot + 1, right);
            }

        }

        /// <summary>
        /// Function for partiotioning array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left">leftmost element of the array</param>
        /// <param name="right">rightmost element of the array</param>
        /// <returns>Function returns the pivot</returns>
        public static int Partition(int[] arr, int left, int right)
        {
            // Selected pivot
            int pivot = arr[left];

            while (true)
            {
                // Elements which are less than the pivot
                while (arr[left] < pivot)
                {
                    left++;
                }

                // Elements which are bigger than the pivot
                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) 
                        return right;

                    // Swap elements
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
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
            QuickSort(array, 0, array.Length - 1);
            return array;
        }
    }
}
