using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static double a;

        static void Main(string[] args)
        {
            Circle area = new Circle(6);
            area.ans();
            Console.ReadKey();
        }
    }
}
