using System;

namespace mira_bd
{
    class Array1
    {
        public static void Main(string[] args)
        {
            int[] ary = { 10, 20, 30, 40, 50 };
            // intialization of array elements
            Console.WriteLine("Enter arraay elements:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            int searchEle;
            Console.WriteLine("Enter element to search:");
            searchEle = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == searchEle)
                {
                    flag = 1;
                }
            }
        }
    }
}

