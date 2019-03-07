using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void AgeCalculator ()
        {
            Console.WriteLine("enter your birthday");
            string birth = Console.ReadLine();
            DateTime birthday = DateTime.Parse(birth);
            DateTime current = DateTime.Now;
            
            TimeSpan age = birthday - current;
            Console.WriteLine(age);
            Console.ReadLine();




        }
        static void Main(string[] args)
        {
            DateTime Current = DateTime.Now;
            DateTime today = DateTime.Today;
            //Console.WriteLine(Current);
            AgeCalculator();
            Console.ReadLine();

        }
    }
}
