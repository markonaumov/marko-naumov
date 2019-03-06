using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        public static double RealCalculator()
        {
            Console.WriteLine("enter the first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the secound number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter character");
            char chara = char.Parse(Console.ReadLine());
            double num3;
            if (chara == '+')
            {
                num3 = num1 + num2;
                return num3;
            }
            else if (chara == '-')
            {
                num3 = num1 - num2;
                return num3;
            }
            else if (chara == '*')
            {
                num3 = num1 * num2;
                return num3;
            }
            else if (chara == '/')
            {
                num3 = num1 / num2;
                Console.WriteLine("the result is");
                return num3;
            }
            else
            {
                return num3 = 0;
            }
        }
        public static double AverageNumber()
            {
            Console.WriteLine("enter first number ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter secound number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter fourth number");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine("the average is:");
            double average = (num1 + num2 + num3 + num4) / 4;
            return average;
        }
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("swap");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            
        }  
        
        static void Main(string[] args)
        {
            //Console.WriteLine(RealCalculator());
            //Console.WriteLine(AverageNumber());
            SwapNumbers();
            Console.ReadLine();
        }
    }
}
