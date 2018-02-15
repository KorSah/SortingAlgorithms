using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        /// <summary>
        /// Function prints array
        /// </summary>
        /// <param name="array">array which we want to print</param>
        static void PrintArray(int[] array)
        {
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random rd = new Random();

            Console.WriteLine("Please enter the size of an array that you want to sort:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("\nUnsorted array is:");
            for (int i = 0; i < size; i++)
            {
                array[i] = rd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSelect which algorithm you want to perform:");
            Console.WriteLine("1. Insertion sort");
            Console.WriteLine("2. Bubble sort");
            Console.WriteLine("3. Selection sort");
            Console.WriteLine("4. Quick sort");
            Console.WriteLine("5. Heap sort");
            Console.WriteLine("6. Merge sort");
            Console.WriteLine("7. All\n");

            int algNumber;
            string text = Console.ReadLine();
            Console.WriteLine();
            string[] numbers = text.Split(',');
            long effectiveTime = long.MaxValue;
            string effectiveAlgorithm = null;

            // Perform only one algorithm
            if (int.TryParse(text, out algNumber))
            {
                algNumber = int.Parse(text);
                switch (algNumber)
                {
                    case 1:
                        // Insertion sort part
                        Console.WriteLine("1. Insertion sort");
                        Stopwatch time1 = Stopwatch.StartNew();
                        PrintArray(Insertion.Sort(array));
                        time1.Stop();
                        Console.WriteLine("Runtime is " + time1.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Insertion.memoryUsage + " bytes");
                        break;
                    case 2:
                        // Bubble sort part
                        Console.WriteLine("2. Bubble sort");
                        Stopwatch time2 = Stopwatch.StartNew();
                        PrintArray(Bubble.Sort(array));
                        time2.Stop();
                        Console.WriteLine("Runtime is " + time2.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Bubble.memoryUsage + " bytes");
                        break;
                    case 3:
                        // Selection sort part
                        Console.WriteLine("3. Selection sort");
                        Stopwatch time3 = Stopwatch.StartNew();
                        PrintArray(Selection.Sort(array));
                        time3.Stop();
                        Console.WriteLine("Runtime is " + time3.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Selection.memoryUsage + " bytes");
                        break;
                    case 4:
                        // Quick sort part
                        Console.WriteLine("4. Quick sort");
                        Stopwatch time4 = Stopwatch.StartNew();
                        PrintArray(Quick.Sort(array));
                        time4.Stop();
                        Console.WriteLine("Runtime is " + time4.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Quick.memoryUsage + " bytes");
                        break;
                    case 5:
                        // Heap sort part
                        Console.WriteLine("5. Heap sort");
                        Stopwatch time5 = Stopwatch.StartNew();
                        PrintArray(Heap.Sort(array));
                        time5.Stop();
                        Console.WriteLine("Runtime is " + time5.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Heap.memoryUsage + " bytes");
                        break;
                    case 6:
                        // Merge sort part
                        Console.WriteLine("6. Merge sort");
                        Stopwatch time6 = Stopwatch.StartNew();
                        PrintArray(Merge.Sort(array));
                        time6.Stop();
                        Console.WriteLine("Runtime is " + time6.ElapsedMilliseconds + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Merge.memoryUsage + " bytes");
                        break;
                    case 7:
                        // Perform all algorithms

                        // Insertion sort part
                        Console.WriteLine("1. Insertion sort");
                        Stopwatch time1_1 = Stopwatch.StartNew();
                        PrintArray(Insertion.Sort(array));
                        time1_1.Stop();
                        long runtime1 = time1_1.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime1 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Insertion.memoryUsage + " bytes");
                        if (runtime1 < effectiveTime)
                        {
                            effectiveTime = runtime1;
                            effectiveAlgorithm = "1. Insertion sort\nRuntime is " + runtime1 + " milliseconds\n"
                                + "Memory usage size is " + Insertion.memoryUsage + " bytes\n";
                        }

                        // Bubble sort part
                        Console.WriteLine("2. Bubble sort");
                        Stopwatch time2_2 = Stopwatch.StartNew();
                        PrintArray(Bubble.Sort(array));
                        time2_2.Stop();
                        long runtime2 = time2_2.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime2 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Bubble.memoryUsage + " bytes");
                        if (runtime2 < effectiveTime)
                        {
                            effectiveTime = runtime2;
                            effectiveAlgorithm = "2. Bubble sort\nRuntime is " + runtime2 + " milliseconds\n"
                                + "Memory usage size is " + Bubble.memoryUsage + " bytes\n";
                        }

                        // Selection sort part
                        Console.WriteLine("3. Selection sort");
                        Stopwatch time3_3 = Stopwatch.StartNew();
                        PrintArray(Selection.Sort(array));
                        time3_3.Stop();
                        long runtime3 = time3_3.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime3 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Selection.memoryUsage + " bytes");
                        if (runtime3 < effectiveTime)
                        {
                            effectiveTime = runtime3;
                            effectiveAlgorithm = "3. Selection sort\nRuntime is " + runtime3 + " milliseconds\n"
                                + "Memory usage size is " + Selection.memoryUsage + " bytes\n";
                        }

                        // Quick sort part
                        Console.WriteLine("4. Quick sort");
                        Stopwatch time4_4 = Stopwatch.StartNew();
                        PrintArray(Quick.Sort(array));
                        time4_4.Stop();
                        long runtime4 = time4_4.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime4 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Quick.memoryUsage + " bytes");
                        if (runtime4 < effectiveTime)
                        {
                            effectiveTime = runtime4;
                            effectiveAlgorithm = "4. Quick sort\nRuntime is " + runtime4 + " milliseconds\n"
                                + "Memory usage size is " + Quick.memoryUsage + " bytes\n";
                        }

                        // Heap sort part
                        Console.WriteLine("4. Heap sort");
                        Stopwatch time5_5 = Stopwatch.StartNew();
                        PrintArray(Quick.Sort(array));
                        time5_5.Stop();
                        long runtime5 = time5_5.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime5 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Heap.memoryUsage + " bytes");
                        if (runtime5 < effectiveTime)
                        {
                            effectiveTime = runtime5;
                            effectiveAlgorithm = "5. Heap sort\nRuntime is " + runtime5 + " milliseconds\n"
                                + "Memory usage size is " + Heap.memoryUsage + " bytes\n";
                        }

                        // Merge sort part
                        Console.WriteLine("6. Merge sort");
                        Stopwatch time6_6 = Stopwatch.StartNew();
                        PrintArray(Merge.Sort(array));
                        time6_6.Stop();
                        long runtime6 = time6_6.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime6 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Merge.memoryUsage + " bytes");
                        if (runtime6 < effectiveTime)
                        {
                            effectiveTime = runtime6;
                            effectiveAlgorithm = "6. Merge sort\nRuntime is " + runtime6 + " milliseconds\n"
                                + "Memory usage size is " + Merge.memoryUsage + " bytes\n";
                        }
                        break;
                    default:
                        Console.WriteLine("You had entered invalid number");
                        break;
                }
            }

            // Perform several algorithms    
            else if (text[1] == ',')
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    // Insertion sort part
                    if (numbers[i] == "1")
                    {
                        Console.WriteLine("1. Insertion sort");
                        Stopwatch time1 = Stopwatch.StartNew();
                        PrintArray(Insertion.Sort(array));
                        time1.Stop();
                        long runtime1 = time1.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime1 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Insertion.memoryUsage + " bytes");
                        if (runtime1 < effectiveTime)
                        {
                            effectiveTime = runtime1;
                            effectiveAlgorithm = "1. Insertion sort\nRuntime is " + runtime1 + " milliseconds\n"
                                + "Memory usage size is " + Insertion.memoryUsage + " bytes\n";
                        }
                    }

                    // Bubble sort part
                    if (numbers[i] == "2")
                    {
                        Console.WriteLine("2. Bubble sort");
                        Stopwatch time2 = Stopwatch.StartNew();
                        PrintArray(Bubble.Sort(array));
                        time2.Stop();
                        long runtime2 = time2.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime2 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Bubble.memoryUsage + " bytes");
                        if (runtime2 < effectiveTime)
                        {
                            effectiveTime = runtime2;
                            effectiveAlgorithm = "2. Bubble sort\nRuntime is " + runtime2 + " milliseconds\n"
                                + "Memory usage size is " + Bubble.memoryUsage + " bytes\n";
                        }
                    }

                    // Selection sort part
                    if (numbers[i] == "3")
                    {
                        Console.WriteLine("3. Selection sort");
                        Stopwatch time3 = Stopwatch.StartNew();
                        PrintArray(Selection.Sort(array));
                        time3.Stop();
                        long runtime3 = time3.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime3 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Selection.memoryUsage + " bytes");
                        if (runtime3 < effectiveTime)
                        {
                            effectiveTime = runtime3;
                            effectiveAlgorithm = "3. Selection sort\nRuntime is " + runtime3 + " milliseconds\n"
                                + "Memory usage size is " + Selection.memoryUsage + " bytes\n";
                        }
                    }

                    // Quick sort part
                    if (numbers[i] == "4")
                    {
                        Console.WriteLine("4. Quick sort");
                        Stopwatch time4 = Stopwatch.StartNew();
                        PrintArray(Quick.Sort(array));
                        time4.Stop();
                        long runtime4 = time4.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime4 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Quick.memoryUsage + " bytes");
                        if (runtime4 < effectiveTime)
                        {
                            effectiveTime = runtime4;
                            effectiveAlgorithm = "4. Quick sort\nRuntime is " + runtime4 + " milliseconds\n"
                                + "Memory usage size is " + Quick.memoryUsage + " bytes\n";
                        }
                    }

                    // Heap sort part
                    if (numbers[i] == "5")
                    {
                        Console.WriteLine("5. Heap sort");
                        Stopwatch time5 = Stopwatch.StartNew();
                        PrintArray(Heap.Sort(array));
                        time5.Stop();
                        long runtime5 = time5.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime5 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Heap.memoryUsage + " bytes");
                        if (runtime5 < effectiveTime)
                        {
                            effectiveTime = runtime5;
                            effectiveAlgorithm = "5. Heap sort\nRuntime is " + runtime5 + " milliseconds\n"
                                + "Memory usage size is " + Heap.memoryUsage + " bytes\n";
                        }
                    }

                    // Merge sort part
                    if (numbers[i] == "6")
                    {
                        Console.WriteLine("6. Merge sort");
                        Stopwatch time6 = Stopwatch.StartNew();
                        PrintArray(Merge.Sort(array));
                        time6.Stop();
                        long runtime6 = time6.ElapsedMilliseconds;
                        Console.WriteLine("Runtime is " + runtime6 + " milliseconds");
                        Console.WriteLine("Memory usage size is " + Merge.memoryUsage + " bytes");
                        if (runtime6 < effectiveTime)
                        {
                            effectiveTime = runtime6;
                            effectiveAlgorithm = "6. Merge sort\nRuntime is " + runtime6 + " milliseconds\n"
                                + "Memory usage size is " + Merge.memoryUsage + " bytes\n";
                        }
                    }
                }
            }

            // Perform algorithms from given range
            else if (text[1] == '-')
            {
                if (int.Parse(text[0].ToString()) <= int.Parse(text[2].ToString()))
                {
                    for (int i = int.Parse(text[0].ToString()); i <= int.Parse(text[2].ToString()); i++)
                    {
                        // Insertion sort part
                        if (i.ToString() == "1")
                        {
                            Console.WriteLine("1. Insertion sort");
                            Stopwatch time1 = Stopwatch.StartNew();
                            PrintArray(Insertion.Sort(array));
                            time1.Stop();
                            long runtime1 = time1.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime1 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Insertion.memoryUsage + " bytes");
                            if (runtime1 < effectiveTime)
                            {
                                effectiveTime = runtime1;
                                effectiveAlgorithm = "1. Insertion sort\nRuntime is " + runtime1 + " milliseconds\n"
                                    + "Memory usage size is " + Insertion.memoryUsage + " bytes\n";
                            }
                        }

                        // Bubble sort part
                        else if (i.ToString() == "2")
                        {
                            Console.WriteLine("2. Bubble sort");
                            Stopwatch time2 = Stopwatch.StartNew();
                            PrintArray(Bubble.Sort(array));
                            time2.Stop();
                            long runtime2 = time2.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime2 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Bubble.memoryUsage + " bytes");
                            if (runtime2 < effectiveTime)
                            {
                                effectiveTime = runtime2;
                                effectiveAlgorithm = "2. Bubble sort\nRuntime is " + runtime2 + " milliseconds\n"
                                    + "Memory usage size is " + Bubble.memoryUsage + " bytes\n";
                            }
                        }

                        // Selection sort part
                        else if (i.ToString() == "3")
                        {
                            Console.WriteLine("3. Selection sort");
                            Stopwatch time3 = Stopwatch.StartNew();
                            PrintArray(Selection.Sort(array));
                            time3.Stop();
                            long runtime3 = time3.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime3 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Selection.memoryUsage + " bytes");
                            if (runtime3 < effectiveTime)
                            {
                                effectiveTime = runtime3;
                                effectiveAlgorithm = "3. Selection sort\nRuntime is " + runtime3 + " milliseconds\n"
                                    + "Memory usage size is " + Selection.memoryUsage + " bytes\n";
                            }
                        }

                        // Quick sort part
                        else if (i.ToString() == "4")
                        {
                            Console.WriteLine("4. Quick sort");
                            Stopwatch time4 = Stopwatch.StartNew();
                            PrintArray(Quick.Sort(array));
                            time4.Stop();
                            long runtime4 = time4.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime4 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Quick.memoryUsage + " bytes");
                            if (runtime4 < effectiveTime)
                            {
                                effectiveTime = runtime4;
                                effectiveAlgorithm = "4. Quick sort\nRuntime is " + runtime4 + " milliseconds\n"
                                    + "Memory usage size is " + Quick.memoryUsage + " bytes\n";
                            }
                        }

                        // Heap sort part
                        else if (i.ToString() == "5")
                        {
                            Console.WriteLine("5. Heap sort");
                            Stopwatch time5 = Stopwatch.StartNew();
                            PrintArray(Heap.Sort(array));
                            time5.Stop();
                            long runtime5 = time5.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime5 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Heap.memoryUsage + " bytes");
                            if (runtime5 < effectiveTime)
                            {
                                effectiveTime = runtime5;
                                effectiveAlgorithm = "4. Quick sort\nRuntime is " + runtime5 + " milliseconds\n"
                                    + "Memory usage size is " + Heap.memoryUsage + " bytes\n";
                            }
                        }

                        // Merge sort part
                        else if (i.ToString() == "6")
                        {
                            Console.WriteLine("6. Merge sort");
                            Stopwatch time6 = Stopwatch.StartNew();
                            PrintArray(Merge.Sort(array));
                            time6.Stop();
                            long runtime6 = time6.ElapsedMilliseconds;
                            Console.WriteLine("Runtime is " + runtime6 + " milliseconds");
                            Console.WriteLine("Memory usage size is " + Merge.memoryUsage + " bytes");
                            if (runtime6 < effectiveTime)
                            {
                                effectiveTime = runtime6;
                                effectiveAlgorithm = "6. Merge sort\nRuntime is " + runtime6 + " milliseconds\n"
                                    + "Memory usage size is " + Merge.memoryUsage + " bytes\n";
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid range");
                }
            }
            else 
                Console.WriteLine("Invalid input format");

            //Print effective algorithm data in green color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Effective Algorithm:\n" + effectiveAlgorithm);
            Console.ResetColor();   
        }
    }
}
