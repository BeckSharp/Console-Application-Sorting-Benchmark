using System;

namespace SortingAlgorithmsBenchmark
{
    public class SortingAlgorithm
    {
        public static void bubbleSort(int[] data)
        {
            for (int i = 0; i < (data.Length - 1); i++)
            {
                for (int j = 0; j < (data.Length - i - 1); j++)
                {
                    if (data[j] > data[j + 1]) 
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }

        public static void selectionSort(int[] data)
        {
            int indexOfSmallest = 0;

            for (int i = 0; i < data.Length; i++)
            {
                indexOfSmallest = i;

                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[indexOfSmallest]) {
                        indexOfSmallest = j;
                    }
                }

                int temp = data[i];
                data[i] = data[indexOfSmallest];
                data[indexOfSmallest] = temp;
            }
        }
    }
}