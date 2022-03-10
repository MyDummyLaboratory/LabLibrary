using System;

namespace LabLibrary.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LabLibrary.Point pt = new Point(1,2,3);
            Console.WriteLine(pt.X);
        }
    }
}
