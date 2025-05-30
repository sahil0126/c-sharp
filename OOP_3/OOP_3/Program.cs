using System;

namespace OOP_3
{
    // property and encapsulation
    /*
    class Person
    {
        //field
        private int _id;
        private string _name;
        private int _age;

        //property


        // short hand
        //public int Id 
        //{ get; set; }

        public int Id { get => _id; set => _id = value; }
        public int Age { get => _age; set => _age = value; }
        public global::System.String Name { get => _name; set => _name = value; }
    }
    
     */

    class Vehicle //base
    {
        public string brand = "Honda";
        public void honk()
        {
            Console.WriteLine("Vehicle Honks");
        }
    }

    class Car : Vehicle // derived
    {
        public string carName = "Honda City";
    }



    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "Star";
            //person.Age = 25;
            //Console.WriteLine(person.Id);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);

            Car car = new Car();
            Console.WriteLine(car.brand);
            Console.WriteLine(car.carName);
            car.honk();


            Console.ReadLine();

        }








    }
}
