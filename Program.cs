using System;

namespace w3rFunction //{}
{
    class Exercise1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a name: ");
            string name = Console.ReadLine();
            Welcome(name);

            Console.ReadLine();
        }

        public static void Welcome(string name)
        {
            Console.WriteLine($"Welcome friend {name}!\nHave a nice day!");
        }
    }
}
