using System;

namespace ConsoleApp1
{
    public class student //class
    {
        public String Name;
        public int ID;
        public String details;

        public student(String a, int b, String c) //constracter
        {
            this.Name = a;
            this.ID = b;
            this.details = c;
        }

        public void dis_std() //method
        {
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Student ID = " + this.ID);
            Console.WriteLine("Student Details = " + this.details);
        }

    }



}
