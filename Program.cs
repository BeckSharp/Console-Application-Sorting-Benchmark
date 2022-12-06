using System;
using System.Diagnostics;

namespace SortingAlgorithmsBenchmark
{
    internal class Benchmark
    {
        
        /*
        Notes:
        I can use a delegate to clean up the sorting benchmark code.
        I will need to feed the 5 function names into a function.
        The function can return a TimeSpan[] which can then be assigned to benchmarkTimes.
        */

        static void Main(string[] args)
        {
            string[] benchmarkNames = 
            {
                "Quick sort     ",
                "Merge sort     ",
                "Bubble sort    ",
                "Insertion sort ",
                "Selection sort "
            };
            TimeSpan[] benchmarkTimes = new TimeSpan[5];
            Stopwatch stopWatch = new Stopwatch();

            //Randomly generate an array of 10000 numbers.
            int numbers = 10000;
            int[] testData = new int[numbers];

            testData = generateArrayOfLength(numbers);

            //Quick sort benchmark.
            stopWatch.Start();

            stopWatch.Stop();
            benchmarkTimes[0] = stopWatch.Elapsed;

            //Merge sort benchmark.
            testData = generateArrayOfLength(numbers);
            stopWatch.Restart();

            stopWatch.Stop();
            benchmarkTimes[1] = stopWatch.Elapsed;

            //Bubble sort benchmark.
            testData = generateArrayOfLength(numbers);

            stopWatch.Restart();
            SortingAlgorithm.bubbleSort(testData);
            stopWatch.Stop();
            benchmarkTimes[2] = stopWatch.Elapsed;

            //Insertion sort benchmark.
            testData = generateArrayOfLength(numbers);
            stopWatch.Restart();

            stopWatch.Stop();
            benchmarkTimes[3] = stopWatch.Elapsed;

            //Selection sort benchmark.
            testData = generateArrayOfLength(numbers);
            stopWatch.Restart();
            SortingAlgorithm.selectionSort(testData);
            stopWatch.Stop();
            benchmarkTimes[4] = stopWatch.Elapsed;

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