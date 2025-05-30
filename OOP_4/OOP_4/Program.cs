using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Animal animal = new Animal();
            //Cat cat = new Cat();
            //Dog dog = new Dog();

            Animal animal = new Animal();
            Animal cat = new Cat();
            Animal dog = new Dog();

            animal.animalSound();
            cat.animalSound();
            dog.animalSound();
        }
    }

    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("This animal makes a Sound");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }


}