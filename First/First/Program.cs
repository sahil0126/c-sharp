using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.WriteLine("Hello World!");
                        Console.WriteLine(3+3);
                        Console.WriteLine(3-3);
                        Console.WriteLine(3*3);
                        Console.WriteLine(3/3);
                        Console.WriteLine(3%3);
                        Console.Write("Hello World");
                        Console.Write("First Program");
            string name = "Sahil ";
            Console.WriteLine(name);

            int roll_no = 42;
            Console.WriteLine(roll_no);

            string cityName;
            cityName = "Mumbai";
            Console.WriteLine(cityName);

            const string colorName = "yellow";
            //colorName = "red";
            Console.WriteLine(colorName);

            //implicit casting
            int marks = 73;
            double percent = marks;
            Console.WriteLine(marks);
            Console.WriteLine(percent);

            //explicit casting
            double price = 53.23;
            int iprice = (int)price;
            Console.WriteLine(price);
            Console.WriteLine(iprice);

            //user input
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Name is :- "+name);

            // return type of ReadLine is String it
            // will throw error if we try to output int type data
            // so to avoid it we have to convert it to int
            // or any particular type data

            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is :- " + age);
            
             

            //c# math
            int x = 25, y = 10;

            Console.WriteLine("Max " + Math.Max(x, y));
            Console.WriteLine("Min " + Math.Min(x, y));
            Console.WriteLine("Sqrt of " + x +":- "+ Math.Sqrt(x));
            Console.WriteLine("Abs of-4.7 :- " + Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 :- " + Math.Round(9.99));

            
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);



            int age = 17;
            string result = (age >= 18) ? " Eligible " : " Not Eligible ";
            Console.WriteLine(result);

            //while loop

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // do while
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);

            // for loop
            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            string[] colors = { "yellow", "red","green","black" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            string[] colors = { "yellow", "red", "green", "black" };
            foreach (string c in colors)
            {
                Console.WriteLine(c);
            }


            int[] rollNo = { 21, 42, 35, 22, 95, 12, 5 };
            Array.Sort(rollNo);
            foreach (int r in rollNo)
            {
                Console.WriteLine(r);
            }


            //system.linq
            // to use linq we have to import it first
            int[] rollNo = { 21, 42, 35, 22, 95, 12, 5 };
            Console.WriteLine("Max Element in rollNo :- " + rollNo.Max());
            Console.WriteLine("Min Element in rollNo :- " + rollNo.Min());
            Console.WriteLine("Sum of all the Element in rollNo :- " + rollNo.Sum());


            //Sum(5, 10);

            MyMethod("USA");
            MyMethod();
            MyMethod("UAE");
            MyMethod("Swedan");
            MyMethod();
                
             */

            //rollNo(rn2: 22, rn3: 23,rn1: 21);


            //Console.WriteLine(calculate(5, 5));
            //Console.WriteLine(calculate(5, 5, 5));








            Console.ReadLine();
        }

        //static void Sum(int a,int b)
        //{
        //    //static means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
        //    int total_sum = a + b;
        //    Console.WriteLine(total_sum);


        //}

        //static void MyMethod(string country = "India")
        //{
        //    Console.WriteLine(country);
        //}

        //static void rollNo(int rn1,int rn2,int rn3)
        //{
        //    Console.WriteLine(rn1);
        //    Console.WriteLine(rn2);
        //    Console.WriteLine(rn3);
        //}

        //static int calculate(int x, int y)
        //{
        //    return x + y;
        //}


        //static int calculate(int x, int y, int z)
        //{
        //    return x + y + z;
        //}



    }
}
