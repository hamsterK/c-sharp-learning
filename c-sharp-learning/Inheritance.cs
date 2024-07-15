namespace learning_inheritance
{
    class Vehicle  // base class == parent
    // sealed class Vehicle  - "sealed" restricts inheritance
    {
        public string brand = "Ford";  // vehicle field
        public void honk() // vehicle method
        {
            Console.WriteLine("Beep");
        }
    }

    class Car : Vehicle // derived class == child
    {
        public string modelName = "Mustang"; // car field
    }

    class Program
    {
        static void Main7(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}


