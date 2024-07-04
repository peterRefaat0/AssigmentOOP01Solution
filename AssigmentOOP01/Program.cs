using System;
using Common;
namespace AssigmentOOP01
{

    #region 1
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    #region 3

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    #endregion

    #region 4
    enum Permissions : byte
    {
        Write = 1, Read = 2, Excute = 4, Delete = 8
    }
    class Employee
    {
        public int Id;
        public string Name;
        public decimal salary;
        public Permissions permissions;

    }
    #endregion

    #region 5

    enum Colors
    {
        Red,
        Green,
        Blue
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for (int i = 0; i < Enum.GetValues<WeekDays>().Length; i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //} 
            #endregion


            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];

            //people[0] = new Person { Name = "peter", Age = 24 };
            //people[1] = new Person { Name = "saad", Age = 27 };
            //people[2] = new Person { Name = "Ahmed", Age = 40 };

            //Console.WriteLine("People Details:");
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($" Name: {people[i].Name}, Age: {people[i].Age}");
            //}


            #endregion


            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //    Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //    string input = Console.ReadLine();

            //    if (Enum.TryParse(input, true, out Season season))
            //    {
            //        string months = GetSeasonMonths(season);
            //        Console.WriteLine($"{season} spans the months: {months}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid season entered.");
            //    }
            //}

            //static string GetSeasonMonths(Season season)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            return "March to May";
            //        case Season.Summer:
            //            return "June to August";
            //        case Season.Autumn:
            //            return "September to November";
            //        case Season.Winter:
            //            return "December to February";
            //        default:
            //            return "Unknown season";

            //    }


            #endregion


            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Employee employee = new Employee();
            //employee.Id = 100;
            //employee.Name = "maha";
            //employee.salary = 3000;
            //employee.permissions = Permissions.Read;

            //Permissions P1 = (Permissions)2;
            //P1 = P1 | Permissions.Delete;
            //Console.WriteLine(P1);

            //P1 &= ~(Permissions.Read);

            //P1 ^= Permissions.Read;
            //if ((P1 & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete Excisted");
            //}
            //else
            //    Console.WriteLine("not Exict");

            //Console.WriteLine(P1);


            #endregion



            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.


            //    Console.WriteLine("Enter a color name (Red, Green, Blue):");
            //    string input = Console.ReadLine();

            //    if (Enum.TryParse(input, true, out Colors color))
            //    {
            //        if (IsPrimaryColor(color))
            //        {
            //            Console.WriteLine($"{input} is a primary color.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{input} is not a primary color.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid color entered.");
            //    }
            //}

            //static bool IsPrimaryColor(Colors color)
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            return true;
            //        default:
            //            return false;
            //    }


            #endregion



            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter coordinates for Point 1:");
            //string input1 = Console.ReadLine();
            //string[] coordinates1 = input1.Split(',');

            //Console.WriteLine("Enter coordinates for Point 2 :");
            //string input2 = Console.ReadLine();
            //string[] coordinates2 = input2.Split(',');

            //Point point1 = new Point { X = double.Parse(coordinates1[0]), Y = double.Parse(coordinates1[1]) };
            //Point point2 = new Point { X = double.Parse(coordinates2[0]), Y = double.Parse(coordinates2[1]) };

            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));

            //Console.WriteLine($"The distance between the two points is: {distance:F2}");


            #endregion


            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person

            //Person[] people = new Person[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1} (Name, Age):");
            //    string input = Console.ReadLine();
            //    string[] details = input.Split(',');

            //    people[i] = new Person { Name = details[0], Age = int.Parse(details[1]) };
            //}
            //int oldestIndex = 0;
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > people[oldestIndex].Age)
            //    {
            //        oldestIndex = i;
            //    }
            //}

            //Console.WriteLine("Details of the oldest person:");
            //Console.WriteLine($"  Name: {people[oldestIndex].Name}, Age: {people[oldestIndex].Age}");


            #endregion



        }
    }
}
