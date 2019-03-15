using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
            
        }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }



    }
}
