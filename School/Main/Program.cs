using ClassLibrary;
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
            Student student1 = new Student("Kristijan", "Spirov", EnumGender.Male, 9.5);
            Student student2 = new Student("Bojan", "Ilev", EnumGender.Male, 6.2);
            Student student3 = new Student("Ivana", "Nakeva", EnumGender.Female, 8.5);
            Student student4 = new Student("Antonio", "Delev", EnumGender.Male, 2.9);
            Student student5 = new Student("Biljana", "Arsova", EnumGender.Female, 7.2);
            Student student6 = new Student("Angelina", "Gerovska", EnumGender.Female, 4.7);
            Student student7 = new Student("Silvija", "Bashovska", EnumGender.Female, 7.0);
            Student student8 = new Student("Adrijan", "Gigov", EnumGender.Male, 9.0);
            Student student9 = new Student("Simona", "Aneva", EnumGender.Female, 10.0);
            Student student10 = new Student("Ilina", "Spirkovska", EnumGender.Female, 5.6);
            List<Student> class1 = new List<Student>() { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };
            Student student11 = new Student("Gorjan", "Kirov", EnumGender.Male, 8.0);
            Student student12 = new Student("Vasko", "Pecov", EnumGender.Male, 7.6);
            Student student13 = new Student("Ivona", "Zdravevska", EnumGender.Female, 9.0);
            Student student14 = new Student("Lara", "Ivevska", EnumGender.Female, 5.9);
            Student student15 = new Student("Boris", "Savevski", EnumGender.Male, 7.0);
            Student student16 = new Student("Slavko", "Topuzov", EnumGender.Male, 3.5);
            Student student17 = new Student("Tijana", "Ickovska", EnumGender.Female, 4.6);
            Student student18 = new Student("Gorjan", "Petrevski", EnumGender.Male, 8.4);
            Student student19 = new Student("Vedran", "Mackov", EnumGender.Male, 9.8);
            Student student20 = new Student("Mirka", "Andreevska", EnumGender.Female, 6.0);
            List<Student> class2 = new List<Student>() { student11, student12, student13, student14, student15, student16, student17, student18, student19, student20 };
            List<Student> temp = new List<Student>();
            Console.WriteLine("Select a class: 1 or 2");
            
           try
            {
                int number = int.Parse(Console.ReadLine());
                if((number>0) && (number < 3)){
                    switch (number)
                    {
                        case 1:
                            temp = class1;
                            Console.Write("You selected Class1");
                        break;
                        case 2:
                            temp = class2;
                            Console.WriteLine("You selected Class2");
                        break;
                    }
                }
                else
                {
                    throw new Exception("wrong input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1) Print all female students");
                Console.WriteLine("2) Print all male students");
                Console.WriteLine("3) Print all students with first letter of name");
                Console.WriteLine("4) Print all students with grade higher then input 1-10");
                Console.WriteLine("5) Print Average grades in the class");
               
                int number2 = int.Parse(Console.ReadLine());
               
                    switch (number2)
                    {
                        case 1:
                            temp = temp.Where(x => x.Gender == EnumGender.Female).ToList();
                            foreach(var student in temp)
                            {
                                student.PrintInfo();
                            }

                        break;
                       case 2:
                            temp = temp.Where(x => x.Gender == EnumGender.Male).ToList();
                            foreach(var student in temp)
                            {
                                student.PrintInfo();
                            }
                        break;
                        case 3:
                            
                        
                        
                            Console.WriteLine("Enter a first letter");
                            string letter = Console.ReadLine();
                            temp = temp.Where(x => x.FirstName.Substring(0, 1) == letter).ToList();
                            bool isEmpty = temp.Any();
                            if (isEmpty)
                            {
                                foreach (var student in temp)
                                {
                                    student.PrintInfo();
                                    
                                    
                                }
                            }
                            else
                            {
                                
                                throw new Exception("There is no such student");
                                
                            }
                              
                        
                        break;
                        case 4:
                            Console.WriteLine("Enter a grade from 1 to 10");
                            double number3 = double.Parse(Console.ReadLine());
                        if ((number3 > 0) && (number3 < 11))
                        {
                            temp = temp.Where(x => x.AverageGrade >= number3).ToList();
                            foreach (var student in temp)
                            {
                                student.PrintInfo();
                            }
                        }
                        else
                        {
                            throw new Exception("Wrong number");
                        }
                        break;
                        case 5:
                        double sum = 0;
                            foreach(var student in temp)
                        {
                           
                            sum += student.AverageGrade;   
                        }
                        double average = sum / temp.Count;
                        Console.WriteLine($"The average is {average}");
                        break;
                    }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
       


    }
}
