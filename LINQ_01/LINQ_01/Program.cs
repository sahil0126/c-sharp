class Program
{
    static void Main(string[] args)
    {
        //int[] age = { 21, 34, 13, 54, 23, 27, 29, 45, 52, 65, 37, 16, 20, 30 };

        //var a = from i in age where i > 25 select i;
        //var a = from i in age where i > 20 orderby i select i; // by default it is ascending
        //var a = from i in age where i > 20 orderby i descending select i;

        //foreach (int item in a)
        //{
        //    Console.WriteLine(item);
        //}


        string[] fruits = { "apple", "banana", "orange", "kiwi", "grapes" };

        //var a = from fruit in fruits where fruit.Contains("a") select fruit;
        var a = from fruit in fruits where fruit.StartsWith("a") select fruit;
        foreach (string item in a)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
