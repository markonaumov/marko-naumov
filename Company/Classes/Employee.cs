using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary { get; set; } 

        public void GetInfo()
        {
            Console.WriteLine("First name: {0}, Last name: {1}, Salary:{2}", FirstName, LastName, Salary);
        }
        
        public virtual double GetSalary()
        {
            return Salary;
        }
    }       
}
