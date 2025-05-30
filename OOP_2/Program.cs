namespace OOP_2
{


    //constructor


    class Colors
    {

        public string cname; //field

        //  // Create a class constructor for the Colors class
        public Colors()
        {
            cname = "Yellow";
            // Set the initial value for cname


            /*
             Note that the constructor name must match the class name, and it cannot have a return type (like void or int).Also note that the constructor is called when the object is created.All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.
            */
        }


        //static void Main(string[] args)
        //{
        //Colors colors = new Colors();
        // Create an object of the Colors Class (this will call the constructor)
        //Console.WriteLine(colors.cname);
        // Print the value of cname
        //Console.ReadLine();
        //}







    }


    class Car
    {
        public string carModel;
        public int carId;
        //constructor parameter

        public Car(string carModelName, int carIdNo)
        {
            carModel = carModelName;
            carId = carIdNo;
        }

        static void Main(string[] args)
        {
            Car car1 = new Car("Honda", 101);

            Console.WriteLine(car1.carModel + " -> " + car1.carId);
        }
    }
}
