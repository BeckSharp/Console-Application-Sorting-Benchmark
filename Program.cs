using System;
using System.Diagnostics;

namespace SortingAlgorithmsBenchmark
{
    internal class Benchmark
    {
        static void Main(string[] args)
        {
            string[] benchmarkNames = 
            {
                "Quick sort",
                "Merge sort",
                "Bubble sort",
                "Insertion sort",
                "Selection sort"
            };
            Stopwatch[] benchmarkTimers = new Stopwatch[5];

            //Randomly generate an array of 1000 numbers.
            int numbers = 10000;
            int[] testData = new int[numbers];

            testData = generateArrayOfLength(numbers);

            //Quick sort benchmark.
            testData = generateArrayOfLength(numbers);

            //Merge sort benchmark.
            testData = generateArrayOfLength(numbers);

            //Bubble sort benchmark.
            testData = generateArrayOfLength(numbers);
            Stopwatch timerThree = new Stopwatch();

            timerThree.Start();
            SortingAlgorithm.bubbleSort(testData);
            timerThree.Stop();
            benchmarkTimers[2] = timerThree;

            //Insertion sort benchmark.
            testData = generateArrayOfLength(numbers);

            //Selection sort benchmark.
            testData = generateArrayOfLength(numbers);

            //Output Benchmark Results.
            printBenchmark(benchmarkNames, benchmarkTimers);
        }

        static int[] generateArrayOfLength(int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(length);
            }

            return array;
        }

        static void printBenchmark(string[] benchmarkNames, Stopwatch[] benchmarkTimers)
        {
            for (int i = 0; i < benchmarkNames.Length; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(benchmarkNames[i] + " = "+ benchmarkTimers[i].Elapsed + " seconds");
                }            
            }
        }

        //Code used for testing program.
        //Can be removed when program is finished.
        static void printResults(int[] data) 
        {
           Console.WriteLine("[{0}]", string.Join(", ", data));
        }
    }
}