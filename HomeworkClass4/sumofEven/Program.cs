using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4Homework
{
    class Program
    {
        public static int SumOfEven()
        {
            int[] arr = new int[6];
            Console.WriteLine("add numbers");
            arr[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("add secound number");
            arr[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("add third");
            arr[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("add fourth");
            arr[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("add fifth");
            arr[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("add sixth");
            arr[5] = int.Parse(Console.ReadLine());

            //for(int i =0; i<arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            int sum = 0;

            foreach (int num in arr)
            {
                if(num%2 == 0)
                {
                    sum += num;
                }
            }

            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfEven());
            Console.ReadLine();
        }
    }
}
