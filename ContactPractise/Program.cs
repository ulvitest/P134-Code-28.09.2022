using System;
using System.Reflection;

namespace ContactPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contact contact = new Contact("Cavid","Memmedli","javidsm@","051 447 34 10","sikayetciyem");
            //Console.WriteLine(contact.Info());

            //class members: fieldler,propertyler,methodlar;

            // public :classlar,all class membersler 
            // istifade yeri: Classin ozu,instance yaratdigin yer,inheritance;

            //protected: all class members

            //istifade yer: classin ozu,inheritance, instance-da el catan deyil;

            //private: all class members

            //istifade yer: classin ozu;


            Car car = new Car();
            car.Brand = "Lorem";
            car.Model = "Ipsum";
            typeof(Car).GetField("_speed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(car, 50) ;
            var speed = typeof(Car).GetField("_speed", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(car);
            //Console.WriteLine(speed);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            //car.HorsePower = "";
           
        }
    }
}
