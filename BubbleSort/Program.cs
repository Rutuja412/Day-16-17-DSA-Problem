using System;

namespace BubbleSort
{
 public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {7,6,9,4,3};
            int temp;
            Console.WriteLine("Given Array : ");
            foreach (int a in arr)
                Console.WriteLine(a + " ");
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                       temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write(  " Sorted array : ");
            foreach (int a in arr)
                Console.WriteLine(a + " ");
                Console.ReadKey();

        }
    }
}
        
    
    

