using System;

namespace SortingAlgorithmsBenchmark
{
    public class SortingAlgorithm
    {
        public static void mergeSort(int[] data, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = ((right + left) / 2);
                mergeSort(data, left, mid);
                mergeSort(data, (mid + 1), right);
                merge(data, left, (mid + 1), right);
            }
        }

        public static void merge(int[] data, int left, int mid, int right)
        {
            int[] temp = new int[data.Length];

            int leftEnd = (mid - 1);
            int tempPosition = left;
            int numberOfElements = (right - left + 1);

            while((left <= leftEnd) && (mid <= right))
            {
                if (data[left]<= data[mid])
                {
                    temp[tempPosition++] = data[left++];
                }
                else
                {
                    temp[tempPosition++] = data[mid++];
                }
            }

            while(left <= leftEnd) { temp[tempPosition++] = data[left++]; }
            while(mid <= right) { temp[tempPosition++] = data[mid++]; }

            for(int i = 0; i < numberOfElements; i++)
            {
                data[right] = temp[right];
                right--;
            }
        }

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

        public static void insertionSort(int[] data)
        {
            int index;
            for (int i = 0; i < (data.Length - 1); i++)
            {
                index = i;

                while ((index >= 0) && (data[index + 1] < data[index]))
                {
                    int temp = data[index];
                    data[index] = data[index + 1];
                    data[index + 1] = temp;

                    index--;
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