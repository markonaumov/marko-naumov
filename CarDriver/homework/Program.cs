using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework.CarAndDriver;

namespace homework
{
    class Program
    {
        public static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed(car1.Driver) > car2.CalculateSpeed(car2.Driver))
            {
                Console.WriteLine($"car number 1 {car1.Model} with speed of {car2.CalculateSpeed(car2.Driver)} wins");
            }
            else
            {
                Console.WriteLine($"car number 2 {car2.Model},and speed of{car2.CalculateSpeed(car2.Driver)} wins");
            }
        }

        

        static void Main(string[] args)
        {
            Car car1 = new Car("Suzuki", 225);
            Car car2 = new Car("Hyundai", 250);
            Car car3 = new Car("Ferrari", 290);
            Car car4 = new Car("Fiat", 220);

            Driver driver1 = new Driver("Marko", 10);
            Driver driver2 = new Driver("Igor", 12);
            Driver driver3 = new Driver("Bojan", 11);
            Driver driver4 = new Driver("Damjan", 9);

            

            Car temp = new Car();
            Car temp2 = new Car();


            Console.WriteLine("Choose car number one: 1)Suzuki 2)Hyundai 3)Ferrari 4)Fiat");
            int carNo1 =int.Parse(Console.ReadLine());

            if(carNo1 == 1)
            {
                temp = car1;
                Console.WriteLine("you have chosen Suzuki");
            }if (carNo1 == 2)
            {
                temp = car2;
                Console.WriteLine("you have chosen Hyundai");
            } if (carNo1 == 3)
            {
                temp = car3;
                Console.WriteLine("you have chosen Ferrari");
            } if(carNo1 == 4)
            {
                temp = car4;
                Console.WriteLine("you have chosen Fiat");
            }

            Console.WriteLine("Choose driver number one: 1)Marko 2)Igor 3)Bojan 4)Damjan");
            int nameNo1 = int.Parse(Console.ReadLine());

            if (nameNo1 == 1)
            {
                temp.Driver = driver1;
                Console.WriteLine("you have chosen Marko");
            }
            if (nameNo1 == 2)
            {
                temp.Driver = driver2;
                Console.WriteLine("you have chosen Igor");
            }
            if (nameNo1 == 3)
            {
                temp.Driver = driver3;
                Console.WriteLine("you have chosen Bojan");
            }
            if (nameNo1 == 4)
            {
                temp.Driver = driver4;
                Console.WriteLine("you have chosen Damjan");

            }

            Console.WriteLine("Choose car number two: 1)Suzuki 2)Hyundai 3)Ferrari 4)Fiat");
            int carNo2 = int.Parse(Console.ReadLine());

            if (carNo2 == 1)
            {
                temp2 = car1;
                Console.WriteLine("You have chosen Suzuki");
            }
            if (carNo2 == 2)
            {
                temp2 = car2;
                Console.WriteLine("You have chosen Hyundai");
            }
            if (carNo2 == 3)
            {
                temp2 = car3;
                Console.WriteLine("You have chosen Ferrari");
            }
            if (carNo2 == 4)
                
            {
                temp2 = car4;
                Console.WriteLine("You have chosen Fiat");

            }

            Console.WriteLine("Choose driver number two: 1)Marko 2)Igor 3)Bojan 4)Damjan");
            int nameNo2 = int.Parse(Console.ReadLine());

            if (nameNo2 == 1)
            {
                temp2.Driver = driver1;
                Console.WriteLine("You have chosen Marko");


            }
            if (nameNo2 == 2)
            {
                temp2.Driver = driver2;
                Console.WriteLine("You have chosen Igor");

            }
            if (nameNo2 == 3)
            {
                temp2.Driver = driver3;
                Console.WriteLine("You have chosen Bojan");

            }
            if (nameNo2 == 4)
            {
                temp2.Driver = driver4;
                Console.WriteLine("You have chosen Damjan");

            }

            if (temp == temp2)
            {
                Console.WriteLine("this car is chosen");
                Console.ReadLine();
            }
            if(temp.Driver == temp2.Driver)
            {
                Console.WriteLine("this driver is already chosen");
                Console.ReadLine();
            };

            
            RaceCars(temp, temp2);
            Console.ReadLine();

            

            
        }
    }

    
}
