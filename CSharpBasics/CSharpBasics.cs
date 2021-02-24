//
//
//
// // /*
// //  * NOTES
// //  *
// //  * File name matches class name (not strictly needed like Java, but often done)
// //  *
// //  * ASSEMBLIES
// //  * "An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. "
// //  * Is either a .dll file (dynamic link library) on Mac, or .exe on Windows. 
// //  */
// //
// //
// // // =========================================================
// // // ======================= SYNTAX ==========================
// // // =========================================================
// // // bring in classes from these namespaces
//
// using System;
// using System.Security.Cryptography;
// using System.Linq;
// using System.Net.Sockets;
//
//
// // C# ignores whitespaces
// // namespace CSharpBasics
// // {
// //     
// //     // public --> global scope. 
// //     public class NewClass 
// //     {
// //         
// //         // Main method is in every C# program (entry point)
// //         // static --> makes the method/property specific to the class, not to instances of the class
// //         // shouldn't have public static methods/properties (global state)
// //         // void keyword means the method returns nothing
// //         static void Main(string[] args)
// //         {
// //             
// //             // statements end with;
// //             Console.WriteLine("Hello World!");
// //         }
// //     }
// // }
//
//
// // ========================================================
// // ===================== VARIABLES ========================
// // ========================================================
// /*
//  *
//  * Variables also referred to as "unique identifiers"
//  * 
//  * char - single characters with single quotes - 'a'
//  * string - double quotes - "Hello World"
//  * int (32 bit)
//  * long (64 bit int)
//  * float - 6~7 decimals
//  * double - 15 decimals
//  * bool
//  *
//  * * Syntax:
//  * type variableName = value;
//  * string myName = "Chris";
//  * 
//  * */
//
//
// // ===== BASICS =====
//
// // WriteLine()
// string introduction = "Hello, World!";
// Console.WriteLine(introduction);
//
// // Float - end with F
// float myFloat = 5.75F;
//
// // Double - can choose to end with D
// double myDouble = 5.55;
// double myDouble2 = 5.55D;
// Console.WriteLine(myDouble.GetType());
//
// // Bool
// bool myBoolean = true;
//
// // Change value
// introduction = "New value";
// Console.WriteLine(introduction);
//
// // Character
// char someLetter = 'z';
// Console.WriteLine(someLetter.GetType()); // System.Char
//
// // Implicit conversion - following throws an error for using double quotes
// // char someString = "z";
//
// // Assign value later 
// int myNum;
// myNum = 20;
//
// // Constants - can't assign values later
// const string myConst = "Value can't change";
//
// // String concatenation
// string food = "chocolate";
// Console.WriteLine("Favourite food is " + food);
//
// // Increment
// int myNumber = 10;
// myNumber += 1;
// Console.WriteLine(myNumber); // 11
//
// // Multiple assignments
// int x = 1, y = 2, z = 3;
// Console.WriteLine(x + y + z);
//
// // Scientific numbers
// double sciNum = 5e3; // 5 x 10^3 = 5000 
// Console.WriteLine(sciNum);
// float f2 = 5.234e2F;
// Console.WriteLine(f2); // 523.4
//
// // ========================================================
// // ==================== TYPE CASTING ======================
// // ========================================================
// // Assigning a value of one data type to another
//
// // ===== Implicit type casting =====
// // Can automatically cast from larger to smaller types
// // char -> int -> long -> float -> double
// int myNumAsInteger = 5;
// double myNumAsDouble = myNumAsInteger;
// Console.WriteLine(myNumAsDouble); // 5
//
// // ===== Explicit type casting =====
// // When going from large to smaller types
// // double -> float -> long -> int -> char
//
// // Method 1: Explicitly wrap type in () after assignment operator
// double myNum2 = 6.57;
// int myInt2 = (int) myNum2;
// Console.WriteLine(myInt2); // 6 (lose decimals)
//
// // Method 2: use built-in functions
// int myNum3 = 23453;
// string myString = Convert.ToString(myNum3);
// Console.WriteLine(myString.GetType()); // string
//
// // ========================================================
// // ===================== USER INPUT =======================
// // ========================================================
//
// // Get user name as string & write to console
// // Console.WriteLine("Enter username:");
// // string userName = Console.ReadLine();
// // Console.WriteLine("You entered: " + userName);
//
// // ReadLine() returns a string, so assigning it to other data types like an int will throw an error
// // Need to change to int first
// // Console.WriteLine("Enter your age:");
// // int age = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("You are " + age + " years old.");
//
// // ========================================================
// // ===================== OPERATORS ========================
// // ========================================================
//
// // ====== Arithmetic & mod =====
// // + - * / % 
//
// // Exponent
// Math.Pow(5, 2);
//
// // Increment/decrement
// // ++  --
// int counter = 5;
// counter++;
// Console.WriteLine(counter); // 6
//
// // ===== Assignment =====
// int var1 = 5;
// var1 += 10;
// Console.WriteLine(var1); // 15
//
// // ===== Comparisons =====
// // == 
// // !=
// // >
// // <
// // >=
// // <=
//
// // ===== Logical =====
// // and - &&
// // or  - ||
// // not - !
//
// // ========================================================
// // ===================== STRINGS ==========================
// // ========================================================
//
// // Length
// string randomLetters = "adjfakjf";
// Console.WriteLine(randomLetters.Length);
//
// // ===== String interpolation =====
// Console.WriteLine($"The random letters are: {randomLetters}");
//
// // Find index (of first match)
// Console.WriteLine(randomLetters.IndexOf("a"));
//
// // Substring
// string fullName = "John Smith";
// int blankSpaceIndex = fullName.IndexOf(" ");
// string lastName = fullName.Substring(blankSpaceIndex + 1);
// Console.WriteLine(lastName); // Smith
//
// // Escape character
// Console.WriteLine("This is a \"quotation\" mark.");
// Console.WriteLine("This is a \nnew line.");
// Console.WriteLine("This is a \ttab.");
// Console.WriteLine("This is a \bbackspace.");
//
// // ========================================================
// // =================== CONTROL FLOW =======================
// // ========================================================
//
// // ===== IF ELSE =====
// if (lastName.Length > 5)
// {
//     Console.WriteLine("Last name is longer than 5 characters");
// }
// else if (lastName == "Smith")
// {
//     Console.WriteLine("Stop here");
// }
// else
// {
//     Console.WriteLine("Last name is shorter than 5 characters");
// }
//
// // ===== TERNARY OPERATOR =====
// // Shorthand for if/else
// string isLongName = (lastName.Length > 5) ? "Is long" : "Is short";
// Console.WriteLine(isLongName);
//
// // ===== SWITCH =====
// int day = 4;
// switch (day)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     case 4:
//         Console.WriteLine("Thursday");
//         break;
//     default:
//         Console.WriteLine("Other");
//         break;
// }
//
// // ===== WHILE LOOP =====
// // Runs while condition is true
// int myCounter = 0;
// while (myCounter < 10)
// {
//     Console.WriteLine("Hello, World!");
//     myCounter++;
//
//     if (myCounter == 4)
//     {
//         break;
//     }
// }
//
// // ===== DO/WHILE LOOP =====
// // Runs once, then continues while condition is true
// // The following runs 11 times
// do
// {
//     Console.WriteLine("This will run once even while the condition is false.");
// } while (false);
//
// // ===== FOR LOOP =====
//
// // Syntax
// // for (execute ONCE before code block; defines condition; executed each time AFTER code block)
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine($"No. times executed: {i}");
// }
//
// // ===== FOREACH LOOP =====
// // Iterate over array
// string[] names = {"Bob", "Kate", "Will", "James", "Mark"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
//
// // ===== BREAK & CONTINUE =====
// // break: stop altogether
// // continue: breaks once, then continues
// int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
// foreach (int number in numbers)
// {
//     if (number == 2)
//     {
//         Console.WriteLine("Skipping iteration");
//         continue;
//     }
//
//     Console.WriteLine(number);
//
//     if (number == 8)
//     {
//         Console.WriteLine("Stopping");
//         break;
//     }
// }
//
// // ========================================================
// // ======================= ARRAYS =========================
// // ========================================================
//
// // Use curly braces
// int[] integers = {1, 6, 3, 7};
// Console.WriteLine($"integers has {integers.Length} elements.");
// Array.Sort(integers);
// Console.WriteLine(integers); // System.Int32[] - doesn't print the whole array
//
// // Iterating - foreach loop
// foreach (int integer in integers)
// {
//     Console.WriteLine(integer);
// }
//
// // Iterating - for loop
// for (int i = 0; i < integers.Length; i++)
// {
//     Console.WriteLine(integers[i]);
// }
//
// // ===== Useful functions =====
// // using System.Linq; (start of file)
// // contains functions like Min, Max, Sum
//
// // ===== Declaring arrays =====
//
// // Create an array of four elements, and add values later
// string[] cars1 = new string[4];
//
// // Create an array of four elements and add values right away 
// string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
//
// // Create an array of four elements without specifying the size 
// string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
//
// // Create an array of four elements, omitting the new keyword, and without specifying the size
// string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};
//
// // If declaring empty array and initialising later, need to use the new keyword
// double[] measurements;
// measurements = new double[] {1.324, 2.3425, 2.2345};
//
// // ========================================================
// // ======================= METHODS ========================
// // ========================================================
//
// // C# 9 allows for top level methods (functions?)
// // Though will almost exclusively be associated with a class.
//
// // static: associated with the class, not instances
// // object: refers to some variable that is created in memory. Could be an instance, or an integer variable etc
//
// // No return value
// static void MyMethod()
// {
//     Console.WriteLine("Running MyMethod()");
// }
//
// MyMethod();
//
//
// // ===== PARAMETERS =====
//
// // Returning an integer
// int AddTwoIntegers(int x, int y)
// {
//     return x + y;
// }
//
// int result = AddTwoIntegers(x: 5, y: 8);
// Console.WriteLine(result);
//
//
// // Different types of parameters
// void NameAndAge(string name, int age)
// {
//     Console.WriteLine($"My name is {name} and I am {age} years old.");
// }
//
//
// // Default parameters
// string ConfirmUsername(string userName = "none provided")
// {
//     string message = $"You entered: {userName}";
//     return message;
// }
//
// Console.WriteLine(ConfirmUsername());
//
//
// // Names arguments (specifying some arguments only)
// void PrintNumbers(int num1 = 5, int num2 = 10, int num3 = 15)
// {
//     Console.WriteLine($"Numbers are: {num1}, {num2}, {num3}");
// }
// PrintNumbers(num2: 1000);
//
//
// // Returning an array?
// // Array as input?
//
//
// // ===== METHOD OVERLOADING =====
// // Declaring the same method twice with different parameter data types to handle both (instead of defining two separate functions)
// // Couldn't declare multiple times at top level so put inside the AdditionClass class below.
//
// class AdditionFunctions
// {
//     
//     // int
//     public static int Add(int num1, int num2)
//     {
//         return num1 + num2;
//     }
//     
//     // float
//     public static float Add(float num1F, float num2F)
//     {
//         return num1F + num2F;
//     }
//     
//     // double
//     public static double Add(double num1, double num2)
//     {
//         return num1 + num2;
//     }
//     
// }
//

