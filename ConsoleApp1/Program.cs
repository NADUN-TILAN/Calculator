using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("nadun", 123, "helo");
            s1.dis_std();
            Console.ReadKey();

        }
    }
}