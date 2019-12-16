using System;
using System.IO;

namespace OutputFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = args[0].Length;
            
            for (int i=args[0].Length;i>0;i--)
            {
                s--;
                if (args[0].Substring(s, 1) == ".")
                {
                    Console.WriteLine(args[0].Substring(s,(args[0].Length-s)));
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
