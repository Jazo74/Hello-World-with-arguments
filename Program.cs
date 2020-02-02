using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                foreach (string param in args)
                {
                    Console.WriteLine("Hello " + param + "!");
                }
            }
        }
    }
}
