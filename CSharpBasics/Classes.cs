using System;


// ========================================================
// ======================= CLASSES ========================
// ========================================================


// Create the type here & use instances in Program.cs
public class Car
{
    public string brand;
    public int odometer;

    // Constructor
    // Function that's automatically called for new instances
    // Must match class name & cannot have return types
    public Car(string carBrand, int carOdometer)
    {
        brand = carBrand;
        odometer = carOdometer;
    }
}


// ===== ACCESS MODIFIERS =====
// private: this class only (default if nothing specified)
// public: all classes
// protected: this class & inherited classes
// internal: within assembly

// Encapsulation: hiding details/sensitive data from users.


// === Properties ===
// Create field (attribute)
// Create method to allow read and/or write access to the name field
class Person
{
    // field
    private string name;

    // property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

// Define value of field & provide read-only access
class Computer
{
    private string name = "MacBook";

    public string Name
    {
        get { return name; }
    }
}


// Short-hand notation (write-only access
// How to use short-hand and provide values?
class Event
{
    public string Name { get; }
}


// =============================================
// ============== INHERITANCE ==================
// =============================================

// Helps with reusing fields/methods & use with polymorphism

// Base class
class Furniture
{
    public int price = 0;
}

// Derived class
class Table : Furniture
{
    public int price = 10;
}

// Use the sealed keyword to prevent inheritance
sealed class Apartment
{
    public string location;
}


// How objects are declared matters!

// === Base ===
// Furniture furnitureInstance = new Furniture();

// === Derived ===
// This will have the id field
// Furniture tableInstance = new Table();

// This won't have the id field (not derived)
// Table tableInstance = new Table();


// =============================================
// ============== POLYMORPHISM =================
// =============================================

// Modifying fields/methods that were inherited from a base class
// Use the virtual keyword in base class, and override keyword in derived class

class Vehicle
{
    public virtual void fact()
    {
        Console.WriteLine("All land vehicles have wheels");
    }
}

class Motorbike : Vehicle
{
    public override void fact()
    {
        Console.WriteLine("Motorbikes have two wheels");
    }
}


class Plane : Vehicle
{
    public override void fact()
    {
        Console.WriteLine("Planes also have wheels for takeoff");
    }
}