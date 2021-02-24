
using System;

namespace CSharpBasics
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Car carInstance1 = new Car(carBrand:"Toyota", carOdometer:345);
            Console.WriteLine($"Brand: {carInstance1.brand}");
            Console.WriteLine($"Odometer: {carInstance1.odometer}");

            Person personInstance1 = new Person();
            // Console.WriteLine(personInstance1.Name);
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
            
            Computer myComputer = new Computer();
            Console.WriteLine($"Computer name: {myComputer.Name}");

            Table tableInstance = new Table();
            tableInstance.id = 0;
            tableInstance.price = 200;
            

        }
    }
}