using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.Struct
{
    internal struct Point
    {
        public int X; // 4 bytes
        public int Y; // 4 bytes

        // Constructor : Special Method
        //               1. Name is same as the class name
        //               2. No return type

        // CLR will generate a parameterless contructor
        // This constructor will initialize all the fields with their default values

        // .NET 5.0 C# 9.0 
        // .NET 6.0 C# 10.0 
        // .NET 7.0 C# 11.0
        public Point()
        {
            X = 8;
            Y = 8;
        }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }
}
