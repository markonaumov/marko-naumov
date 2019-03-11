using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.CarAndDriver
{
   public class Car
    {
        public string Model;
        public int Speed;
        public Driver Driver;

        public Car()
        {

        }

        public Car(string model,int speed)
        {
            Model = model;
            Speed = speed;
        }



        public int CalculateSpeed(Driver driver)
        {
            int result = Speed * driver.Skill;
            return result;


        }

        


    }
}
