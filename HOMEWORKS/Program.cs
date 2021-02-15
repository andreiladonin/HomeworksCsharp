using System;

namespace HOMEWORKS
{
    class Program
    {
        static void Resize(ref int [] myarr, int i , int value)
        {
            switch (i)
            {
                case 0:
                    myarr = new int[myarr.Length - value];
                    break;
                case 1:
                    myarr = new int[myarr.Length + value];
                    break;
            }
        }
        static void Main(string[] args)
        {
            int[] myarr = new int[10];
            Resize(ref myarr, 1, 5);
            Console.WriteLine(myarr.Length);
        }
    }
}
