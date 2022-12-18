using System;

namespace Insertion_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 2, 5, 6, 0,8};
            Console.WriteLine("Original Array Elements :");
            PrintIntegerArray(numbers);
            Console.WriteLine("Sorted Array Elements :");
            PrintIntegerArray(InsertionSort(numbers));
           
        }

        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
    

