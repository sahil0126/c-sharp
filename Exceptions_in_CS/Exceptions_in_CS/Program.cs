using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {

                int[] num = { 1, 2, 3 };
                Console.WriteLine(num[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("Enter valid Index");
            }
            finally
            {
                Console.WriteLine("This is Finally Block");
            }
            */
            CheckAge(26);

        }
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("You are not Eligible");
            }
            else
            {
                Console.WriteLine("You are Eligible");
            }
        }
    }
}
