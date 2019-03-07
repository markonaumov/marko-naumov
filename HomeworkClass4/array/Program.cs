using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = { "marko","janko","bojan","ivan","petar" };
            string[] group2 = { "darko", "milan", "jasna", "bojana", "vladimir" };

            Console.WriteLine("enter numbers between 1 and 2");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("group number 1");
                    foreach (string name in group1)
                    {
                        Console.WriteLine(name);
                    }
                 
                break;
                case 2:
                    Console.WriteLine("Group number 2");
                    for (int i=0; i<group2.Length; i++)
                    {
                        Console.WriteLine(group2[i]);
                    }
                break;
                default:
                    Console.WriteLine("only 1 or 2");
                    break;
            }
            Console.ReadLine();
        }
    }
}
