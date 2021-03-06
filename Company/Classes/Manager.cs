﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstname, string lastname, double salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Role = Role.Manager;
        }

        public double AddBonus (double num)
        {
            return Bonus += num;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;
        }

    }
}
