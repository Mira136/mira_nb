using System;

namespace mira_nb
{
    class Arraysort
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];

            // intialization of array elements
            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ary.Length; i++)
            {
                for (int j = i+1; j < ary.Length; j++)
                {
                    if (ary[i] > ary[j])
                    {
                        int temp = ary[i]; 
                        ary[i] = ary[j];
                        ary[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted array elements:");

            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine(ary[i]);
            }
        }
    }
}
