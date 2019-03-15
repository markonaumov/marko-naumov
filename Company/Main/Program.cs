using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Marko", LastName = "Naumov", Role = Role.Other };
            SalesPerson sp = new SalesPerson("Bojan", "Sazdovski");
            Manager mg = new Manager("Damjan", "Temelko", 500);
            Employee emp2 = new Employee() { FirstName = "Petko", LastName = "petkovski", Role = Role.Other };
            Employee emp3 = new Employee() { FirstName = "Stanko", LastName = "stankovski", Role = Role.Other };
            Contractor cont = new Contractor("Ivan", "Ivanovski");
            Contractor cont2 = new Contractor("Stojan", "Stojanovski");
            Manager mg2 = new Manager("Elena", "Stojanovska", 400);

            Employee[] company = { sp, mg, mg2,cont,cont2 };

            CEO ceo = new CEO("Steve", "Jobs", 500, company, 120);
            ceo.AddSharePrice(200);
            

            ceo.GetInfo();
            Console.WriteLine($"The salary of CEO is {ceo.GetSalary()}");
            ceo.PrintEmployees();
            Console.ReadLine();

        }
    }
}