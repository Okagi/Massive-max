using System;

namespace massive_max
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] a = new int[] { 1, 8, 5, 3, 9, 1, 0, 7, 2, 4 };
            Console.WriteLine();
            for (int j = 0; j < a.Length; j++)
                Console.WriteLine(a[j] + "");
            Console.WriteLine();
            int max = 0;
            for (int b = 0; b < a.Length - 1; b++)

            {
                if (a[b] > max)
                    max = a[b];

            }
            Console.WriteLine(max);


        }
    }
}       
            
     
   

