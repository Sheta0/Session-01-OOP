using Assignment_01.Part_01.Q1;
using Assignment_01.Part_01.Q2;
using Assignment_01.Part_02.Q1;
using System.Linq.Expressions;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01: Struct

            #region Q1

            //Point p1 = new Point();
            //Point p2 = new Point();

            //int x1, y1, x2, y2;
            //Console.WriteLine("Enter the first Point");
            //do
            //{
            //    Console.Write("X : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out x1));
            //p1.X = x1;

            //do
            //{
            //    Console.Write("Y : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out y1));
            //p1.Y = y1;

            //Console.WriteLine("=================================");

            //Console.WriteLine("Enter the second Point");
            //do
            //{
            //    Console.Write("X : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out x2));
            //p2.X = x2;

            //do
            //{
            //    Console.Write("Y : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out y2));
            //p2.Y = y2;

            //double Distance = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));

            //Console.WriteLine("=================================");

            //Console.WriteLine($"Distance = {Distance}");
            #endregion

            #region Q2

            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Person {i + 1} Info : ");

            //    string InputName;
            //    do
            //    {
            //        Console.Write("Name : ");
            //        InputName = Console.ReadLine();
            //    }
            //    while (string.IsNullOrWhiteSpace(InputName));

            //    int InputAge;
            //    do
            //    {
            //        Console.Write("Age : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out InputAge) || InputAge <= 0);

            //    people[i] = new Person(InputName, InputAge);

            //    Console.WriteLine("=====================================");
            //}

            //Person OldestPerson = people[0];

            //for (int i = 1; i < 3; i++)
            //{
            //    if (people[i].Age > OldestPerson.Age)
            //    {
            //        OldestPerson = people[i];
            //    }
            //}

            //Console.WriteLine($"Oldest person name : {OldestPerson.Name}, Age : {OldestPerson.Age}");

            #endregion

            #endregion

            #region Part 02

            //// Testing Errors

            //try
            //{

                #region Testing Errors
                ////// Testing Errors
                ////////////////Employee E1 = new Employee(1, "Ahmed", SecurityLevel.Developer, 2_000, new HiringDate(15, 3, 2024), Gender.M);
                //////////////Employee E2 = new Employee(1, "Ahmed", SecurityLevel.Developer, 7_000, new HiringDate(35, 3, 2024), Gender.M);
                ////////////Employee E3 = new Employee(1, "Ahmed", SecurityLevel.Developer, 7_000, new HiringDate(15, -6, 2024), Gender.M);
                //////////Employee E4 = new Employee(1, "Ahmed", SecurityLevel.Developer, 7_000, new HiringDate(15, 5, 2026), Gender.M);
                ////////Employee E5 = new Employee(1, "", SecurityLevel.Developer, 7_000, new HiringDate(15, 5, 2023), Gender.M);
                //////Employee E6 = new Employee(-1, "Ahmed", SecurityLevel.Developer, 7_000, new HiringDate(15, 5, 2023), Gender.M);
                ////Employee E7 = new Employee(1, "Ahmed", (SecurityLevel) 17, 7_000, new HiringDate(15, 5, 2023), Gender.M);
                //Employee E8 = new Employee(1, "Ahmed", (SecurityLevel) 14 , 7_000, new HiringDate(15, 5, 2023), (Gender)3);

                ////////////////Console.WriteLine(E1);
                //////////////Console.WriteLine(E2);
                ////////////Console.WriteLine(E3);
                //////////Console.WriteLine(E4);
                ////////Console.WriteLine(E5);
                //////Console.WriteLine(E6);
                ////Console.WriteLine(E7);
                //Console.WriteLine(E8); 
                #endregion

            //    Employee[] EmpArr = new Employee[3];
            //    EmpArr[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 7_000, new HiringDate(15, 12, 2020), Gender.M);
            //    EmpArr[1] = new Employee(2, "Ali", SecurityLevel.Guest, 11_000, new HiringDate(1, 3, 2020), Gender.M);
            //    EmpArr[2] = new Employee(3, "Haerin", (SecurityLevel)15, 19_000, new HiringDate(5, 7, 2019), Gender.F);

            //    int boxingCount = 0;
            //    int unboxingCount = 0;

            //    int CompareEmployeesByHireDate(Employee x, Employee y)
            //    {
            //        boxingCount += 2; // Boxing occurs when accessing x.HireDate and y.HireDate
            //        int result = DateTime.Compare(
            //            new DateTime(x.HireDate.Year, x.HireDate.Month, x.HireDate.Day),
            //            new DateTime(y.HireDate.Year, y.HireDate.Month, y.HireDate.Day)
            //        );
            //        unboxingCount += 2; // Unboxing occurs when comparing the DateTime values
            //        return result;
            //    }

            //    Array.Sort(EmpArr, CompareEmployeesByHireDate);

            //    foreach (var emp in EmpArr)
            //    {
            //        Console.WriteLine(emp);
            //        Console.WriteLine("================================");
            //    }

            //    Console.WriteLine($"Boxing operations: {boxingCount}");
            //    Console.WriteLine($"Unboxing operations: {unboxingCount}");
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //}

            #endregion
        }
    }
}
