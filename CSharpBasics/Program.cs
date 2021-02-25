using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes
            Car carInstance1 = new Car(carBrand: "Toyota", carOdometer: 345);
            Console.WriteLine($"Brand: {carInstance1.brand}");
            Console.WriteLine($"Odometer: {carInstance1.odometer}");

            Person personInstance1 = new Person();
            Console.WriteLine(personInstance1.Name);
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            Computer myComputer = new Computer();
            Console.WriteLine($"Computer name: {myComputer.Name}");


            // Inheritance
            Furniture tableInstance1 = new Table();
            Table tableInstance2 = new Table();

            Console.WriteLine(tableInstance1.price); // 0 - base class value ovverides
            Console.WriteLine(tableInstance2.price); // 10 - base class value doesn't override


            // Polymorphism
            Vehicle vehicleInstance = new Vehicle();
            Vehicle motorbikeInstance = new Motorbike();
            Vehicle planeInstance = new Plane();

            vehicleInstance.fact();
            motorbikeInstance.fact();
            planeInstance.fact();
        }
    }
}