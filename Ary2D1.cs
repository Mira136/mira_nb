using System;

namespace mira_nb
{
    class Ary2D1
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[2, 2];
            ary[0, 0] = 1;
            ary[0, 1] = 2;
            ary[1, 0] = 3;
            ary[1, 1] = 4;

            Console.WriteLine("First element: " + ary[0, 0]);
            Console.WriteLine("Second element:" + ary[0, 1]);
            Console.WriteLine("Third element: " + ary[1, 0]);
            Console.WriteLine("Forth element: " + ary[1, 1]);
        }
    }
}

