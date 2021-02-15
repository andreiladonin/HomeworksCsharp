using System;

namespace homework13
{
    class Program
    {
        static void AddValueArray (ref int [] arr, int value) 
        {
            int[] newarr = new int[arr.Length + 1];

            for (int i = 0; i < newarr.Length; i++)
            {
                if (i == newarr.Length-1)
                {
                    newarr[i] = value;
                }
                else
                {
                    newarr[i] = arr [i];
                }
            }

            arr = newarr;

        }

        static void AddFirstElementArray(ref int[] arr, int value)
        {
            int[] newarr = new int[arr.Length + 1];
            int j = 0;
            for (int i = 0; i < arr.Length+1; i++)
            {
                if (i == 0)
                {
                    newarr[i] = value;
                    continue;
                    j++;
                }
                else
                {
                    newarr[i] = arr[j];
                    j++;
                }
            }

            arr = newarr;

        }

        static void AddElement(ref int[] arr, int value, int index)
        {
            int[] newarr = new int[arr.Length + 1];
            int j = 0;
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i == index)
                {
                    newarr[i] = value;
                    continue;
     
                }
                else
                {
                    newarr[i] = arr[j];
                    j++;
                }
            }

            arr = newarr;

        }
        static void Main(string[] args)
        {
            int[] arr = {3, 6, 647, 4, 64 };

            AddValueArray(ref arr, 5);
            //AddFirstElementArray(ref arr, 2);

            //AddElement(ref arr, 23, 2); 

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
        }
    }
}
