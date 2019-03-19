using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main
{

    class Program
    {
        public static void FindNumber(Dictionary<string,int> dic,string name)
        {
            if(!dic.ContainsKey(name))
            {
                Console.WriteLine("there is not such name");
            }
            else
            {
                Console.WriteLine($"{name}'s number is {dic[name]}");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> phonebook = new Dictionary<string, int>()
            {
                {"marko",343 },
                {"damjan",234 },
                {"sazdo",345 }
            };

            FindNumber(phonebook, "marko");
            
            Console.ReadLine();


        }
    }
}