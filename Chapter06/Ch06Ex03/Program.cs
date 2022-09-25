using System;

namespace Ch06Ex03
{
    internal class Program
    {
       
        static int SumValues(params int[] parametarotEarrej)
        {
            int sum = 0;

            foreach(int element in parametarotEarrej)
            {
                sum += element;
            }

            return sum;
        }


        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            int[] myScArray = { 2, 66, 33, 41, 26 };
            int sum = SumValues(myArray);
            int sum1 = SumValues(myScArray);
            Console.WriteLine($"The summ of nums is {sum}");
            Console.WriteLine($"The summ of nums is {sum1}");
        }
    }
}
