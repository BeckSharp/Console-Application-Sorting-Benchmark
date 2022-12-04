using System;

namespace SortingAlgorithmsBenchmark
{
    internal class Benchmark
    {
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

            //Randomly generate an array of 1000 numbers.
            int numbers = 1000;
            int[] testData = generateArrayOfLength(numbers);

            //Quick sort benchmark.

            //Merge sort benchmark.

            //Bubble sort benchmark.

            //Insertion sort benchmark.

            //Selection sort benchmark.

            //Output Benchmark Results.
            printResults(testData);
        }

        static int[] generateArrayOfLength(int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next();
            }

            return array;
        }

        //Code used for testing program.
        //Can be removed when program is finished.
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }
    }
}