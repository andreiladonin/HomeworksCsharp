using System;

namespace homework17
{
    class Program
    {
        static int SumNumber(double n, double sum = 0)
        {
            int iNumber = Convert.ToInt32(n);
            if (iNumber == 0)
            {
                return Convert.ToInt32(sum);
            }

            sum += n % 10;
            int number =  Convert.ToInt32(n)/10;
            return SumNumber(number, sum);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToInt32(135/10));

            int? i = 8;

            Console.WriteLine(i.GetValueOrDefault()); 
        }
    }
}
