using System;

namespace homework15
{
    class Program
    {
        static void PrintArray(int[] arr, int value = 0)
        {
            if (value < arr.Length)
            {
                Console.WriteLine(arr[value]);
                value++;
                PrintArray(arr,value);
            }
            else
            {
                return;
            }
        }

        static int SumArray(int[] arr, int sum = 0,int value=0)
        {

            if (value == arr.Length)
                return sum;
            
            return SumArray(arr, sum += arr[value++], value) ;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 6, 4, 4 };
            
            Console.WriteLine();
            
        }
    }
}
