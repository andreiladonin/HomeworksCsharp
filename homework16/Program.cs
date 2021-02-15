using System;

namespace homework16
{
    class Program
    {
        static int SumArray(int[] arr, int sum = 0, int value = 0)
        {

            if (value == arr.Length)
                return sum;

            return SumArray(arr, sum += arr[value++], value);
        }
        static void Main(string[] args)
        {
\
        }
    }
}
