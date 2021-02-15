using System;

namespace homework14
{
    class Program
    {
        static void DellindexArrayEnd(ref int[] arr)
        {
            int[] newarr = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length-1; i++)
            {
                newarr[i] = arr[i];
            }
            arr = newarr;
        }

        static void DellindexArrayFirst(ref int[] arr)
        {
            int[] newarr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                } else
                {
                    newarr[j] = arr[i];
                    j++;
                }
            }
            arr = newarr;
        }

        static void DellindexArrayIndex(ref int[] arr, int index)
        {
            int[] newarr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < newarr.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    newarr[i] = arr[j];
                }
            }
            arr = newarr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 647, 4, 64 };
            DellindexArrayEnd(ref arr);
            //DellindexArrayFirst(ref arr);
            //DellindexArrayIndex(ref arr, 3);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
