using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CEO : Employee
    {
       public Employee[] Employees;
       public int Shares;
       private double SharesPrice;

       public CEO (string firstname, string lastname, double salary, Employee[] emp,int shares)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Role = Role.Other;
            Employees = emp;
            Shares = shares;
            

        }
        
    public double AddSharePrice(double number)
        {
            SharesPrice += number;
            return SharesPrice;
        } 
    public void PrintEmployees()
        {   
            
            foreach(var emps in Employees)
            {
                Console.WriteLine($"{emps.FirstName} {emps.LastName}");
            }
        }
    public override double GetSalary()
        {
            Salary += Shares * SharesPrice;
            return Salary;
        }
    }
}
