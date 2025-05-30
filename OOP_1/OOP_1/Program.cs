using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{





    class Car
    {
        string carColor = "white";

        static void Main(string[] args)
        {
            //object creation
            /*
            Car c1 = new Car();
            Car c2 = new Car();
            Console.WriteLine(c1.carColor);
            Console.WriteLine(c2.carColor);

            Car2 car2 = new Car2();
            car2.carName = "Toyota";
            Console.WriteLine(car2.carName);
            Console.WriteLine(car2.color);
            Console.WriteLine(car2.maxSpeed);
            Console.ReadLine();
             */

            //using this main method to execute
            Bike b1 = new Bike();
            b1.bikeName = "Xtreme 250";
            b1.color = "Red";
            b1.maxSpeed = 160;
            Console.WriteLine(b1.bikeName);

            Bike b2 = new Bike();
            b2.bikeName = "RR310";
            b2.color = "Red";
            b2.maxSpeed = 170;
            Console.WriteLine(b2.bikeName);
            Console.WriteLine(b2.color);
            Console.WriteLine(b2.maxSpeed);
            b2.fullThrottle();
        }
    }

    class Car2
    {

        /*
         * 
         * 
         * Fields and methods inside classes are often referred to as "Class Members":
         * 
         * 
         * 
         You can also create an object of a class and access it in another class. This is often used for better organization of classes (one class has all the fields and methods (class Car2), while the other class (Car) holds the Main() method (code to be executed))*/
        //Class member
        public string carName;
        public string color = "grey"; //field
        public int maxSpeed = 200;  //field
        public void incSpeed()
        {
            Console.WriteLine("Car is Moving");

        }
    }

    class Bike
    {
        public string bikeName;
        public string color;
        public int maxSpeed;

        public void fullThrottle()
        {
            Console.WriteLine("Bike is in full Speed");
        }
    }

}
