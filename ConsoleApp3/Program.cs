using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("1. add");//Addition
            Console.WriteLine("2. sub");//Subtraction
            Console.WriteLine("3. mul");//Multiplication
            Console.WriteLine("4. div");//Division

            Console.WriteLine("choose an option : ");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first input");

            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second input");

            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (action)
            {
                case 1:


                    {
                        result = Add(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Sub(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Mul(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Div(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("wrong! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }

        public static int Add(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }

        public static int Sub(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }

        public static int Mul(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }

        public static int Div(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }
    }
}
