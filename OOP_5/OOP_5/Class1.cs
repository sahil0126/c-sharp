namespace OOP_5
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program Started");
            Demo demo = new Demo();
            demo.myFirstMethod();
            demo.mySecondMethod();
            Console.ReadLine();

        }

        interface IFirstInterface
        {
            void myFirstMethod();

        }
        interface ISecondInterface
        {
            void mySecondMethod();

        }

        class Demo : IFirstInterface, ISecondInterface
        {
            public void myFirstMethod()
            {
                Console.WriteLine("This is First Method Implementation");
            }

            public void mySecondMethod()
            {
                Console.WriteLine("This is Second Method Implementation");
            }
        }
    }

}
