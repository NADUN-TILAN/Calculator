using System;

namespace ConsoleApp2
{
    public class Circle //class
    {
        public double r;

        public Circle()
        {
        }

        public Circle(double r) //constractor
        {
            this.r = r;
        }
        public void ans() //method
        {
            double area = 3.14 * this.r * this.r;
            Console.WriteLine("circle area: " + area);
        }
    }
}
