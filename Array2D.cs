using System;

namespace mira_nb
{
    class Array2D
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[3,3];
            Console.WriteLine("Enter elements of 3x3 array:");

            for (int i = 0; i < ary.GetLength(0); i++) // number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // number of columns
                {
                    Console.Write("Element [{0},{1}]: ", i,j);
                    ary[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe 2D Array is: ");
            for (int i = 0; i < ary.GetLength(0); i++) // number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // number of columns
                {
                    Console.Write(ary[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
