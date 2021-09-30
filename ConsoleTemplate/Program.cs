using System;

namespace ConsoleTemplate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = 'n';
            do
            {
                //input your logic here.

                Console.Write("Do you want to continue more (y/n)?  ");
                res = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (res == 'y' || res == 'Y');
        }
    }
}