using System;

namespace mira_nb
{
    class Array1
    {
        public static void Main(string[] args)
        {
            int[] ary = { 10, 20, 30, 40, 50 };

            // intialization of array elements
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }

            int searchEle;
            Console.WriteLine("\nEnter element to search:");
            searchEle = Convert.ToInt32(Console.ReadLine());
            
            int flag = 0;

            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == searchEle)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("\nElement found in the array.");
            }
            else
            {
                Console.WriteLine("\nElement not found in the array.");
            }
        }
    }
}

