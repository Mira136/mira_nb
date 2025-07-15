using System;

namespace mira_nb
{
    class AryMatrix
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[2, 2];
            int[,] bry = new int[2, 2];
            int[,] cry = new int[2, 2]; // Resultant matrix

            Console.WriteLine("Enter elements of first 2x2 matrix:");
            for (int i = 0; i < ary.GetLength(0); i++)
            {
                for (int j = 0; j < ary.GetLength(1); j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    ary[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements of second 2x2 matrix:");
            for (int i = 0; i < bry.GetLength(0); i++)
            {
                for (int j = 0; j < bry.GetLength(1); j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    bry[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Matrix Addition Logic
            for (int i = 0; i < cry.GetLength(0); i++)
            {
                for (int j = 0; j < cry.GetLength(1); j++)
                {
                    cry[i, j] = ary[i, j] + bry[i, j];
                }
            }

            // Displaying Result
            Console.WriteLine("\nResultant Matrix after Addition:");
            for (int i = 0; i < cry.GetLength(0); i++)
            {
                for (int j = 0; j < cry.GetLength(1); j++)
                {
                    Console.Write(cry[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
