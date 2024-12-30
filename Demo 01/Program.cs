using Demo_01._02_Class;
using Demo_01.Encapsulation;
using Demo_01.Struct;

namespace Demo_01
{
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum
    #region Struct
    // Namespace access modifier

    // file => C# 11.0 => Accessible only inside the file 
    // internal => Default Access Modifier => Accessible inside the same project only or the assembly file (dll)
    // public => Accessible Anywhere
    
    #endregion


    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Struct
            //// Struct => Value Type : Stack

            //// Employee
            //// Id, Name, Salary

            //// Point

            //Point P01;
            ////// Declare an object of type Point
            ////// P01 => Object
            ////// Allocate unitialized 8 bytes at stack

            //////Console.WriteLine(P01.X);
            //////Console.WriteLine(P01.Y);

            ////P01.X = 10;
            ////P01.Y = 20;

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////P01 = new Point();

            //P01 = new Point(1,2);
            //// new : Used for selecting the constructor

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////P01.PrintPoint();

            //Console.WriteLine(P01); 
            #endregion

            #region OOP

            // OOP => Object Oriented Programming (Programming Paradigm)
            //     => Best Paradigm to build any business

            // Class => Blueprint of the object
            // Object => Specific Instance of the class

            // 4 Pillars :-
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction

            #endregion

            #region Encapsulation
            // Encapsulation
            // => Class or Struct
            // => Seperating the data(Attributes) definition from its use
            // => [Setter Getter Method - Properties]

            // Employee
            // Id, Name, Salary

            // Problems with the direct access to the attributes
            // 1. End User can access data itself
            // 2. No Read Only Field
            // 3. No Data Validation

            // Applying Encapsulation 
            // 1. Make All Data (Attributes) Private
            // 2. Access Data through : 
            // 2.1 getter setter methods (Old Approach)
            // 2.2 Properties (New Approach)

            //Employee E01 = new Employee();

            ////// Setting Attributes directly
            ////E01.id = -1;
            ////E01.name = "A";
            ////E01.salary = -12_000;

            ////// Getting Attributes directly
            ////Console.WriteLine(E01.id);
            ////Console.WriteLine(E01.name);
            ////Console.WriteLine(E01.salary);

            //// Setting Attributes using Setter Method
            //E01.SetId(1);
            //E01.SetName("Zaki Zaher");
            //E01.SetSalary(-12_000);

            //// Getting Attributes using Getter Method
            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            //Employee E02 = new Employee(10, "Rosie", 20_000);
            //Console.WriteLine(E02);

            //// Id => Read Only Attribute

            ////E02.SetId(12); // Doesn't exist
            //Console.WriteLine(E02.GetId()); // 0 (default value)

            ////// Setting Attributes using Proeperties
            //Employee E03 = new Employee();
            ////E03.Id = 12; // Invalid => Read Only
            //E03.Name = "Bassem Basel";
            //E03.Salary = 4_000;
            //E03.Address = "Cairo";

            ////// Getting Attributes using Proeperties
            //Console.WriteLine(E03.Id);
            //Console.WriteLine(E03.Name);
            //Console.WriteLine(E03.Salary);
            //Console.WriteLine(E03.Address);


            #endregion Encapsulation

            #region Encapsulation - Indexer
            //// Indexer => Special Property

            //// PhoneBook

            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 123, 0);
            //phoneBook.AddPerson("Haerin", 456, 1);
            //phoneBook.AddPerson("Omar", 789, 2);

            ////Console.WriteLine(phoneBook.GetNumber("Haerin"));
            ////Console.WriteLine(phoneBook.GetNumber("Jennie"));

            ////phoneBook.SetNumber("Omar", 999);
            ////Console.WriteLine(phoneBook.GetNumber("Omar"));

            ////Console.WriteLine(phoneBook.GetName(123));
            ////Console.WriteLine(phoneBook.GetName(777));

            ////phoneBook.SetName(123, "Rosie");
            ////Console.WriteLine(phoneBook.GetName(123));

            //// Using Indexer
            //phoneBook["Omar"] = 666; 
            //Console.WriteLine(phoneBook["Omar"]);

            //Console.WriteLine(phoneBook[123]);
            //phoneBook[123] = "Jennie";
            //Console.WriteLine(phoneBook[123]);

            #endregion Encapsulation - Indexer

            #region Class

            //// Class => Reference Type : Heap
            //// Car : Id , Model, Speed

            Car C1;
            /// Declare for reference of type Car
            /// Refering to Null
            /// CLR will allocate 8 bytes at stack
            /// CLR will allocate 0 bytes at heap

            C1 = new Car(1001, "McLAREN P1", 250);
            /// new
            /// 1. Allocate the required number of bytes for the object at Heap 
            /// 2. Initialize the allocated bytes of the attributes with the attributes default values of each value
            /// 3. Call the user-defined constructor if exists 
            /// 4. Return the Address of the allocated object to the refernce 'C1'

            Console.WriteLine(C1);

            Console.WriteLine("============================");

            Car C2 = new Car(2002, "Ghost");
            Console.WriteLine(C2);

            Console.WriteLine("============================");

            Car C3 = new Car(3003);
            Console.WriteLine(C3);

            #endregion


        }
    }
}