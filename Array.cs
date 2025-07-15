using System;

namespace mira_nb
{
	class Array
	{
		public static void Main(string[] args)
		{
			/*int[] ary = new int[5];
			ary[0] = 10;
			ary[1] = 20;
			ary[2] = 30;
			ary[3] = 40;
			ary[4] = 50;

			Console.WriteLine(ary[0]);
			Console.WriteLine(ary[1]);
            Console.WriteLine(ary[2]);
            Console.WriteLine(ary[3]);
            Console.WriteLine(ary[4]);*/

			int[] ary = { 10, 20, 30, 40, 50 };
			// intialization of array elements
			Console.WriteLine("Enter arraay elements:");
			for (int i = 0; i < ary.Length; i++)
			{
				ary[i] = Int32.Parse(Console.ReadLine());
			}

			/*for (int i = 0; i < ary.Length; i++)
			{
				Console.WriteLine(ary[i]);
			}*/

			foreach (int var in ary)
			{
				Console.WriteLine(var);
			}

			int sum = 0;
			for (int i = 0; i < ary.Length; i++)
			{
				sum = sum + ary[i];
			}
			
			int avg = 0;

			
        }
    }
}
