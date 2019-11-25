using System;

namespace Open_Lab_04._03
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveFirstLast removeFirstLast = new RemoveFirstLast();
            string txt = Console.ReadLine();
            Console.WriteLine(removeFirstLast.RemoveFirstLastChar(txt));
        }
    }
}
