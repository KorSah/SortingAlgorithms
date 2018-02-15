using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Selection
    {
        // Block for keeping used memory size
        public static int memoryUsage;

        /// <summary>
        /// Function sorts array with Selection sort
        /// </summary>
        /// <param name="array">Unsorted array for sorting</param>
        /// <returns>Function returns sorted array</returns>
        public static int[] Sort(int[] array)
        {
            // Array for keeping sorted elements
            int[] copyArray = new int[array.Length];

            // Used memory in heap
            Selection.memoryUsage += array.Length * (sizeof(int));

            // Copy of the array
            Array.Copy(array, copyArray, array.Length);

            int temp2for_j = 0;
            int currentElement = 0;
            int a = 0;

            for (int j = 0; j < copyArray.Length; j++) 
            {
                currentElement = a;
                int min = 0;
                bool temp = true;
                int index = 0;

                // Find minimum value in array
                for (int i = currentElement + 1; i < copyArray.Length; )
                {
                    if (copyArray[currentElement] < copyArray[i])
                    {
                        // Minimum value
                        min = copyArray[currentElement];
                        // Minimum value index
                        index = currentElement;
                        temp = true;
                    }
                    else
                    {
                        currentElement++;
                        temp = false;
                    }
                    if (temp == false)
                        i = currentElement + 1; 
                    else  
                        i++; 
                }

                // Swap elements
                temp2for_j = copyArray[j];
                copyArray[j] = copyArray[currentElement];
                copyArray[currentElement] = temp2for_j;
                a++;
            }
            return copyArray;
        }
    }
}
