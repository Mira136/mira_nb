using System;

namespace mira_nb
{
    class JagAry
    {
        public static void Main(string[] args)
        {
            int[][] jAry = new int[4][];
            jAry[0] = new int[4];
            jAry[1] = new int[3];
            jAry[2] = new int[2];
            jAry[3] = new int[1];

            Console.WriteLine("Enter Jagged Array elements:");

            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array is:");

            for (int i = 0; i < jAry.Length; i++)
            {
                for (int j = 0; j < jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j]);
                }
                Console.WriteLine();
            }  
        }
    }
}