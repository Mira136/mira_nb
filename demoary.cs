using System;

namespace mira_nb
{
    class demoary
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[2, 2];
            Console.WriteLine("Enter elements of 2x2 array:");

            for (int i = 0; i < ary.GetLength(0); i++) // number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // number of columns
                {
                    ary[i, j] = Convert.ToInt32(ary[i, j]);
                }
                Console.WriteLine();
            }

            int[,] bry = new int[2, 2];
            Console.WriteLine("Enter elements of 2x2 array:");

            for (int i = 0; i < ary.GetLength(0); i++) // number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // number of columns
                {
                    ary[i, j] = Convert.ToInt32(ary[i, j]);
                }
                Console.WriteLine();
            }

            int[,] cry = new int[2, 2];
            for (int i = 0; i < ary.GetLength(0); i++) // number of rows
            {
                for (int j = 0; j < ary.GetLength(1); j++) // number of columns
                {//matrix addition 



                }
    }
}
