/*
 * NOTES
 *
 * File name matches class name (not strictly needed like Java, but often done)
 *
 * ASSEMBLIES
 * "An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. "
 * Is either a .dll file (dynamic link library) on Mac, or .exe on Windows. 
 */


// =========================================================
// ======================= SYNTAX ==========================
// =========================================================

// bring in classes from these namespaces
using System;

// C# ignores whitespaces
// namespace CSharpBasics
// {
//     
//     // public --> global scope. 
//     public class NewClass 
//     {
//         
//         // Main method is in every C# program (entry point)
//         // static --> makes the method/property specific to the class, not to instances of the class
//         // shouldn't have public static methods/properties (global state)
//         // void keyword means the method returns nothing
//         static void Main(string[] args)
//         {
//             
//             // statements end with;
//             Console.WriteLine("Hello World!");
//         }
//     }
// }



// ========================================================
// ===================== VARIABLES ========================
// ========================================================
/*
 *
 * Variables also referred to as "unique identifiers"
 * 
 * char - single characters with single quotes - 'a'
 * string - double quotes - "Hello World"
 * int (32 bit)
 * long (64 bit int)
 * float - 6~7 decimals
 * double - 15 decimals
 * bool
 *
 * * Syntax:
 * type variableName = value;
 * string myName = "Chris";
 * 
 * */


// ===== BASICS =====

// WriteLine()
string introduction = "Hello, World!";
Console.WriteLine(introduction);


// Float - end with F
float myFloat = 5.75F;

// Double - can choose to end with D
double myDouble = 5.55;
double myDouble2 = 5.55D;
Console.WriteLine(myDouble.GetType());

// Bool
bool myBoolean = true;

// Change value
introduction = "New value";
Console.WriteLine(introduction);

// Character
char someLetter = 'z';
Console.WriteLine(someLetter.GetType()); // System.Char

// Implicit conversion - following throws an error for using double quotes
// char someString = "z";

// Assign value later 
int myNum;
myNum = 20;

// Constants - can't assign values later
const string myConst = "Value can't change";

// String concatenation
string name = "Chris";
Console.WriteLine("My name is " + name);

// Increment
int myNumber = 10;
myNumber += 1;
Console.WriteLine(myNumber); // 11

// Multiple assignments
int x = 1, y =  2, z = 3;
Console.WriteLine(x + y + z);