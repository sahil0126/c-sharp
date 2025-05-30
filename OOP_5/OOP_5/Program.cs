using System;

namespace OOP_5
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*
            Console.WriteLine("Hello! ");
            AnimalImplementationClass aic = new AnimalImplementationClass();
            aic.animalSleep();
            aic.sleep();
             */

            Tiger tiger = new Tiger();
            tiger.AnimalSound();
            tiger.Run();
            Console.ReadLine();
        }

    }

    // using interface

    /*
     It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
     */

    interface IAnimal
    {
        void AnimalSound()
        {
            Console.WriteLine("Hello ");
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

