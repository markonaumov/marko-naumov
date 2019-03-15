using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SalesPerson : Employee
    {
        public double SuccsessSalesRevenue;

        public SalesPerson(string name,string lastname)
        {
            FirstName = name;
            LastName = lastname;
            Role = Role.Sales;
            Salary = 500;
        }

        public double AddSuccsessRevenue(int number)
        {
            SuccsessSalesRevenue += number;
            return SuccsessSalesRevenue;
        }

        public override double GetSalary()
        {
            if (SuccsessSalesRevenue <= 2000)
            {
                return Salary + 500;
            } else if (SuccsessSalesRevenue <= 5000)
            {
                return Salary + 800;
            } else if (SuccsessSalesRevenue > 5000)
            {
                return Salary + 2000;
            } else
            {
                return Salary;
            }
            
        }
    }
}
