using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.CarAndDriver
{
    public class Driver
    {
        public string Name;
        public int Skill;

        public Driver()
        {

        }

        public Driver(string name,int skill)
        {
            Name = name;
            Skill = skill;
        }

        public void DriverInfo()
        {
            Console.WriteLine($"Driver name:{Name}, Driver skill{Skill}");
        }
    }
}
