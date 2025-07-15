using System;

namespace mira_nb
{
    class Arrayfreq
    {
        public static void Main(string[] args)
        {
            int[] ary = new int[5];
            bool[] freq = new bool[5];

            // intialization of array elements
            Console.WriteLine("Enter arraay elements:");

            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
                freq[i] = false;
            }

            for (int i = 0; i < ary.Length; i++)
            {
                if (freq[i] == true)
                    continue;

                int cnt = 1;
                for (int j = i + 1; j < ary.Length; j++) 
                {
                    if (ary[i] == ary[j])
                    {
                        freq[j] = true;
                        cnt++;
                    }
                }
                Console.WriteLine("Frequency of {0} is {1} times", ary[i], cnt);    
            }
        }
    }
}
