using System;
using System.Collections.Generic;
using System.Text;

namespace ContactPractise
{
    public class Car
    {
        //fieldler
       public string Brand;
       public string  Model;
       protected string HorsePower;
       private int _speed;

        public Car()
        {

        }
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;  

        }
        public string Info()
        {

            return $"{Test()} {HorsePower} {_speed}";
        }
        private string Test()
        {
            return Brand;
        }
    }
}
