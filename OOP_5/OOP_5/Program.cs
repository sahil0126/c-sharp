using System;

namespace OOP_5
{
    class Program
    {
        //public static void Main(String[] args)
        //{
            /*
            Console.WriteLine("Hello! ");
            AnimalImplementationClass aic = new AnimalImplementationClass();
            aic.animalSleep();
            aic.sleep();
             */
            //Console.WriteLine("Program started");

            Tiger tiger = new Tiger();

            //IAnimal tiger = new Tiger(); -- This will give default implementation
            //tiger.AnimalSound();
            //tiger.Run();
            //Console.ReadLine();
        //}

    }

    // using interface




    /*
     It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
     */



    /*
     Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)
    */

    interface IAnimal
    {
        void AnimalSound() // This is using a default implementation (valid in C# 8+)
        {
            Console.WriteLine("This is a default implementation");

        }
        void Run();
    }

    class Tiger : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Roar");
        }

        public void Run()
        {
            Console.WriteLine("Tiger is Running ");
        }
    }














    // using abstract class

    /*
    abstract class Animal()
    {
        public abstract void animalSleep();

        public void sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    class AnimalImplementationClass() : Animal
    {
        public override void animalSleep()
        {
            Console.WriteLine("Animal is Sleeping");

        }
    }
     */






}

