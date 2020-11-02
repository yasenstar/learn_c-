using System;

namespace newTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
