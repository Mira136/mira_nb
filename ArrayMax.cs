using System;

namespace mira_bd
{
    class ArrayMax
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            // intialization of array elements
            Console.WriteLine("Enter arraay elements:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            int max = ary[0];
            for(int i = 1; i < ary.Length; i++)
            {
                if(ary[i] > max)
                    max = ary[i];
            }
            Console.WriteLine(max);
        }
    }
}
