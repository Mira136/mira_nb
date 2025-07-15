using System;

namespace mira_nb
{
    class CmndLine
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command Line Arguments:");
            Console.WriteLine("First argumnet:" + args[0]);
            Console.WriteLine("Second argument:" + args[1]);
        }
    }
}

/*using System;

namespace mira_nb
{
    class CmndLine
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Command Line Arguments:");

            if (args.Length < 2)
            {
                Console.WriteLine("Please provide at least two command line arguments.");
            }
            else
            {
                Console.WriteLine("First argument:  " + args[0]);
                Console.WriteLine("Second argument: " + args[1]);
            }

            Console.ReadLine(); // Optional: to pause the console window
        }
    }
}*/

