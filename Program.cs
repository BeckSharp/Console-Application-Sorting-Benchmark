using System;
using System.Diagnostics;

namespace SortingAlgorithmsBenchmark
{
    internal class Benchmark
    {
        public delegate void PerformCalculation(int[] data);

        static void Main(string[] args)
        {
            //Initialising variables for the benchmarks.
            PerformCalculation[] performCalculations = 
            {
                SortingAlgorithm.quickSort,
                SortingAlgorithm.mergeSort,
                SortingAlgorithm.bubbleSort,
                SortingAlgorithm.insertionSort,
                SortingAlgorithm.selectionSort
            };

            string[] benchmarkNames = 
            {
                "Quick sort     ",
                "Merge sort     ",
                "Bubble sort    ",
                "Insertion sort ",
                "Selection sort "
            };
            
            TimeSpan[] benchmarkTimes = new TimeSpan[performCalculations.Length];
            int numbers = 10000;
            int[] testData = new int[numbers];

            //Running Benchmarks.
            for (int i = 0; i < performCalculations.Length; i++)
            {
                testData = generateArrayOfLength(numbers);
                benchmarkTimes[i] = calculateBenchmark(testData, performCalculations[i]);
            }

            //Output Benchmark Results.
            printBenchmark(benchmarkNames, benchmarkTimes);
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

        static TimeSpan calculateBenchmark(int[] data, PerformCalculation performCalculation)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
                performCalculation(data);
            stopWatch.Stop();

            return stopWatch.Elapsed;
        }

        static void printBenchmark(string[] benchmarkNames, TimeSpan[] benchmarkTimes)
        {
            for (int i = 0; i < benchmarkNames.Length; i++)
            {
                Console.WriteLine(benchmarkNames[i] + " = "+ benchmarkTimes[i] + " seconds");           
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