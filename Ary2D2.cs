using System;

namespace mira_nb
{
    class Ary2D2
    {
        public static void Main(string[] args)
        {
            int[,] ary = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine("The 2D Array is:");

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


